using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class FrmBanco : Form
    {
        private CuentaManagement cuentaManagement;

        public FrmBanco()
        {
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            grpTipoTransac.Visible = false;
            grpDetalles.Visible = false;
            grpClienteActual.Visible = false;
            btnCerrar.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (cuentaManagement != null)
            {
                DialogResult result = MessageBox.Show("Su cuenta se eliminará de memoria. ¿Está seguro?", "Advertencia Cerrar Cuenta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.OK))
                {
                    cuentaManagement = null;
                    FrmBanco_Load(null, null);
                    btnCrearCuenta.Enabled = true;
                    lstRetiros.Items.Clear();
                    lstDep.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay cuenta activa en este momento");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMontoInicial.Text, out double monto))
            {
                if (monto < 0)
                {
                    MessageBox.Show("El monto inicial no puede ser menor a 0.00");
                    return;
                }
                string nombre = txtNombreCliente.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingrese un nombre valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Se crea una instancia única para el usuario en memoria
                cuentaManagement = new CuentaManagement(nombre, monto);
                btnCrearCuenta.Enabled = false;
                actualizarMovimientos();
            }
            else
            {
                MessageBox.Show("el monto inicial debe ser un número"
                    , "¡¡¡¡¡¡¡¡¡¡ERRORRRRRRRRR!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCuenta_EnabledChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (!button.Enabled)
                {
                    new ToolTip().Show("Crear cuenta ha sido deshabilitado hasta cerrar la cuenta activa", this, 30, 220, 3000);
                    button.BackColor = SystemColors.ControlDarkDark;
                }
                else
                {
                    button.BackColor = SystemColors.Control;
                    new ToolTip().Show("Puede crear una cuenta si desea", this, 100, 220, 3000);
                }
            }
        }

        // método dinámico que muestra o no los detalles
        private void mostrarDetallesCuenta(string nombre, bool valor)
        {
            grpTipoTransac.Visible = valor;
            grpDetalles.Visible = valor;
            grpClienteActual.Visible = valor;
            btnCerrar.Visible = valor;
            lblCliente.Text = nombre == null ? String.Empty : nombre;
            actualizarSaldo(valor ? null : "0.00");
            lstRetiros.Items.Clear();
            lstDep.Items.Clear();
            txtMontoInicial.Text = String.Empty;
            txtNombreCliente.Text = String.Empty;
        }

        private void actualizarSaldo(string monto)
        {
            monto = monto != null ? monto : cuentaManagement.getSaldo().ToString("F2");
            lblSaldo.Text = monto;
        }

        private void actualizarMovimientos()
        {
            mostrarDetallesCuenta(cuentaManagement.getNombre(), true);
            foreach (double item in cuentaManagement.getRetiros())
            {
                lstRetiros.Items.Add(item.ToString("F2"));
            }
            foreach (double item in cuentaManagement.getDepositos())
            {
                lstDep.Items.Add(item.ToString("F2"));
            }
        }

        // Deshabilitar el check box opuesto si fue marcado
        private void chkDep_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                chkRetiro.Checked = false;
            }
        }

        private void chkRetiro_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                chkDep.Checked = false;
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            int operacion = chkDep.Checked ? 1 : (chkRetiro.Checked ? 0 : int.MinValue);
            String input = null;
            double monto = 0;
            switch (operacion)
            {
                case 1:
                    input = Interaction.InputBox("¿Cuánto desea depositar?", "Depósitos");
                    if (double.TryParse(input, out monto) && monto > 0)
                    {
                        cuentaManagement.deposito(monto);
                    } 
                    else
                    {
                        MessageBox.Show("El monto a depositar debe ser mayor a 0.00", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 0:
                    input = Interaction.InputBox("¿Cuánto desea retirar de su cuenta?", "Retiros a cuenta de ahorro");
                    if (double.TryParse(input,out monto))
                    {
                        if (cuentaManagement.retiro(monto)) 
                        {
                            MessageBox.Show($"Ha retirado ${monto} de su cuenta. Nuevo Saldo: ${cuentaManagement.getSaldo()}");
                        } 
                        else
                        {
                            MessageBox.Show("Fondos insuficientes");
                            return;
                        }
                    }
                    break;
                default:
                    MessageBox.Show("No se ha podido determinar el tipo de transacción a realizar. Debe escoger entre depósito o retiro");
                    return;
            }
            actualizarMovimientos();
        }
    }
}

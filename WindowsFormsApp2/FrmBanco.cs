using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                txtMontoInicial.Text = String.Empty;
                txtNombreCliente.Text = String.Empty;
                mostrarCuenta(cuentaManagement.getNombre());
                actualizarSaldo();
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
                    new ToolTip().Show("Crear cuenta ha sido deshabilitado hasta cerrar la cuenta activa", this, 50, 220, 3000);
                    button.BackColor = SystemColors.ControlDarkDark;
                }
                else
                {
                    button.BackColor = SystemColors.Control;
                    new ToolTip().Show("Puede crear una cuenta si desea", this, 100, 220, 3000);
                }
            }
        }

        private void mostrarCuenta(string nombre)
        {
            grpTipoTransac.Visible = true;
            grpDetalles.Visible = true;
            grpClienteActual.Visible = true;
            btnCerrar.Visible = true;
            lblCliente.Text = nombre;
        }

        private void actualizarSaldo()
        {
            lblSaldo.Text = cuentaManagement.getSaldo().ToString();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}

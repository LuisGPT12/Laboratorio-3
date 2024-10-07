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
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMontoInicial.Text, out double monto))
            {
                String nombre = txtNombreCliente.Text;
            }
            // TODO lógica de crear cliente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO lógica de crear transacción
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            grpTipoTransac.Visible = false;
            grpDetalles.Visible = false;
            grpClienteActual.Visible = false;
        }
    }
}

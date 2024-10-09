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
    public partial class FrmImportes : Form
    {
        private List<double> importes = new List<double>();

        public FrmImportes()
        {
            InitializeComponent();
        }

        private void BtmFiltrar_Click(object sender, EventArgs e)
        {
            MetodosG.flitrar(importes, DgvImports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double datoImpo;
            if (double.TryParse(textBox1.Text, out datoImpo))
            {
                // Agregar el importe a la lista
                importes.Add(datoImpo);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("No puede insertar letras ni dejar casillas en blanco.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
    }
}
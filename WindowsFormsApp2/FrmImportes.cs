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
            // Verificar que hay al menos 5 importes antes de filtrar
            if (importes.Count >= 5)
            {
                // Filtrar importes entre 50 y 287, y ordenarlos
                var importesFiltrados = importes.Where(i => i >= 50 && i <= 287).OrderBy(i => i).ToList();

                // Asignar la lista filtrada al DataGridView
                DgvImports.DataSource = importesFiltrados
                    .Select(i => new { Importe = i })
                    .ToList();
            }
            else
            {
                MessageBox.Show("Disculpe, pero aún no se han insertado suficientes datos. El mínimo es 5.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
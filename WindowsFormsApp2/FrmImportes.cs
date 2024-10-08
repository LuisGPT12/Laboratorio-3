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
        private FiltrarImportes fli = new FiltrarImportes();
        public FrmImportes()
        {
            InitializeComponent();
        }
        private void BtmFiltrar_Click(object sender, EventArgs e)
        {          
            if (fli.validarMinimo())
            {
                // Obtener los importes filtrados
                var importesFiltrados = fli.filtrarImportes();

                // Asignar la lista filtrada al DataGridView
                DgvImports.DataSource = importesFiltrados
                    .Select(i => new { Importe = i }) // Crear objetos anónimos para que el DataGridView los muestre
                    .ToList();
            }
            else
            {
                MessageBox.Show("Disculpe, pero aún no se han insertado suficientes datos. El mínimo es 5.",
                    "¡¡¡¡¡¡¡¡¡¡ERRORRRRRRRRR!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double datoImpo;        
            if (double.TryParse(textBox1.Text, out datoImpo))
            {               
                fli.asignar(datoImpo);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("No puede insertar Letras, Ni dejar Casillas en blanco"
                    , "¡¡¡¡¡¡¡¡¡¡ERRORRRRRRRRR!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
    }
}

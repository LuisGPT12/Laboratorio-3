using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class frmNumCoincid : Form
    {
        public frmNumCoincid()
        {
            InitializeComponent();
        }

        private void frmNumCoincid_Load(object sender, EventArgs e)
        {
            dgvNumeros.ColumnCount = 10;
            dgvNumeros.AllowUserToAddRows = false;
            dgvNumeros.RowCount = 1;
        }

        private void dgvNumeros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // toma la ultima posicion para saber si se lleno
            // si la posicion ultima esta llena osea no es null, agrega otra columa para mas datos n
            if (dgvNumeros.Rows[0].Cells[dgvNumeros.ColumnCount - 1].Value != null) { 
                dgvNumeros.ColumnCount++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice;
            List<int> resultado = new List<int>();
            NumerosCoincidencia obj = new NumerosCoincidencia();

            if (txtBoxNum != null && int.TryParse(txtBoxNum.Text, out int numero))
            {
                obj.asignar(dgvNumeros, numero);
                resultado=obj.eliminarCoincidencias();

                indice=resultado.Count;
                dgvNumeros.Columns.Clear();
                dgvNumeros.Rows.Clear();
                dgvNumeros.RowCount = 1;
                dgvNumeros.ColumnCount = indice + 5;
                for (int i = 0; i < indice; i++)
                {
                    dgvNumeros.Rows[0].Cells[i].Value = resultado[i].ToString();
                }
                txtBoxNum.Text = String.Empty;
            }
            else {
                MessageBox.Show("ERROR, Ingrese un numero entero, No letra");            
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvNumeros.Columns.Clear();
            dgvNumeros.Rows.Clear();
            frmNumCoincid_Load(sender,e);
        }
    }
}

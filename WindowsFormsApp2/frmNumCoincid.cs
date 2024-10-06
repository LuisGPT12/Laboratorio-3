using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //toma la ultima posicion para saber si se lleno
            int ultima = dgvNumeros.ColumnCount - 1;
            //si la posicion ultima esta llena osea no es null, agrega otra columa para mas datos n
            if (dgvNumeros.Rows[0].Cells[ultima].Value != null) { 
                dgvNumeros.ColumnCount++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (txtBoxNum != null && int.TryParse(txtBoxNum.Text, out numero))
            {
                numerosCoincidencia obj = new numerosCoincidencia();
                obj.eliminarC(ref dgvNumeros, numero);
            }
            else {
                MessageBox.Show("ERROR, Ingrese un numero entero, No letra");            
            }
        }
    }
}

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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        Boolean oculto = false;

        private void enuciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumCoincid obj = new frmNumCoincid();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            if (!(oculto))
            {
                oculto = true;
                pictureBox1.Hide();
                label1.Hide();
                label2.Hide();
                panel1.Hide();
            }
            obj.Show();
        }

        private void eunciado3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportes obj = new FrmImportes();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            if (!(oculto))
            {
                oculto = true;
                pictureBox1.Hide();
                label1.Hide();
                label2.Hide();
                panel1.Hide();
            }           
            obj.Show();
        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanco obj = new FrmBanco();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            if (!(oculto))
            {
                oculto = true;
                pictureBox1.Hide();
                label1.Hide();
                label2.Hide();
                panel1.Hide();
            }
            obj.Show();
        }
    }
}

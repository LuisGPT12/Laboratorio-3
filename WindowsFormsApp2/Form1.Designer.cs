namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enunciado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enuciado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eunciado3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enunciado1ToolStripMenuItem,
            this.enuciado2ToolStripMenuItem,
            this.eunciado3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enunciado1ToolStripMenuItem
            // 
            this.enunciado1ToolStripMenuItem.Name = "enunciado1ToolStripMenuItem";
            this.enunciado1ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.enunciado1ToolStripMenuItem.Text = "Enunciado1";
            // 
            // enuciado2ToolStripMenuItem
            // 
            this.enuciado2ToolStripMenuItem.Name = "enuciado2ToolStripMenuItem";
            this.enuciado2ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.enuciado2ToolStripMenuItem.Text = "Enuciado2";
            this.enuciado2ToolStripMenuItem.Click += new System.EventHandler(this.enuciado2ToolStripMenuItem_Click);
            // 
            // eunciado3ToolStripMenuItem
            // 
            this.eunciado3ToolStripMenuItem.Name = "eunciado3ToolStripMenuItem";
            this.eunciado3ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.eunciado3ToolStripMenuItem.Text = "Eunciado3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enunciado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enuciado2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eunciado3ToolStripMenuItem;
    }
}


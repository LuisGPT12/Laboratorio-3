namespace WindowsFormsApp2
{
    partial class frmNumCoincid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumCoincid));
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.lbemote = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.AllowUserToAddRows = false;
            this.dgvNumeros.AllowUserToDeleteRows = false;
            this.dgvNumeros.AllowUserToResizeColumns = false;
            this.dgvNumeros.AllowUserToResizeRows = false;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.ColumnHeadersVisible = false;
            this.dgvNumeros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvNumeros.Location = new System.Drawing.Point(55, 41);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.RowHeadersVisible = false;
            this.dgvNumeros.Size = new System.Drawing.Size(711, 49);
            this.dgvNumeros.TabIndex = 0;
            this.dgvNumeros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNumeros_CellEndEdit);
            // 
            // lbemote
            // 
            this.lbemote.AutoSize = true;
            this.lbemote.BackColor = System.Drawing.Color.Transparent;
            this.lbemote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbemote.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemote.ForeColor = System.Drawing.Color.Black;
            this.lbemote.Location = new System.Drawing.Point(187, 118);
            this.lbemote.Name = "lbemote";
            this.lbemote.Size = new System.Drawing.Size(447, 30);
            this.lbemote.TabIndex = 1;
            this.lbemote.Text = "Ingrese el Numero a Eliminar";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNum.Location = new System.Drawing.Point(343, 213);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(138, 35);
            this.txtBoxNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "(se eleminaran todas las coincidencias de la tabla)";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(628, 273);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(138, 36);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxNum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbemote);
            this.panel1.Controls.Add(this.dgvNumeros);
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 328);
            this.panel1.TabIndex = 6;
            // 
            // frmNumCoincid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmNumCoincid";
            this.Text = "frmNumCoincid";
            this.Load += new System.EventHandler(this.frmNumCoincid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.Label lbemote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel panel1;
    }
}
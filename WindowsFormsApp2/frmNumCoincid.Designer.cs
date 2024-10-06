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
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.lbemote = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Location = new System.Drawing.Point(84, 136);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.Size = new System.Drawing.Size(579, 98);
            this.dgvNumeros.TabIndex = 0;
            this.dgvNumeros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNumeros_CellEndEdit);
            // 
            // lbemote
            // 
            this.lbemote.AutoSize = true;
            this.lbemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemote.Location = new System.Drawing.Point(80, 278);
            this.lbemote.Name = "lbemote";
            this.lbemote.Size = new System.Drawing.Size(585, 24);
            this.lbemote.TabIndex = 1;
            this.lbemote.Text = "Ingrese el Numero a Eliminar(se eleminaran todas las coincidencias)";
          
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNum.Location = new System.Drawing.Point(336, 341);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(100, 29);
            this.txtBoxNum.TabIndex = 3;
            // 
            // frmNumCoincid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbemote);
            this.Controls.Add(this.dgvNumeros);
            this.Name = "frmNumCoincid";
            this.Text = "frmNumCoincid";
            this.Load += new System.EventHandler(this.frmNumCoincid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.Label lbemote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxNum;
    }
}
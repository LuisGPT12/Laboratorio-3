namespace WindowsFormsApp2
{
    partial class FrmBanco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpCrear = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.grpTipoTransac = new System.Windows.Forms.GroupBox();
            this.chkDep = new System.Windows.Forms.CheckBox();
            this.chkRetiro = new System.Windows.Forms.CheckBox();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lstRetiros = new System.Windows.Forms.ListBox();
            this.lstDep = new System.Windows.Forms.ListBox();
            this.lblRetiros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grpClienteActual = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpCrear.SuspendLayout();
            this.grpTipoTransac.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            this.grpClienteActual.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpClienteActual);
            this.panel1.Controls.Add(this.grpDetalles);
            this.panel1.Controls.Add(this.grpTipoTransac);
            this.panel1.Controls.Add(this.grpCrear);
            this.panel1.Location = new System.Drawing.Point(70, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 425);
            this.panel1.TabIndex = 0;
            // 
            // grpCrear
            // 
            this.grpCrear.Controls.Add(this.btnCrearCuenta);
            this.grpCrear.Controls.Add(this.txtMontoInicial);
            this.grpCrear.Controls.Add(this.label1);
            this.grpCrear.Controls.Add(this.txtNombreCliente);
            this.grpCrear.Controls.Add(this.lblClient);
            this.grpCrear.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic);
            this.grpCrear.ForeColor = System.Drawing.SystemColors.Control;
            this.grpCrear.Location = new System.Drawing.Point(58, 35);
            this.grpCrear.Name = "grpCrear";
            this.grpCrear.Size = new System.Drawing.Size(341, 253);
            this.grpCrear.TabIndex = 0;
            this.grpCrear.TabStop = false;
            this.grpCrear.Text = "Crear Cuenta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(448, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de cuenta de ahorro";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblClient.Location = new System.Drawing.Point(33, 43);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(122, 20);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Nombre Cliente: ";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(161, 36);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(159, 27);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoInicial.Location = new System.Drawing.Point(161, 96);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(159, 27);
            this.txtMontoInicial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto inicial:";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCrearCuenta.Location = new System.Drawing.Point(92, 175);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(154, 45);
            this.btnCrearCuenta.TabIndex = 4;
            this.btnCrearCuenta.Text = "Abrir Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // grpTipoTransac
            // 
            this.grpTipoTransac.Controls.Add(this.button1);
            this.grpTipoTransac.Controls.Add(this.chkRetiro);
            this.grpTipoTransac.Controls.Add(this.chkDep);
            this.grpTipoTransac.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic);
            this.grpTipoTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.grpTipoTransac.Location = new System.Drawing.Point(452, 35);
            this.grpTipoTransac.Name = "grpTipoTransac";
            this.grpTipoTransac.Size = new System.Drawing.Size(572, 61);
            this.grpTipoTransac.TabIndex = 1;
            this.grpTipoTransac.TabStop = false;
            this.grpTipoTransac.Text = "Tipo de Transacción";
            // 
            // chkDep
            // 
            this.chkDep.AutoSize = true;
            this.chkDep.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDep.Location = new System.Drawing.Point(73, 26);
            this.chkDep.Name = "chkDep";
            this.chkDep.Size = new System.Drawing.Size(95, 24);
            this.chkDep.TabIndex = 0;
            this.chkDep.Text = "Depósito";
            this.chkDep.UseVisualStyleBackColor = true;
            // 
            // chkRetiro
            // 
            this.chkRetiro.AutoSize = true;
            this.chkRetiro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRetiro.Location = new System.Drawing.Point(250, 26);
            this.chkRetiro.Name = "chkRetiro";
            this.chkRetiro.Size = new System.Drawing.Size(73, 24);
            this.chkRetiro.TabIndex = 1;
            this.chkRetiro.Text = "Retiro";
            this.chkRetiro.UseVisualStyleBackColor = true;
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.lblSaldo);
            this.grpDetalles.Controls.Add(this.label3);
            this.grpDetalles.Controls.Add(this.label2);
            this.grpDetalles.Controls.Add(this.lblRetiros);
            this.grpDetalles.Controls.Add(this.lstDep);
            this.grpDetalles.Controls.Add(this.lstRetiros);
            this.grpDetalles.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic);
            this.grpDetalles.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDetalles.Location = new System.Drawing.Point(452, 115);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(572, 285);
            this.grpDetalles.TabIndex = 2;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles de su cuenta";
            // 
            // lstRetiros
            // 
            this.lstRetiros.FormattingEnabled = true;
            this.lstRetiros.ItemHeight = 18;
            this.lstRetiros.Location = new System.Drawing.Point(26, 59);
            this.lstRetiros.Name = "lstRetiros";
            this.lstRetiros.Size = new System.Drawing.Size(212, 202);
            this.lstRetiros.TabIndex = 0;
            // 
            // lstDep
            // 
            this.lstDep.FormattingEnabled = true;
            this.lstDep.ItemHeight = 18;
            this.lstDep.Location = new System.Drawing.Point(258, 59);
            this.lstDep.Name = "lstDep";
            this.lstDep.Size = new System.Drawing.Size(212, 202);
            this.lstDep.TabIndex = 1;
            // 
            // lblRetiros
            // 
            this.lblRetiros.AutoSize = true;
            this.lblRetiros.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiros.Location = new System.Drawing.Point(102, 29);
            this.lblRetiros.Name = "lblRetiros";
            this.lblRetiros.Size = new System.Drawing.Size(56, 19);
            this.lblRetiros.TabIndex = 2;
            this.lblRetiros.Text = "Retiros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depósitos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(515, 59);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(36, 19);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "0.00";
            // 
            // grpClienteActual
            // 
            this.grpClienteActual.Controls.Add(this.lblCliente);
            this.grpClienteActual.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic);
            this.grpClienteActual.ForeColor = System.Drawing.SystemColors.Control;
            this.grpClienteActual.Location = new System.Drawing.Point(58, 311);
            this.grpClienteActual.Name = "grpClienteActual";
            this.grpClienteActual.Size = new System.Drawing.Size(341, 89);
            this.grpClienteActual.TabIndex = 2;
            this.grpClienteActual.TabStop = false;
            this.grpClienteActual.Text = "Cliente Actual";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(33, 40);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 21);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(411, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBanco";
            this.Text = "Sistema bancario";
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.panel1.ResumeLayout(false);
            this.grpCrear.ResumeLayout(false);
            this.grpCrear.PerformLayout();
            this.grpTipoTransac.ResumeLayout(false);
            this.grpTipoTransac.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.grpClienteActual.ResumeLayout(false);
            this.grpClienteActual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpCrear;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTipoTransac;
        private System.Windows.Forms.CheckBox chkRetiro;
        private System.Windows.Forms.CheckBox chkDep;
        private System.Windows.Forms.GroupBox grpClienteActual;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRetiros;
        private System.Windows.Forms.ListBox lstDep;
        private System.Windows.Forms.ListBox lstRetiros;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button1;
    }
}
namespace LinkCajaV2.Configuraciones
{
    partial class Company
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCP = new System.Windows.Forms.Label();
            this.NUDCP = new System.Windows.Forms.NumericUpDown();
            this.RFC = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.lblNombreFacturacion = new System.Windows.Forms.Label();
            this.lblNombreF = new System.Windows.Forms.Label();
            this.CBRegimen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 30);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(37, 153);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 20);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "*Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(165, 150);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(331, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Location = new System.Drawing.Point(37, 354);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(97, 20);
            this.lblEncargado.TabIndex = 10;
            this.lblEncargado.Text = "*Encargado:";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(165, 348);
            this.txtEncargado.MaxLength = 50;
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(331, 26);
            this.txtEncargado.TabIndex = 11;
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Location = new System.Drawing.Point(41, 405);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(81, 20);
            this.lblTelefono1.TabIndex = 12;
            this.lblTelefono1.Text = "*Teléfono:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(165, 402);
            this.txtTelefono1.MaxLength = 50;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(255, 26);
            this.txtTelefono1.TabIndex = 13;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(37, 453);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(84, 20);
            this.lblTelefono2.TabIndex = 14;
            this.lblTelefono2.Text = "Telefono2:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(165, 447);
            this.txtTelefono2.MaxLength = 50;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(255, 26);
            this.txtTelefono2.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(41, 505);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(67, 20);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "*Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(165, 499);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(255, 26);
            this.txtCorreo.TabIndex = 17;
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(582, 177);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(88, 42);
            this.btnLogo.TabIndex = 18;
            this.btnLogo.Text = "Logo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.Location = new System.Drawing.Point(538, 30);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(185, 130);
            this.PBLogo.TabIndex = 14;
            this.PBLogo.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 545);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 37);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(41, 196);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(44, 20);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "*C.P:";
            // 
            // NUDCP
            // 
            this.NUDCP.Location = new System.Drawing.Point(165, 196);
            this.NUDCP.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NUDCP.Name = "NUDCP";
            this.NUDCP.Size = new System.Drawing.Size(120, 26);
            this.NUDCP.TabIndex = 5;
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Location = new System.Drawing.Point(41, 245);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(52, 20);
            this.RFC.TabIndex = 6;
            this.RFC.Text = "*RFC:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(165, 239);
            this.txtRFC.MaxLength = 50;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(236, 26);
            this.txtRFC.TabIndex = 7;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(42, 292);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(117, 20);
            this.lblRegimen.TabIndex = 8;
            this.lblRegimen.Text = "Regimen fiscal:";
            // 
            // lblNombreFacturacion
            // 
            this.lblNombreFacturacion.AutoSize = true;
            this.lblNombreFacturacion.Location = new System.Drawing.Point(42, 73);
            this.lblNombreFacturacion.Name = "lblNombreFacturacion";
            this.lblNombreFacturacion.Size = new System.Drawing.Size(188, 20);
            this.lblNombreFacturacion.TabIndex = 20;
            this.lblNombreFacturacion.Text = "Nombre para facturación:";
            // 
            // lblNombreF
            // 
            this.lblNombreF.AutoSize = true;
            this.lblNombreF.Location = new System.Drawing.Point(42, 111);
            this.lblNombreF.Name = "lblNombreF";
            this.lblNombreF.Size = new System.Drawing.Size(18, 20);
            this.lblNombreF.TabIndex = 21;
            this.lblNombreF.Text = "_";
            // 
            // CBRegimen
            // 
            this.CBRegimen.FormattingEnabled = true;
            this.CBRegimen.Location = new System.Drawing.Point(165, 292);
            this.CBRegimen.Name = "CBRegimen";
            this.CBRegimen.Size = new System.Drawing.Size(296, 28);
            this.CBRegimen.TabIndex = 9;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 594);
            this.Controls.Add(this.CBRegimen);
            this.Controls.Add(this.lblNombreF);
            this.Controls.Add(this.lblNombreFacturacion);
            this.Controls.Add(this.lblRegimen);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.NUDCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.lblTelefono1);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.lblEncargado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.NumericUpDown NUDCP;
        private System.Windows.Forms.Label RFC;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.Label lblNombreFacturacion;
        private System.Windows.Forms.Label lblNombreF;
        private System.Windows.Forms.ComboBox CBRegimen;
    }
}
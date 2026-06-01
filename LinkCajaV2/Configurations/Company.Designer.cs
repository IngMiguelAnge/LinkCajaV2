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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
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
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombre.Location = new System.Drawing.Point(36, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(41, 134);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 37);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDireccion.Location = new System.Drawing.Point(36, 290);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 25);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "*Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(41, 323);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 37);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEncargado.Location = new System.Drawing.Point(447, 192);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(115, 25);
            this.lblEncargado.TabIndex = 10;
            this.lblEncargado.Text = "*Encargado:";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncargado.Location = new System.Drawing.Point(452, 228);
            this.txtEncargado.MaxLength = 50;
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(250, 37);
            this.txtEncargado.TabIndex = 11;
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTelefono1.Location = new System.Drawing.Point(447, 290);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(99, 25);
            this.lblTelefono1.TabIndex = 12;
            this.lblTelefono1.Text = "*Teléfono:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono1.Location = new System.Drawing.Point(452, 323);
            this.txtTelefono1.MaxLength = 50;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(250, 37);
            this.txtTelefono1.TabIndex = 13;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTelefono2.Location = new System.Drawing.Point(447, 383);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(101, 25);
            this.lblTelefono2.TabIndex = 14;
            this.lblTelefono2.Text = "Telefono2:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono2.Location = new System.Drawing.Point(452, 420);
            this.txtTelefono2.MaxLength = 50;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(250, 37);
            this.txtTelefono2.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCorreo.Location = new System.Drawing.Point(447, 489);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(82, 25);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "*Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(452, 517);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 37);
            this.txtCorreo.TabIndex = 17;
            // 
            // btnLogo
            // 
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogo.Location = new System.Drawing.Point(774, 312);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(256, 49);
            this.btnLogo.TabIndex = 18;
            this.btnLogo.Text = "Cargar Logotipo";
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBLogo.Location = new System.Drawing.Point(804, 91);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(200, 200);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 14;
            this.PBLogo.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(830, 578);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 48);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCP.Location = new System.Drawing.Point(36, 383);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(52, 25);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "*C.P:";
            // 
            // NUDCP
            // 
            this.NUDCP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCP.Location = new System.Drawing.Point(46, 421);
            this.NUDCP.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NUDCP.Name = "NUDCP";
            this.NUDCP.Size = new System.Drawing.Size(250, 37);
            this.NUDCP.TabIndex = 5;
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.RFC.Location = new System.Drawing.Point(41, 489);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(57, 25);
            this.RFC.TabIndex = 6;
            this.RFC.Text = "*RFC:";
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(46, 517);
            this.txtRFC.MaxLength = 50;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(250, 37);
            this.txtRFC.TabIndex = 7;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRegimen.Location = new System.Drawing.Point(447, 91);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(141, 25);
            this.lblRegimen.TabIndex = 8;
            this.lblRegimen.Text = "Regimen fiscal:";
            // 
            // lblNombreFacturacion
            // 
            this.lblNombreFacturacion.AutoSize = true;
            this.lblNombreFacturacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombreFacturacion.Location = new System.Drawing.Point(37, 192);
            this.lblNombreFacturacion.Name = "lblNombreFacturacion";
            this.lblNombreFacturacion.Size = new System.Drawing.Size(231, 25);
            this.lblNombreFacturacion.TabIndex = 20;
            this.lblNombreFacturacion.Text = "Nombre para facturación:";
            // 
            // lblNombreF
            // 
            this.lblNombreF.AutoSize = true;
            this.lblNombreF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombreF.Location = new System.Drawing.Point(41, 228);
            this.lblNombreF.Name = "lblNombreF";
            this.lblNombreF.Size = new System.Drawing.Size(19, 25);
            this.lblNombreF.TabIndex = 21;
            this.lblNombreF.Text = "_";
            // 
            // CBRegimen
            // 
            this.CBRegimen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRegimen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRegimen.FormattingEnabled = true;
            this.CBRegimen.Location = new System.Drawing.Point(452, 134);
            this.CBRegimen.Name = "CBRegimen";
            this.CBRegimen.Size = new System.Drawing.Size(250, 38);
            this.CBRegimen.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 48);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Mi Empresa";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 664);
            this.Controls.Add(this.lblTitulo);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Company";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblTitulo;
    }
}
namespace LinkCajaV2.Catalogs
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnPanelMenu = new System.Windows.Forms.Button();
            this.PanelgroupBox = new System.Windows.Forms.GroupBox();
            this.BtnPanelSalir = new System.Windows.Forms.Button();
            this.btnPanelCorte = new System.Windows.Forms.Button();
            this.btnPanelEmpresa = new System.Windows.Forms.Button();
            this.btnPanelArticulos = new System.Windows.Forms.Button();
            this.btnPanelVentas = new System.Windows.Forms.Button();
            this.lblPanelTituloApp = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            this.PanelgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.panelLateral.Controls.Add(this.btnPanelMenu);
            this.panelLateral.Controls.Add(this.PanelgroupBox);
            this.panelLateral.Controls.Add(this.btnPanelCorte);
            this.panelLateral.Controls.Add(this.btnPanelEmpresa);
            this.panelLateral.Controls.Add(this.btnPanelArticulos);
            this.panelLateral.Controls.Add(this.btnPanelVentas);
            this.panelLateral.Controls.Add(this.lblPanelTituloApp);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(264, 607);
            this.panelLateral.TabIndex = 0;
            // 
            // btnPanelMenu
            // 
            this.btnPanelMenu.FlatAppearance.BorderSize = 0;
            this.btnPanelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPanelMenu.ForeColor = System.Drawing.Color.White;
            this.btnPanelMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelMenu.Image")));
            this.btnPanelMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelMenu.Location = new System.Drawing.Point(9, 120);
            this.btnPanelMenu.Name = "btnPanelMenu";
            this.btnPanelMenu.Size = new System.Drawing.Size(249, 82);
            this.btnPanelMenu.TabIndex = 26;
            this.btnPanelMenu.Text = "Menu";
            // 
            // PanelgroupBox
            // 
            this.PanelgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelgroupBox.Controls.Add(this.BtnPanelSalir);
            this.PanelgroupBox.Location = new System.Drawing.Point(6, 522);
            this.PanelgroupBox.Name = "PanelgroupBox";
            this.PanelgroupBox.Size = new System.Drawing.Size(258, 73);
            this.PanelgroupBox.TabIndex = 25;
            this.PanelgroupBox.TabStop = false;
            // 
            // BtnPanelSalir
            // 
            this.BtnPanelSalir.FlatAppearance.BorderSize = 0;
            this.BtnPanelSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPanelSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPanelSalir.ForeColor = System.Drawing.Color.White;
            this.BtnPanelSalir.Location = new System.Drawing.Point(6, 15);
            this.BtnPanelSalir.Name = "BtnPanelSalir";
            this.BtnPanelSalir.Size = new System.Drawing.Size(238, 45);
            this.BtnPanelSalir.TabIndex = 5;
            this.BtnPanelSalir.Text = "🡸   Salir";
            this.BtnPanelSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPanelSalir.Click += new System.EventHandler(this.BtnPanelSalir_Click);
            // 
            // btnPanelCorte
            // 
            this.btnPanelCorte.FlatAppearance.BorderSize = 0;
            this.btnPanelCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelCorte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPanelCorte.ForeColor = System.Drawing.Color.White;
            this.btnPanelCorte.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelCorte.Image")));
            this.btnPanelCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelCorte.Location = new System.Drawing.Point(9, 430);
            this.btnPanelCorte.Name = "btnPanelCorte";
            this.btnPanelCorte.Size = new System.Drawing.Size(249, 45);
            this.btnPanelCorte.TabIndex = 7;
            this.btnPanelCorte.Text = " Corte de Caja";
            this.btnPanelCorte.Click += new System.EventHandler(this.btnPanelCorte_Click);
            // 
            // btnPanelEmpresa
            // 
            this.btnPanelEmpresa.FlatAppearance.BorderSize = 0;
            this.btnPanelEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPanelEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnPanelEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelEmpresa.Image")));
            this.btnPanelEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelEmpresa.Location = new System.Drawing.Point(12, 365);
            this.btnPanelEmpresa.Name = "btnPanelEmpresa";
            this.btnPanelEmpresa.Size = new System.Drawing.Size(249, 45);
            this.btnPanelEmpresa.TabIndex = 0;
            this.btnPanelEmpresa.Text = "Mi Empresa";
            this.btnPanelEmpresa.Click += new System.EventHandler(this.btnPanelEmpresa_Click);
            // 
            // btnPanelArticulos
            // 
            this.btnPanelArticulos.FlatAppearance.BorderSize = 0;
            this.btnPanelArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPanelArticulos.ForeColor = System.Drawing.Color.White;
            this.btnPanelArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelArticulos.Image")));
            this.btnPanelArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelArticulos.Location = new System.Drawing.Point(13, 296);
            this.btnPanelArticulos.Name = "btnPanelArticulos";
            this.btnPanelArticulos.Size = new System.Drawing.Size(248, 45);
            this.btnPanelArticulos.TabIndex = 1;
            this.btnPanelArticulos.Text = "Articulos";
            this.btnPanelArticulos.Click += new System.EventHandler(this.btnPanelArticulos_Click);
            // 
            // btnPanelVentas
            // 
            this.btnPanelVentas.FlatAppearance.BorderSize = 0;
            this.btnPanelVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPanelVentas.ForeColor = System.Drawing.Color.White;
            this.btnPanelVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelVentas.Image")));
            this.btnPanelVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelVentas.Location = new System.Drawing.Point(12, 208);
            this.btnPanelVentas.Name = "btnPanelVentas";
            this.btnPanelVentas.Size = new System.Drawing.Size(249, 82);
            this.btnPanelVentas.TabIndex = 2;
            this.btnPanelVentas.Text = " Ventas";
            this.btnPanelVentas.Click += new System.EventHandler(this.btnPanelVentas_Click);
            // 
            // lblPanelTituloApp
            // 
            this.lblPanelTituloApp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPanelTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblPanelTituloApp.Location = new System.Drawing.Point(22, 20);
            this.lblPanelTituloApp.Name = "lblPanelTituloApp";
            this.lblPanelTituloApp.Size = new System.Drawing.Size(220, 87);
            this.lblPanelTituloApp.TabIndex = 4;
            this.lblPanelTituloApp.Text = "PUNTO DE VENTA";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(1366, 105);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 37);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblUsuario.Location = new System.Drawing.Point(296, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 25);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(300, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 37);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombre.Location = new System.Drawing.Point(638, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(642, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 37);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTipo.Location = new System.Drawing.Point(924, 79);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(55, 25);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo:";
            // 
            // CBTipo
            // 
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(928, 105);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(250, 38);
            this.CBTipo.TabIndex = 6;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(1209, 107);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(120, 37);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.groupBox1.Location = new System.Drawing.Point(300, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1101, 363);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 35);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(1095, 325);
            this.dgvUsuarios.TabIndex = 9;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.progressBar1.Location = new System.Drawing.Point(300, 164);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(520, 6);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(292, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 48);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Lista de Usuarios";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 607);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.CBTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panelLateral);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            this.panelLateral.ResumeLayout(false);
            this.PanelgroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblPanelTituloApp;
        private System.Windows.Forms.Button btnPanelVentas;
        private System.Windows.Forms.Button btnPanelArticulos;
        private System.Windows.Forms.Button btnPanelEmpresa;
        private System.Windows.Forms.Button btnPanelCorte;
        private System.Windows.Forms.Button BtnPanelSalir;
        private System.Windows.Forms.Button btnPanelMenu;
        private System.Windows.Forms.GroupBox PanelgroupBox;

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTitulo;
    }
}
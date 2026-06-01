using System.Windows.Forms;

namespace LinkCajaV2.Sales
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPanelSalir = new System.Windows.Forms.Button();
            this.btnPanelMenu = new System.Windows.Forms.Button();
            this.btnPanelCorte = new System.Windows.Forms.Button();
            this.btnPanelEmpresa = new System.Windows.Forms.Button();
            this.btnPanelArticulos = new System.Windows.Forms.Button();
            this.btnPanelVentas = new System.Windows.Forms.Button();
            this.lblPanelTituloApp = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVerTickets = new System.Windows.Forms.Button();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCopias = new System.Windows.Forms.Label();
            this.PBProducto = new System.Windows.Forms.PictureBox();
            this.CBImprimir = new System.Windows.Forms.CheckBox();
            this.NUDCopias = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCopias)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.BtnPanelSalir);
            this.panelLateral.Controls.Add(this.btnPanelMenu);
            this.panelLateral.Controls.Add(this.btnPanelCorte);
            this.panelLateral.Controls.Add(this.btnPanelEmpresa);
            this.panelLateral.Controls.Add(this.btnPanelArticulos);
            this.panelLateral.Controls.Add(this.btnPanelVentas);
            this.panelLateral.Controls.Add(this.lblPanelTituloApp);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(264, 1050);
            this.panelLateral.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 87);
            this.label1.TabIndex = 28;
            this.label1.Text = "PUNTO DE VENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPanelSalir
            // 
            this.BtnPanelSalir.FlatAppearance.BorderSize = 0;
            this.BtnPanelSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPanelSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPanelSalir.ForeColor = System.Drawing.Color.White;
            this.BtnPanelSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnPanelSalir.Image")));
            this.BtnPanelSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPanelSalir.Location = new System.Drawing.Point(12, 500);
            this.BtnPanelSalir.Name = "BtnPanelSalir";
            this.BtnPanelSalir.Size = new System.Drawing.Size(249, 45);
            this.BtnPanelSalir.TabIndex = 28;
            this.BtnPanelSalir.Text = "Salir";
            this.BtnPanelSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPanelSalir.UseVisualStyleBackColor = true;
            this.BtnPanelSalir.Click += new System.EventHandler(this.BtnPanelSalir_Click);
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
            this.btnPanelMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanelMenu.Click += new System.EventHandler(this.btnPanelMenu_Click_1);
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
            this.btnPanelCorte.Text = "Resumen";
            this.btnPanelCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnPanelEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnPanelArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnPanelVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanelVentas.Click += new System.EventHandler(this.btnPanelVentas_Click);
            // 
            // lblPanelTituloApp
            // 
            this.lblPanelTituloApp.Location = new System.Drawing.Point(0, 0);
            this.lblPanelTituloApp.Name = "lblPanelTituloApp";
            this.lblPanelTituloApp.Size = new System.Drawing.Size(100, 23);
            this.lblPanelTituloApp.TabIndex = 27;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCodigo.Location = new System.Drawing.Point(496, 168);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 25);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(501, 203);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(535, 39);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1056, 203);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCantidad.Location = new System.Drawing.Point(283, 168);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(92, 25);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCantidad.Location = new System.Drawing.Point(288, 204);
            this.NUDCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(166, 39);
            this.NUDCantidad.TabIndex = 0;
            this.NUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvArticulos);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.groupBox1.Location = new System.Drawing.Point(288, 241);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1213, 616);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulos:";
            // 
            // dgvArticulos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 34);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.Size = new System.Drawing.Size(1207, 578);
            this.dgvArticulos.TabIndex = 6;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvArticulos_CellPainting);
            this.dgvArticulos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvArticulos_CellValidating);
            this.dgvArticulos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellValueChanged);
            this.dgvArticulos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvArticulos_EditingControlShowing);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(1206, 203);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 30);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVerTickets
            // 
            this.btnVerTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTickets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnVerTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTickets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTickets.Location = new System.Drawing.Point(1341, 203);
            this.btnVerTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerTickets.Name = "btnVerTickets";
            this.btnVerTickets.Size = new System.Drawing.Size(140, 30);
            this.btnVerTickets.TabIndex = 21;
            this.btnVerTickets.Text = "Ver Tickets";
            this.btnVerTickets.UseVisualStyleBackColor = true;
            this.btnVerTickets.Click += new System.EventHandler(this.btnVerTickets_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.Location = new System.Drawing.Point(292, 27);
            this.PBLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(141, 127);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 25;
            this.PBLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(1203, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(302, 88);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblUsuario.Location = new System.Drawing.Point(3, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(296, 56);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Bienvenido: Administrador";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblCopias);
            this.groupBox3.Controls.Add(this.PBProducto);
            this.groupBox3.Controls.Add(this.CBImprimir);
            this.groupBox3.Controls.Add(this.NUDCopias);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.btnPagar);
            this.groupBox3.Location = new System.Drawing.Point(288, 830);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1217, 235);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCopias.Location = new System.Drawing.Point(505, 118);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(68, 25);
            this.lblCopias.TabIndex = 21;
            this.lblCopias.Text = "Copias";
            // 
            // PBProducto
            // 
            this.PBProducto.Location = new System.Drawing.Point(41, 36);
            this.PBProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PBProducto.Name = "PBProducto";
            this.PBProducto.Size = new System.Drawing.Size(262, 180);
            this.PBProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBProducto.TabIndex = 16;
            this.PBProducto.TabStop = false;
            // 
            // CBImprimir
            // 
            this.CBImprimir.AutoSize = true;
            this.CBImprimir.Checked = true;
            this.CBImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.CBImprimir.Location = new System.Drawing.Point(398, 118);
            this.CBImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBImprimir.Name = "CBImprimir";
            this.CBImprimir.Size = new System.Drawing.Size(106, 29);
            this.CBImprimir.TabIndex = 20;
            this.CBImprimir.Text = "Imprimir";
            this.CBImprimir.UseVisualStyleBackColor = true;
            // 
            // NUDCopias
            // 
            this.NUDCopias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCopias.Location = new System.Drawing.Point(510, 157);
            this.NUDCopias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDCopias.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDCopias.Name = "NUDCopias";
            this.NUDCopias.Size = new System.Drawing.Size(146, 34);
            this.NUDCopias.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTotal.Location = new System.Drawing.Point(390, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(335, 112);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total: $";
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnPagar.Location = new System.Drawing.Point(906, 118);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(231, 69);
            this.btnPagar.TabIndex = 18;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblNombreEmpresa);
            this.groupBox4.Location = new System.Drawing.Point(439, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(752, 88);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(3, 27);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(746, 58);
            this.lblNombreEmpresa.TabIndex = 26;
            this.lblNombreEmpresa.Text = "Nombre Empresa";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.btnVerTickets);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.panelLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Venta_FormClosed);
            this.Load += new System.EventHandler(this.Venta_Load);
            this.Shown += new System.EventHandler(this.Venta_Shown);
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCopias)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox PBProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVerTickets;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NUDCopias;
        private System.Windows.Forms.CheckBox CBImprimir;
        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
namespace LinkCajaV2.Reports
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.BtnPanelSalir = new System.Windows.Forms.Button();
            this.btnPanelMenu = new System.Windows.Forms.Button();
            this.btnPanelCorte = new System.Windows.Forms.Button();
            this.btnPanelEmpresa = new System.Windows.Forms.Button();
            this.btnPanelArticulos = new System.Windows.Forms.Button();
            this.btnPanelVentas = new System.Windows.Forms.Button();
            this.lblPanelTituloApp = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.CBFecha = new System.Windows.Forms.CheckBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.NUDTicket = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GBTickets = new System.Windows.Forms.GroupBox();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.lblVenta = new System.Windows.Forms.Label();
            this.RBCreacion = new System.Windows.Forms.RadioButton();
            this.RBModificacion = new System.Windows.Forms.RadioButton();
            this.lblTotalDevolucion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.lblTotalEnvio = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTicket)).BeginInit();
            this.GBTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.panelLateral.Controls.Add(this.BtnPanelSalir);
            this.panelLateral.Controls.Add(this.btnPanelMenu);
            this.panelLateral.Controls.Add(this.btnPanelCorte);
            this.panelLateral.Controls.Add(this.btnPanelEmpresa);
            this.panelLateral.Controls.Add(this.btnPanelArticulos);
            this.panelLateral.Controls.Add(this.btnPanelVentas);
            this.panelLateral.Controls.Add(this.lblPanelTituloApp);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(235, 457);
            this.panelLateral.TabIndex = 0;
            // 
            // BtnPanelSalir
            // 
            this.BtnPanelSalir.FlatAppearance.BorderSize = 0;
            this.BtnPanelSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPanelSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPanelSalir.ForeColor = System.Drawing.Color.White;
            this.BtnPanelSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnPanelSalir.Image")));
            this.BtnPanelSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPanelSalir.Location = new System.Drawing.Point(4, 397);
            this.BtnPanelSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPanelSalir.Name = "BtnPanelSalir";
            this.BtnPanelSalir.Size = new System.Drawing.Size(226, 36);
            this.BtnPanelSalir.TabIndex = 5;
            this.BtnPanelSalir.Text = "Salir";
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
            this.btnPanelMenu.Location = new System.Drawing.Point(8, 96);
            this.btnPanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPanelMenu.Name = "btnPanelMenu";
            this.btnPanelMenu.Size = new System.Drawing.Size(221, 66);
            this.btnPanelMenu.TabIndex = 26;
            this.btnPanelMenu.Text = "Menu";
            this.btnPanelMenu.Click += new System.EventHandler(this.btnPanelMenu_Click);
            // 
            // btnPanelCorte
            // 
            this.btnPanelCorte.FlatAppearance.BorderSize = 0;
            this.btnPanelCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelCorte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPanelCorte.ForeColor = System.Drawing.Color.White;
            this.btnPanelCorte.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelCorte.Image")));
            this.btnPanelCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelCorte.Location = new System.Drawing.Point(8, 344);
            this.btnPanelCorte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPanelCorte.Name = "btnPanelCorte";
            this.btnPanelCorte.Size = new System.Drawing.Size(221, 36);
            this.btnPanelCorte.TabIndex = 7;
            this.btnPanelCorte.Text = "Resumen";
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
            this.btnPanelEmpresa.Location = new System.Drawing.Point(11, 292);
            this.btnPanelEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPanelEmpresa.Name = "btnPanelEmpresa";
            this.btnPanelEmpresa.Size = new System.Drawing.Size(221, 36);
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
            this.btnPanelArticulos.Location = new System.Drawing.Point(12, 237);
            this.btnPanelArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPanelArticulos.Name = "btnPanelArticulos";
            this.btnPanelArticulos.Size = new System.Drawing.Size(220, 36);
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
            this.btnPanelVentas.Location = new System.Drawing.Point(11, 166);
            this.btnPanelVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPanelVentas.Name = "btnPanelVentas";
            this.btnPanelVentas.Size = new System.Drawing.Size(221, 66);
            this.btnPanelVentas.TabIndex = 2;
            this.btnPanelVentas.Text = " Ventas";
            this.btnPanelVentas.Click += new System.EventHandler(this.btnPanelVentas_Click);
            // 
            // lblPanelTituloApp
            // 
            this.lblPanelTituloApp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPanelTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblPanelTituloApp.Location = new System.Drawing.Point(20, 16);
            this.lblPanelTituloApp.Name = "lblPanelTituloApp";
            this.lblPanelTituloApp.Size = new System.Drawing.Size(196, 70);
            this.lblPanelTituloApp.TabIndex = 4;
            this.lblPanelTituloApp.Text = "PUNTO DE VENTA";
            // 
            // dtDesde
            // 
            this.dtDesde.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Location = new System.Drawing.Point(267, 158);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(400, 32);
            this.dtDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDesde.Location = new System.Drawing.Point(268, 129);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHasta.Location = new System.Drawing.Point(708, 129);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(53, 20);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Location = new System.Drawing.Point(712, 158);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(371, 32);
            this.dtHasta.TabIndex = 6;
            // 
            // CBFecha
            // 
            this.CBFecha.AutoSize = true;
            this.CBFecha.Checked = true;
            this.CBFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.CBFecha.Location = new System.Drawing.Point(271, 85);
            this.CBFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBFecha.Name = "CBFecha";
            this.CBFecha.Size = new System.Drawing.Size(175, 27);
            this.CBFecha.TabIndex = 0;
            this.CBFecha.Text = "¿Buscar por fecha?";
            this.CBFecha.UseVisualStyleBackColor = true;
            this.CBFecha.CheckedChanged += new System.EventHandler(this.CBBuscar_CheckedChanged);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTicket.Location = new System.Drawing.Point(268, 209);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(77, 20);
            this.lblTicket.TabIndex = 7;
            this.lblTicket.Text = "N° Ticket:";
            // 
            // NUDTicket
            // 
            this.NUDTicket.Enabled = false;
            this.NUDTicket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDTicket.Location = new System.Drawing.Point(267, 231);
            this.NUDTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDTicket.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NUDTicket.Name = "NUDTicket";
            this.NUDTicket.Size = new System.Drawing.Size(242, 32);
            this.NUDTicket.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1124, 155);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GBTickets
            // 
            this.GBTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBTickets.Controls.Add(this.dgvTickets);
            this.GBTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBTickets.Location = new System.Drawing.Point(267, 278);
            this.GBTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBTickets.Name = "GBTickets";
            this.GBTickets.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBTickets.Size = new System.Drawing.Size(984, 155);
            this.GBTickets.TabIndex = 12;
            this.GBTickets.TabStop = false;
            this.GBTickets.Text = "Tickets:";
            // 
            // dgvTickets
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.EnableHeadersVisualStyles = false;
            this.dgvTickets.Location = new System.Drawing.Point(3, 29);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 62;
            this.dgvTickets.RowTemplate.Height = 28;
            this.dgvTickets.Size = new System.Drawing.Size(978, 124);
            this.dgvTickets.TabIndex = 13;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblVenta.Location = new System.Drawing.Point(716, 202);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(138, 20);
            this.lblVenta.TabIndex = 10;
            this.lblVenta.Text = "Venta total $: 0.00";
            // 
            // RBCreacion
            // 
            this.RBCreacion.AutoSize = true;
            this.RBCreacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCreacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.RBCreacion.Location = new System.Drawing.Point(500, 84);
            this.RBCreacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBCreacion.Name = "RBCreacion";
            this.RBCreacion.Size = new System.Drawing.Size(174, 27);
            this.RBCreacion.TabIndex = 1;
            this.RBCreacion.TabStop = true;
            this.RBCreacion.Text = "Desde que se creo";
            this.RBCreacion.UseVisualStyleBackColor = true;
            this.RBCreacion.CheckedChanged += new System.EventHandler(this.RBCreacion_CheckedChanged);
            // 
            // RBModificacion
            // 
            this.RBModificacion.AutoSize = true;
            this.RBModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBModificacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.RBModificacion.Location = new System.Drawing.Point(712, 84);
            this.RBModificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBModificacion.Name = "RBModificacion";
            this.RBModificacion.Size = new System.Drawing.Size(193, 27);
            this.RBModificacion.TabIndex = 2;
            this.RBModificacion.TabStop = true;
            this.RBModificacion.Text = "Ultima modificación";
            this.RBModificacion.UseVisualStyleBackColor = true;
            this.RBModificacion.CheckedChanged += new System.EventHandler(this.RBModificacion_CheckedChanged);
            // 
            // lblTotalDevolucion
            // 
            this.lblTotalDevolucion.AutoSize = true;
            this.lblTotalDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalDevolucion.Location = new System.Drawing.Point(716, 229);
            this.lblTotalDevolucion.Name = "lblTotalDevolucion";
            this.lblTotalDevolucion.Size = new System.Drawing.Size(176, 20);
            this.lblTotalDevolucion.TabIndex = 11;
            this.lblTotalDevolucion.Text = "Devolución total $: 0.00";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(260, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 41);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Lista de Tickets";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblVentaFinal.Location = new System.Drawing.Point(716, 257);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(136, 20);
            this.lblVentaFinal.TabIndex = 26;
            this.lblVentaFinal.Text = "Venta final $: 0.00";
            // 
            // lblTotalEnvio
            // 
            this.lblTotalEnvio.AutoSize = true;
            this.lblTotalEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalEnvio.Location = new System.Drawing.Point(962, 202);
            this.lblTotalEnvio.Name = "lblTotalEnvio";
            this.lblTotalEnvio.Size = new System.Drawing.Size(208, 20);
            this.lblTotalEnvio.TabIndex = 27;
            this.lblTotalEnvio.Text = "Venta total por Envio $: 0.00";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 457);
            this.Controls.Add(this.lblTotalEnvio);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotalDevolucion);
            this.Controls.Add(this.RBModificacion);
            this.Controls.Add(this.RBCreacion);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.GBTickets);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.NUDTicket);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.CBFecha);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.panelLateral);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tickets";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tickets_FormClosed);
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTicket)).EndInit();
            this.GBTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
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

        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.CheckBox CBFecha;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.NumericUpDown NUDTicket;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox GBTickets;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.RadioButton RBCreacion;
        private System.Windows.Forms.RadioButton RBModificacion;
        private System.Windows.Forms.Label lblTotalDevolucion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.Label lblTotalEnvio;
    }
}
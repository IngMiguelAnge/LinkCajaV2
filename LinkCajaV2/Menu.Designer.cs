namespace LinkCajaV2
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnCorte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.flowContenedorCentral = new System.Windows.Forms.FlowLayoutPanel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnVentaMostrador = new System.Windows.Forms.Button();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.panelCatalogos = new System.Windows.Forms.Panel();
            this.btnArticules = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblTituloCatalogos = new System.Windows.Forms.Label();
            this.panelConfiguraciones = new System.Windows.Forms.Panel();
            this.btnImpresiones = new System.Windows.Forms.Button();
            this.btnConfigCajas = new System.Windows.Forms.Button();
            this.btnMiEmpresa = new System.Windows.Forms.Button();
            this.lblTituloConfiguraciones = new System.Windows.Forms.Label();
            this.panelOperacionesCaja = new System.Windows.Forms.Panel();
            this.btnCorteCaja = new System.Windows.Forms.Button();
            this.lblTituloOperacionesCaja = new System.Windows.Forms.Label();
            this.btnLicencias = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowContenedorCentral.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCatalogos.SuspendLayout();
            this.panelConfiguraciones.SuspendLayout();
            this.panelOperacionesCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.panelLateral.Controls.Add(this.btnCorte);
            this.panelLateral.Controls.Add(this.groupBox2);
            this.panelLateral.Controls.Add(this.btnEmpresa);
            this.panelLateral.Controls.Add(this.btnArticulos);
            this.panelLateral.Controls.Add(this.btnVentas);
            this.panelLateral.Controls.Add(this.lblTituloApp);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(264, 736);
            this.panelLateral.TabIndex = 0;
            // 
            // btnCorte
            // 
            this.btnCorte.FlatAppearance.BorderSize = 0;
            this.btnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCorte.ForeColor = System.Drawing.Color.White;
            this.btnCorte.Image = ((System.Drawing.Image)(resources.GetObject("btnCorte.Image")));
            this.btnCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorte.Location = new System.Drawing.Point(13, 338);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(238, 45);
            this.btnCorte.TabIndex = 7;
            this.btnCorte.Text = " Corte de Caja";
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(6, 617);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(17, 30);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(238, 45);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "🡸   Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Image")));
            this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Location = new System.Drawing.Point(12, 273);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(238, 45);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Mi Empresa";
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnArticulos.ForeColor = System.Drawing.Color.White;
            this.btnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulos.Image")));
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(13, 204);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(238, 45);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(12, 116);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(238, 82);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = " Ventas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblTituloApp.Location = new System.Drawing.Point(22, 20);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(220, 87);
            this.lblTituloApp.TabIndex = 4;
            this.lblTituloApp.Text = "PUNTO DE VENTA";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.Controls.Add(this.groupBox1);
            this.panelSuperior.Controls.Add(this.lblMenuPrincipal);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(264, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1144, 85);
            this.panelSuperior.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.lblBienvenido);
            this.groupBox1.Location = new System.Drawing.Point(908, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.Gray;
            this.lblBienvenido.Location = new System.Drawing.Point(26, 17);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(205, 65);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al sistema";
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(22, 15);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(330, 57);
            this.lblMenuPrincipal.TabIndex = 1;
            this.lblMenuPrincipal.Text = "Menú";
            // 
            // flowContenedorCentral
            // 
            this.flowContenedorCentral.AutoScroll = true;
            this.flowContenedorCentral.BackColor = System.Drawing.Color.White;
            this.flowContenedorCentral.Controls.Add(this.panelVentas);
            this.flowContenedorCentral.Controls.Add(this.panelCatalogos);
            this.flowContenedorCentral.Controls.Add(this.panelConfiguraciones);
            this.flowContenedorCentral.Controls.Add(this.panelOperacionesCaja);
            this.flowContenedorCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContenedorCentral.Location = new System.Drawing.Point(264, 85);
            this.flowContenedorCentral.Name = "flowContenedorCentral";
            this.flowContenedorCentral.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.flowContenedorCentral.Size = new System.Drawing.Size(1144, 651);
            this.flowContenedorCentral.TabIndex = 0;
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.White;
            this.panelVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVentas.Controls.Add(this.btnTicket);
            this.panelVentas.Controls.Add(this.btnVentaMostrador);
            this.panelVentas.Controls.Add(this.lblTituloVentas);
            this.panelVentas.Location = new System.Drawing.Point(27, 25);
            this.panelVentas.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(528, 193);
            this.panelVentas.TabIndex = 0;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnTicket.Image")));
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(270, 56);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnTicket.Size = new System.Drawing.Size(231, 80);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Tickets";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnVentaMostrador
            // 
            this.btnVentaMostrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnVentaMostrador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnVentaMostrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaMostrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnVentaMostrador.Image = ((System.Drawing.Image)(resources.GetObject("btnVentaMostrador.Image")));
            this.btnVentaMostrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaMostrador.Location = new System.Drawing.Point(20, 56);
            this.btnVentaMostrador.Name = "btnVentaMostrador";
            this.btnVentaMostrador.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnVentaMostrador.Size = new System.Drawing.Size(231, 80);
            this.btnVentaMostrador.TabIndex = 1;
            this.btnVentaMostrador.Text = "Venta de Mostrador";
            this.btnVentaMostrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaMostrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaMostrador.UseVisualStyleBackColor = false;
            this.btnVentaMostrador.Click += new System.EventHandler(this.btnVentaMostrador_Click);
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTituloVentas.Location = new System.Drawing.Point(16, 12);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(235, 40);
            this.lblTituloVentas.TabIndex = 2;
            this.lblTituloVentas.Text = "🛒 Ventas";
            // 
            // panelCatalogos
            // 
            this.panelCatalogos.BackColor = System.Drawing.Color.White;
            this.panelCatalogos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCatalogos.Controls.Add(this.btnArticules);
            this.panelCatalogos.Controls.Add(this.btnCategorias);
            this.panelCatalogos.Controls.Add(this.btnProveedores);
            this.panelCatalogos.Controls.Add(this.btnUsuarios);
            this.panelCatalogos.Controls.Add(this.lblTituloCatalogos);
            this.panelCatalogos.Location = new System.Drawing.Point(577, 25);
            this.panelCatalogos.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelCatalogos.Name = "panelCatalogos";
            this.panelCatalogos.Size = new System.Drawing.Size(528, 315);
            this.panelCatalogos.TabIndex = 1;
            // 
            // btnArticules
            // 
            this.btnArticules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnArticules.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnArticules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(54)))));
            this.btnArticules.Image = ((System.Drawing.Image)(resources.GetObject("btnArticules.Image")));
            this.btnArticules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticules.Location = new System.Drawing.Point(270, 198);
            this.btnArticules.Name = "btnArticules";
            this.btnArticules.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnArticules.Size = new System.Drawing.Size(231, 80);
            this.btnArticules.TabIndex = 7;
            this.btnArticules.Text = "Articulos";
            this.btnArticules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArticules.UseVisualStyleBackColor = false;
            this.btnArticules.Click += new System.EventHandler(this.btnArticules_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(54)))));
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(21, 198);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnCategorias.Size = new System.Drawing.Size(231, 80);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(54)))));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(270, 56);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnProveedores.Size = new System.Drawing.Size(231, 80);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(54)))));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(20, 56);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(231, 80);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblTituloCatalogos
            // 
            this.lblTituloCatalogos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloCatalogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTituloCatalogos.Location = new System.Drawing.Point(16, 12);
            this.lblTituloCatalogos.Name = "lblTituloCatalogos";
            this.lblTituloCatalogos.Size = new System.Drawing.Size(235, 40);
            this.lblTituloCatalogos.TabIndex = 2;
            this.lblTituloCatalogos.Text = "📚 Catálogos";
            // 
            // panelConfiguraciones
            // 
            this.panelConfiguraciones.BackColor = System.Drawing.Color.White;
            this.panelConfiguraciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfiguraciones.Controls.Add(this.btnLicencias);
            this.panelConfiguraciones.Controls.Add(this.btnImpresiones);
            this.panelConfiguraciones.Controls.Add(this.btnConfigCajas);
            this.panelConfiguraciones.Controls.Add(this.btnMiEmpresa);
            this.panelConfiguraciones.Controls.Add(this.lblTituloConfiguraciones);
            this.panelConfiguraciones.Location = new System.Drawing.Point(27, 360);
            this.panelConfiguraciones.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelConfiguraciones.Name = "panelConfiguraciones";
            this.panelConfiguraciones.Size = new System.Drawing.Size(528, 276);
            this.panelConfiguraciones.TabIndex = 2;
            // 
            // btnImpresiones
            // 
            this.btnImpresiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnImpresiones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnImpresiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnImpresiones.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresiones.Image")));
            this.btnImpresiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresiones.Location = new System.Drawing.Point(270, 56);
            this.btnImpresiones.Name = "btnImpresiones";
            this.btnImpresiones.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnImpresiones.Size = new System.Drawing.Size(231, 80);
            this.btnImpresiones.TabIndex = 6;
            this.btnImpresiones.Text = "Impresiones";
            this.btnImpresiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpresiones.UseVisualStyleBackColor = false;
            this.btnImpresiones.Click += new System.EventHandler(this.btnImpresiones_Click);
            // 
            // btnConfigCajas
            // 
            this.btnConfigCajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnConfigCajas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnConfigCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigCajas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnConfigCajas.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigCajas.Image")));
            this.btnConfigCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigCajas.Location = new System.Drawing.Point(20, 171);
            this.btnConfigCajas.Name = "btnConfigCajas";
            this.btnConfigCajas.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnConfigCajas.Size = new System.Drawing.Size(231, 80);
            this.btnConfigCajas.TabIndex = 4;
            this.btnConfigCajas.Text = "Cajas";
            this.btnConfigCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigCajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigCajas.UseVisualStyleBackColor = false;
            this.btnConfigCajas.Click += new System.EventHandler(this.btnConfigCajas_Click);
            // 
            // btnMiEmpresa
            // 
            this.btnMiEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnMiEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnMiEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnMiEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnMiEmpresa.Image")));
            this.btnMiEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiEmpresa.Location = new System.Drawing.Point(20, 56);
            this.btnMiEmpresa.Name = "btnMiEmpresa";
            this.btnMiEmpresa.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnMiEmpresa.Size = new System.Drawing.Size(231, 80);
            this.btnMiEmpresa.TabIndex = 4;
            this.btnMiEmpresa.Text = "Mi Empresa";
            this.btnMiEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMiEmpresa.UseVisualStyleBackColor = false;
            this.btnMiEmpresa.Click += new System.EventHandler(this.btnMiEmpresa_Click);
            // 
            // lblTituloConfiguraciones
            // 
            this.lblTituloConfiguraciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloConfiguraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTituloConfiguraciones.Location = new System.Drawing.Point(16, 12);
            this.lblTituloConfiguraciones.Name = "lblTituloConfiguraciones";
            this.lblTituloConfiguraciones.Size = new System.Drawing.Size(290, 34);
            this.lblTituloConfiguraciones.TabIndex = 2;
            this.lblTituloConfiguraciones.Text = "⚙️ Configuraciones";
            // 
            // panelOperacionesCaja
            // 
            this.panelOperacionesCaja.BackColor = System.Drawing.Color.White;
            this.panelOperacionesCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperacionesCaja.Controls.Add(this.btnCorteCaja);
            this.panelOperacionesCaja.Controls.Add(this.lblTituloOperacionesCaja);
            this.panelOperacionesCaja.Location = new System.Drawing.Point(577, 360);
            this.panelOperacionesCaja.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelOperacionesCaja.Name = "panelOperacionesCaja";
            this.panelOperacionesCaja.Size = new System.Drawing.Size(528, 193);
            this.panelOperacionesCaja.TabIndex = 3;
            // 
            // btnCorteCaja
            // 
            this.btnCorteCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnCorteCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCorteCaja.Image")));
            this.btnCorteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorteCaja.Location = new System.Drawing.Point(20, 56);
            this.btnCorteCaja.Name = "btnCorteCaja";
            this.btnCorteCaja.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnCorteCaja.Size = new System.Drawing.Size(231, 80);
            this.btnCorteCaja.TabIndex = 7;
            this.btnCorteCaja.Text = "Corte de caja";
            this.btnCorteCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorteCaja.UseVisualStyleBackColor = false;
            this.btnCorteCaja.Click += new System.EventHandler(this.btnCorteCaja_Click);
            // 
            // lblTituloOperacionesCaja
            // 
            this.lblTituloOperacionesCaja.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloOperacionesCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTituloOperacionesCaja.Location = new System.Drawing.Point(16, 12);
            this.lblTituloOperacionesCaja.Name = "lblTituloOperacionesCaja";
            this.lblTituloOperacionesCaja.Size = new System.Drawing.Size(331, 34);
            this.lblTituloOperacionesCaja.TabIndex = 2;
            this.lblTituloOperacionesCaja.Text = "📖 Operaciones de Caja";
            // 
            // btnLicencias
            // 
            this.btnLicencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnLicencias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnLicencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnLicencias.Image = ((System.Drawing.Image)(resources.GetObject("btnLicencias.Image")));
            this.btnLicencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencias.Location = new System.Drawing.Point(270, 171);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnLicencias.Size = new System.Drawing.Size(231, 80);
            this.btnLicencias.TabIndex = 7;
            this.btnLicencias.Text = "Licencia";
            this.btnLicencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicencias.UseVisualStyleBackColor = false;
            this.btnLicencias.Click += new System.EventHandler(this.btnLicencias_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1408, 736);
            this.Controls.Add(this.flowContenedorCentral);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelLateral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowContenedorCentral.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelCatalogos.ResumeLayout(false);
            this.panelConfiguraciones.ResumeLayout(false);
            this.panelOperacionesCaja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.FlowLayoutPanel flowContenedorCentral;

        // Paneles de Tarjetas Organizados
        public System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label lblTituloVentas;
        public System.Windows.Forms.Panel panelCatalogos;
        private System.Windows.Forms.Label lblTituloCatalogos;
        public System.Windows.Forms.Panel panelConfiguraciones;
        private System.Windows.Forms.Label lblTituloConfiguraciones;
        public System.Windows.Forms.Panel panelOperacionesCaja;
        private System.Windows.Forms.Label lblTituloOperacionesCaja;

        // Botones de accesos corregidos
        private System.Windows.Forms.Button btnVentaMostrador;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnMiEmpresa;
        private System.Windows.Forms.Button btnImpresiones;
        private System.Windows.Forms.Button btnConfigCajas;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnArticules;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnCorteCaja;
        private System.Windows.Forms.Button btnLicencias;
    }
}
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
            this.BtnPanelSalir = new System.Windows.Forms.Button();
            this.btnPanelMenu = new System.Windows.Forms.Button();
            this.btnPanelCorte = new System.Windows.Forms.Button();
            this.btnPanelEmpresa = new System.Windows.Forms.Button();
            this.btnPanelArticulos = new System.Windows.Forms.Button();
            this.btnPanelVentas = new System.Windows.Forms.Button();
            this.lblPanelTituloApp = new System.Windows.Forms.Label();
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
            this.btnLicencias = new System.Windows.Forms.Button();
            this.btnImpresiones = new System.Windows.Forms.Button();
            this.btnConfigCajas = new System.Windows.Forms.Button();
            this.btnMiEmpresa = new System.Windows.Forms.Button();
            this.lblTituloConfiguraciones = new System.Windows.Forms.Label();
            this.panelOperacionesCaja = new System.Windows.Forms.Panel();
            this.btnCorteCaja = new System.Windows.Forms.Button();
            this.lblTituloOperacionesCaja = new System.Windows.Forms.Label();
            this.panelAlertaStock = new System.Windows.Forms.Panel();
            this.lblAlertaMensaje = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowContenedorCentral.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCatalogos.SuspendLayout();
            this.panelConfiguraciones.SuspendLayout();
            this.panelOperacionesCaja.SuspendLayout();
            this.panelAlertaStock.SuspendLayout();
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
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(264, 836);
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
            this.BtnPanelSalir.Location = new System.Drawing.Point(12, 502);
            this.BtnPanelSalir.Name = "BtnPanelSalir";
            this.BtnPanelSalir.Size = new System.Drawing.Size(252, 45);
            this.BtnPanelSalir.TabIndex = 5;
            this.BtnPanelSalir.Text = " Salir";
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
            this.btnPanelMenu.Size = new System.Drawing.Size(247, 82);
            this.btnPanelMenu.TabIndex = 8;
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
            this.btnPanelCorte.Location = new System.Drawing.Point(13, 430);
            this.btnPanelCorte.Name = "btnPanelCorte";
            this.btnPanelCorte.Size = new System.Drawing.Size(245, 45);
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
            this.btnPanelVentas.Size = new System.Drawing.Size(246, 82);
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
            this.flowContenedorCentral.Size = new System.Drawing.Size(1144, 751);
            this.flowContenedorCentral.TabIndex = 0;
            this.flowContenedorCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.flowContenedorCentral_Paint);
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
            this.btnArticules.Location = new System.Drawing.Point(280, 69);
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
            this.btnCategorias.Location = new System.Drawing.Point(33, 69);
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
            this.btnProveedores.Location = new System.Drawing.Point(280, 199);
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
            this.btnUsuarios.Location = new System.Drawing.Point(33, 199);
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
            // panelAlertaStock
            // 
            this.panelAlertaStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.panelAlertaStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlertaStock.Controls.Add(this.lblAlertaMensaje);
            this.panelAlertaStock.Location = new System.Drawing.Point(290, 85);
            this.panelAlertaStock.Name = "panelAlertaStock";
            this.panelAlertaStock.Size = new System.Drawing.Size(1079, 50);
            this.panelAlertaStock.TabIndex = 5;
            this.panelAlertaStock.Visible = false;
            // 
            // lblAlertaMensaje
            // 
            this.lblAlertaMensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlertaMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblAlertaMensaje.Location = new System.Drawing.Point(15, 11);
            this.lblAlertaMensaje.Name = "lblAlertaMensaje";
            this.lblAlertaMensaje.Size = new System.Drawing.Size(1000, 32);
            this.lblAlertaMensaje.TabIndex = 0;
            this.lblAlertaMensaje.Text = "⚠ Aviso: Se han detectado artículos con existencias agotadas o por debajo del mín" +
    "imo.";
            this.lblAlertaMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1408, 836);
            this.Controls.Add(this.flowContenedorCentral);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelAlertaStock);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowContenedorCentral.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelCatalogos.ResumeLayout(false);
            this.panelConfiguraciones.ResumeLayout(false);
            this.panelOperacionesCaja.ResumeLayout(false);
            this.panelAlertaStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblPanelTituloApp;
        private System.Windows.Forms.Button btnPanelVentas;
        private System.Windows.Forms.Button btnPanelArticulos;
        private System.Windows.Forms.Button btnPanelEmpresa;
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

        //Alerta de Stock Integrada
        public System.Windows.Forms.Panel panelAlertaStock;
        private System.Windows.Forms.Label lblAlertaMensaje;

        // Botones de accesos corregidos
        private System.Windows.Forms.Button btnVentaMostrador;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnMiEmpresa;
        private System.Windows.Forms.Button btnImpresiones;
        private System.Windows.Forms.Button btnConfigCajas;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPanelSalir;
        private System.Windows.Forms.Button btnArticules;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnPanelCorte;
        private System.Windows.Forms.Button btnCorteCaja;
        private System.Windows.Forms.Button btnLicencias;
        private System.Windows.Forms.Button btnPanelMenu;
    }
}
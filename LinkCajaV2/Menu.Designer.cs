namespace LinkCajaV2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.BtnCajas = new System.Windows.Forms.Button();
            this.GBConfiguraciones = new System.Windows.Forms.GroupBox();
            this.btnImpresiones = new System.Windows.Forms.Button();
            this.gbCatalogos = new System.Windows.Forms.GroupBox();
            this.btnCategorizes = new System.Windows.Forms.Button();
            this.BtnRecetas = new System.Windows.Forms.Button();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.gbMostrador = new System.Windows.Forms.GroupBox();
            this.GBVenta = new System.Windows.Forms.GroupBox();
            this.GBArticulos = new System.Windows.Forms.GroupBox();
            this.btnArticulos2 = new System.Windows.Forms.Button();
            this.GBReportes = new System.Windows.Forms.GroupBox();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.btnReporteTickets = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GBConfiguraciones.SuspendLayout();
            this.gbCatalogos.SuspendLayout();
            this.gbMostrador.SuspendLayout();
            this.GBVenta.SuspendLayout();
            this.GBArticulos.SuspendLayout();
            this.GBReportes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(802, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenciaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.licenciaToolStripMenuItem.Text = "Licencia";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Image")));
            this.btnEmpresa.Location = new System.Drawing.Point(10, 35);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(130, 110);
            this.btnEmpresa.TabIndex = 2;
            this.btnEmpresa.Text = "Mi Empresa";
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // BtnCajas
            // 
            this.BtnCajas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCajas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCajas.Image = ((System.Drawing.Image)(resources.GetObject("BtnCajas.Image")));
            this.BtnCajas.Location = new System.Drawing.Point(154, 35);
            this.BtnCajas.Name = "BtnCajas";
            this.BtnCajas.Size = new System.Drawing.Size(130, 110);
            this.BtnCajas.TabIndex = 3;
            this.BtnCajas.Text = "Cajas";
            this.BtnCajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCajas.UseVisualStyleBackColor = true;
            this.BtnCajas.Click += new System.EventHandler(this.BtnCajas_Click);
            // 
            // GBConfiguraciones
            // 
            this.GBConfiguraciones.Controls.Add(this.btnImpresiones);
            this.GBConfiguraciones.Controls.Add(this.btnEmpresa);
            this.GBConfiguraciones.Controls.Add(this.BtnCajas);
            this.GBConfiguraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBConfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBConfiguraciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBConfiguraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBConfiguraciones.Location = new System.Drawing.Point(0, 133);
            this.GBConfiguraciones.Name = "GBConfiguraciones";
            this.GBConfiguraciones.Size = new System.Drawing.Size(802, 159);
            this.GBConfiguraciones.TabIndex = 1;
            this.GBConfiguraciones.TabStop = false;
            this.GBConfiguraciones.Text = "Configuraciones";
            // 
            // btnImpresiones
            // 
            this.btnImpresiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpresiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresiones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresiones.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresiones.Image")));
            this.btnImpresiones.Location = new System.Drawing.Point(298, 35);
            this.btnImpresiones.Name = "btnImpresiones";
            this.btnImpresiones.Size = new System.Drawing.Size(159, 110);
            this.btnImpresiones.TabIndex = 4;
            this.btnImpresiones.Text = "Impresiones";
            this.btnImpresiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImpresiones.UseVisualStyleBackColor = true;
            this.btnImpresiones.Click += new System.EventHandler(this.btnImpresiones_Click);
            // 
            // gbCatalogos
            // 
            this.gbCatalogos.Controls.Add(this.btnCategorizes);
            this.gbCatalogos.Controls.Add(this.BtnRecetas);
            this.gbCatalogos.Controls.Add(this.BtnArticulos);
            this.gbCatalogos.Controls.Add(this.btnClientes);
            this.gbCatalogos.Controls.Add(this.btnProveedores);
            this.gbCatalogos.Controls.Add(this.btnUsuarios);
            this.gbCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCatalogos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCatalogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.gbCatalogos.Location = new System.Drawing.Point(0, 292);
            this.gbCatalogos.Name = "gbCatalogos";
            this.gbCatalogos.Size = new System.Drawing.Size(802, 170);
            this.gbCatalogos.TabIndex = 5;
            this.gbCatalogos.TabStop = false;
            this.gbCatalogos.Text = "Catalogos";
            // 
            // btnCategorizes
            // 
            this.btnCategorizes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorizes.FlatAppearance.BorderSize = 0;
            this.btnCategorizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorizes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnCategorizes.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorizes.Image")));
            this.btnCategorizes.Location = new System.Drawing.Point(319, 48);
            this.btnCategorizes.Name = "btnCategorizes";
            this.btnCategorizes.Size = new System.Drawing.Size(127, 87);
            this.btnCategorizes.TabIndex = 8;
            this.btnCategorizes.Text = "Categorias";
            this.btnCategorizes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategorizes.UseVisualStyleBackColor = true;
            this.btnCategorizes.Click += new System.EventHandler(this.btnCategorizes_Click);
            // 
            // BtnRecetas
            // 
            this.BtnRecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecetas.Enabled = false;
            this.BtnRecetas.FlatAppearance.BorderSize = 0;
            this.BtnRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecetas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnRecetas.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecetas.Image")));
            this.BtnRecetas.Location = new System.Drawing.Point(585, 48);
            this.BtnRecetas.Name = "BtnRecetas";
            this.BtnRecetas.Size = new System.Drawing.Size(114, 87);
            this.BtnRecetas.TabIndex = 10;
            this.BtnRecetas.Text = "Recetas";
            this.BtnRecetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRecetas.UseVisualStyleBackColor = true;
            this.BtnRecetas.Visible = false;
            this.BtnRecetas.Click += new System.EventHandler(this.BtnRecetas_Click);
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArticulos.FlatAppearance.BorderSize = 0;
            this.BtnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("BtnArticulos.Image")));
            this.BtnArticulos.Location = new System.Drawing.Point(452, 48);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(127, 87);
            this.BtnArticulos.TabIndex = 9;
            this.BtnArticulos.Text = "Inventario";
            this.BtnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(672, 48);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(130, 87);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.Location = new System.Drawing.Point(140, 48);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(173, 87);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(10, 48);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(130, 87);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVenta.FlatAppearance.BorderSize = 0;
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnVenta.Image")));
            this.BtnVenta.Location = new System.Drawing.Point(5, 6);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(130, 110);
            this.BtnVenta.TabIndex = 14;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // gbMostrador
            // 
            this.gbMostrador.Controls.Add(this.GBVenta);
            this.gbMostrador.Controls.Add(this.GBArticulos);
            this.gbMostrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMostrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMostrador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMostrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.gbMostrador.Location = new System.Drawing.Point(0, 462);
            this.gbMostrador.Name = "gbMostrador";
            this.gbMostrador.Size = new System.Drawing.Size(802, 177);
            this.gbMostrador.TabIndex = 12;
            this.gbMostrador.TabStop = false;
            this.gbMostrador.Text = "Mostrador";
            // 
            // GBVenta
            // 
            this.GBVenta.Controls.Add(this.BtnVenta);
            this.GBVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.GBVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBVenta.Location = new System.Drawing.Point(124, 35);
            this.GBVenta.Name = "GBVenta";
            this.GBVenta.Size = new System.Drawing.Size(103, 139);
            this.GBVenta.TabIndex = 7;
            this.GBVenta.TabStop = false;
            // 
            // GBArticulos
            // 
            this.GBArticulos.Controls.Add(this.btnArticulos2);
            this.GBArticulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.GBArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBArticulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBArticulos.Location = new System.Drawing.Point(3, 35);
            this.GBArticulos.Name = "GBArticulos";
            this.GBArticulos.Size = new System.Drawing.Size(121, 139);
            this.GBArticulos.TabIndex = 8;
            this.GBArticulos.TabStop = false;
            // 
            // btnArticulos2
            // 
            this.btnArticulos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos2.FlatAppearance.BorderSize = 0;
            this.btnArticulos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnArticulos2.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulos2.Image")));
            this.btnArticulos2.Location = new System.Drawing.Point(6, 6);
            this.btnArticulos2.Name = "btnArticulos2";
            this.btnArticulos2.Size = new System.Drawing.Size(130, 110);
            this.btnArticulos2.TabIndex = 13;
            this.btnArticulos2.Text = "Inventario";
            this.btnArticulos2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArticulos2.UseVisualStyleBackColor = true;
            this.btnArticulos2.Click += new System.EventHandler(this.btnArticulos2_Click);
            // 
            // GBReportes
            // 
            this.GBReportes.Controls.Add(this.BtnCorte);
            this.GBReportes.Controls.Add(this.btnReporteTickets);
            this.GBReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBReportes.Location = new System.Drawing.Point(0, 639);
            this.GBReportes.Name = "GBReportes";
            this.GBReportes.Size = new System.Drawing.Size(802, 169);
            this.GBReportes.TabIndex = 15;
            this.GBReportes.TabStop = false;
            this.GBReportes.Text = "Reportes";
            // 
            // BtnCorte
            // 
            this.BtnCorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorte.Image = ((System.Drawing.Image)(resources.GetObject("BtnCorte.Image")));
            this.BtnCorte.Location = new System.Drawing.Point(150, 38);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(172, 110);
            this.BtnCorte.TabIndex = 17;
            this.BtnCorte.Text = "Corte de caja";
            this.BtnCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCorte.UseVisualStyleBackColor = true;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // btnReporteTickets
            // 
            this.btnReporteTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteTickets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteTickets.Image")));
            this.btnReporteTickets.Location = new System.Drawing.Point(8, 38);
            this.btnReporteTickets.Name = "btnReporteTickets";
            this.btnReporteTickets.Size = new System.Drawing.Size(130, 110);
            this.btnReporteTickets.TabIndex = 16;
            this.btnReporteTickets.Text = "Tickets";
            this.btnReporteTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporteTickets.UseVisualStyleBackColor = true;
            this.btnReporteTickets.Click += new System.EventHandler(this.btnReporteTickets_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 100);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Location = new System.Drawing.Point(615, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 94);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(79, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 66);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(24, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menú Principal";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 952);
            this.Controls.Add(this.GBReportes);
            this.Controls.Add(this.gbMostrador);
            this.Controls.Add(this.gbCatalogos);
            this.Controls.Add(this.GBConfiguraciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBConfiguraciones.ResumeLayout(false);
            this.gbCatalogos.ResumeLayout(false);
            this.gbMostrador.ResumeLayout(false);
            this.GBVenta.ResumeLayout(false);
            this.GBArticulos.ResumeLayout(false);
            this.GBReportes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button BtnCajas;
        private System.Windows.Forms.GroupBox GBConfiguraciones;
        private System.Windows.Forms.GroupBox gbCatalogos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button BtnArticulos;
        private System.Windows.Forms.Button BtnRecetas;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button btnImpresiones;
        private System.Windows.Forms.GroupBox gbMostrador;
        private System.Windows.Forms.GroupBox GBReportes;
        private System.Windows.Forms.Button btnReporteTickets;
        private System.Windows.Forms.Button btnArticulos2;
        private System.Windows.Forms.GroupBox GBArticulos;
        private System.Windows.Forms.GroupBox GBVenta;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCategorizes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
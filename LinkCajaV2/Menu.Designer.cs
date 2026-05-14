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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.BtnCajas = new System.Windows.Forms.Button();
            this.GBConfiguraciones = new System.Windows.Forms.GroupBox();
            this.btnImpresiones = new System.Windows.Forms.Button();
            this.gbCatalogos = new System.Windows.Forms.GroupBox();
            this.BtnRecetas = new System.Windows.Forms.Button();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.gbMostrador = new System.Windows.Forms.GroupBox();
            this.GBReportes = new System.Windows.Forms.GroupBox();
            this.btnReporteTickets = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GBConfiguraciones.SuspendLayout();
            this.gbCatalogos.SuspendLayout();
            this.gbMostrador.SuspendLayout();
            this.GBReportes.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(761, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.licenciaToolStripMenuItem.Text = "Licencia";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(20, 35);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(143, 84);
            this.btnEmpresa.TabIndex = 1;
            this.btnEmpresa.Text = "Mi Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // BtnCajas
            // 
            this.BtnCajas.Location = new System.Drawing.Point(181, 35);
            this.BtnCajas.Name = "BtnCajas";
            this.BtnCajas.Size = new System.Drawing.Size(104, 84);
            this.BtnCajas.TabIndex = 2;
            this.BtnCajas.Text = "Cajas";
            this.BtnCajas.UseVisualStyleBackColor = true;
            this.BtnCajas.Click += new System.EventHandler(this.BtnCajas_Click);
            // 
            // GBConfiguraciones
            // 
            this.GBConfiguraciones.Controls.Add(this.btnImpresiones);
            this.GBConfiguraciones.Controls.Add(this.btnEmpresa);
            this.GBConfiguraciones.Controls.Add(this.BtnCajas);
            this.GBConfiguraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBConfiguraciones.Location = new System.Drawing.Point(0, 36);
            this.GBConfiguraciones.Name = "GBConfiguraciones";
            this.GBConfiguraciones.Size = new System.Drawing.Size(761, 138);
            this.GBConfiguraciones.TabIndex = 3;
            this.GBConfiguraciones.TabStop = false;
            this.GBConfiguraciones.Text = "Configuraciones";
            // 
            // btnImpresiones
            // 
            this.btnImpresiones.Location = new System.Drawing.Point(306, 35);
            this.btnImpresiones.Name = "btnImpresiones";
            this.btnImpresiones.Size = new System.Drawing.Size(130, 84);
            this.btnImpresiones.TabIndex = 3;
            this.btnImpresiones.Text = "Impresiones";
            this.btnImpresiones.UseVisualStyleBackColor = true;
            this.btnImpresiones.Click += new System.EventHandler(this.btnImpresiones_Click);
            // 
            // gbCatalogos
            // 
            this.gbCatalogos.Controls.Add(this.BtnRecetas);
            this.gbCatalogos.Controls.Add(this.BtnArticulos);
            this.gbCatalogos.Controls.Add(this.btnClientes);
            this.gbCatalogos.Controls.Add(this.btnProveedores);
            this.gbCatalogos.Controls.Add(this.btnUsuarios);
            this.gbCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCatalogos.Location = new System.Drawing.Point(0, 174);
            this.gbCatalogos.Name = "gbCatalogos";
            this.gbCatalogos.Size = new System.Drawing.Size(761, 100);
            this.gbCatalogos.TabIndex = 4;
            this.gbCatalogos.TabStop = false;
            this.gbCatalogos.Text = "Catalogos";
            // 
            // BtnRecetas
            // 
            this.BtnRecetas.Enabled = false;
            this.BtnRecetas.Location = new System.Drawing.Point(494, 27);
            this.BtnRecetas.Name = "BtnRecetas";
            this.BtnRecetas.Size = new System.Drawing.Size(93, 74);
            this.BtnRecetas.TabIndex = 4;
            this.BtnRecetas.Text = "Recetas";
            this.BtnRecetas.UseVisualStyleBackColor = true;
            this.BtnRecetas.Visible = false;
            this.BtnRecetas.Click += new System.EventHandler(this.BtnRecetas_Click);
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.Location = new System.Drawing.Point(389, 26);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(88, 75);
            this.BtnArticulos.TabIndex = 3;
            this.BtnArticulos.Text = "Articulos";
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(280, 25);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(94, 75);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(130, 25);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(130, 75);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(20, 25);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(89, 75);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Location = new System.Drawing.Point(20, 23);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(89, 71);
            this.BtnVenta.TabIndex = 5;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // gbMostrador
            // 
            this.gbMostrador.Controls.Add(this.BtnVenta);
            this.gbMostrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMostrador.Location = new System.Drawing.Point(0, 274);
            this.gbMostrador.Name = "gbMostrador";
            this.gbMostrador.Size = new System.Drawing.Size(761, 100);
            this.gbMostrador.TabIndex = 6;
            this.gbMostrador.TabStop = false;
            this.gbMostrador.Text = "Mostrador";
            // 
            // GBReportes
            // 
            this.GBReportes.Controls.Add(this.btnReporteTickets);
            this.GBReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBReportes.Location = new System.Drawing.Point(0, 374);
            this.GBReportes.Name = "GBReportes";
            this.GBReportes.Size = new System.Drawing.Size(761, 100);
            this.GBReportes.TabIndex = 7;
            this.GBReportes.TabStop = false;
            this.GBReportes.Text = "Reportes";
            // 
            // btnReporteTickets
            // 
            this.btnReporteTickets.Location = new System.Drawing.Point(8, 38);
            this.btnReporteTickets.Name = "btnReporteTickets";
            this.btnReporteTickets.Size = new System.Drawing.Size(115, 56);
            this.btnReporteTickets.TabIndex = 0;
            this.btnReporteTickets.Text = "Tickets";
            this.btnReporteTickets.UseVisualStyleBackColor = true;
            this.btnReporteTickets.Click += new System.EventHandler(this.btnReporteTickets_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 488);
            this.Controls.Add(this.GBReportes);
            this.Controls.Add(this.gbMostrador);
            this.Controls.Add(this.gbCatalogos);
            this.Controls.Add(this.GBConfiguraciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBConfiguraciones.ResumeLayout(false);
            this.gbCatalogos.ResumeLayout(false);
            this.gbMostrador.ResumeLayout(false);
            this.GBReportes.ResumeLayout(false);
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
    }
}
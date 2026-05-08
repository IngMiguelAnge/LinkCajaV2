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
            this.gbCatalogos = new System.Windows.Forms.GroupBox();
            this.BtnRecetas = new System.Windows.Forms.Button();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.lblMostrador = new System.Windows.Forms.Label();
            this.btnImpresiones = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GBConfiguraciones.SuspendLayout();
            this.gbCatalogos.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(761, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
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
            this.GBConfiguraciones.Location = new System.Drawing.Point(12, 62);
            this.GBConfiguraciones.Name = "GBConfiguraciones";
            this.GBConfiguraciones.Size = new System.Drawing.Size(460, 138);
            this.GBConfiguraciones.TabIndex = 3;
            this.GBConfiguraciones.TabStop = false;
            this.GBConfiguraciones.Text = "Configuraciones";
            // 
            // gbCatalogos
            // 
            this.gbCatalogos.Controls.Add(this.BtnRecetas);
            this.gbCatalogos.Controls.Add(this.BtnArticulos);
            this.gbCatalogos.Controls.Add(this.btnClientes);
            this.gbCatalogos.Controls.Add(this.btnProveedores);
            this.gbCatalogos.Controls.Add(this.btnUsuarios);
            this.gbCatalogos.Location = new System.Drawing.Point(32, 215);
            this.gbCatalogos.Name = "gbCatalogos";
            this.gbCatalogos.Size = new System.Drawing.Size(660, 100);
            this.gbCatalogos.TabIndex = 4;
            this.gbCatalogos.TabStop = false;
            this.gbCatalogos.Text = "Catalogos";
            // 
            // BtnRecetas
            // 
            this.BtnRecetas.Enabled = false;
            this.BtnRecetas.Location = new System.Drawing.Point(536, 26);
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
            this.BtnArticulos.Location = new System.Drawing.Point(417, 25);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(88, 75);
            this.BtnArticulos.TabIndex = 3;
            this.BtnArticulos.Text = "Articulos";
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(304, 25);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(94, 75);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(116, 25);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(130, 75);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(6, 25);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(89, 75);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Location = new System.Drawing.Point(38, 350);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(89, 71);
            this.BtnVenta.TabIndex = 5;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // lblMostrador
            // 
            this.lblMostrador.AutoSize = true;
            this.lblMostrador.Location = new System.Drawing.Point(46, 327);
            this.lblMostrador.Name = "lblMostrador";
            this.lblMostrador.Size = new System.Drawing.Size(81, 20);
            this.lblMostrador.TabIndex = 6;
            this.lblMostrador.Text = "Mostrador";
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 476);
            this.Controls.Add(this.lblMostrador);
            this.Controls.Add(this.BtnVenta);
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
        private System.Windows.Forms.Label lblMostrador;
        private System.Windows.Forms.Button btnImpresiones;
    }
}
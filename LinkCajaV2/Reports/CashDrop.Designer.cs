namespace LinkCajaV2.Reports
{
    partial class CashDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashDrop));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.BtnPanelSalir = new System.Windows.Forms.Button();
            this.btnPanelMenu = new System.Windows.Forms.Button();
            this.btnPanelCorte = new System.Windows.Forms.Button();
            this.btnPanelEmpresa = new System.Windows.Forms.Button();
            this.btnPanelArticulos = new System.Windows.Forms.Button();
            this.btnPanelVentas = new System.Windows.Forms.Button();
            this.lblPanelTituloApp = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dgvCorte = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.CBResumen = new System.Windows.Forms.ComboBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
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
            this.panelLateral.Size = new System.Drawing.Size(264, 790);
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
            this.BtnPanelSalir.Location = new System.Drawing.Point(13, 503);
            this.BtnPanelSalir.Name = "BtnPanelSalir";
            this.BtnPanelSalir.Size = new System.Drawing.Size(238, 45);
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
            this.btnPanelMenu.Location = new System.Drawing.Point(11, 121);
            this.btnPanelMenu.Name = "btnPanelMenu";
            this.btnPanelMenu.Size = new System.Drawing.Size(246, 82);
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
            this.btnPanelCorte.Location = new System.Drawing.Point(9, 430);
            this.btnPanelCorte.Name = "btnPanelCorte";
            this.btnPanelCorte.Size = new System.Drawing.Size(249, 45);
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
            // dtHasta
            // 
            this.dtHasta.CalendarFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Location = new System.Drawing.Point(491, 125);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(419, 37);
            this.dtHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHasta.Location = new System.Drawing.Point(486, 84);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(66, 25);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDesde.Location = new System.Drawing.Point(43, 84);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(69, 25);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dtDesde
            // 
            this.dtDesde.CalendarFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Location = new System.Drawing.Point(48, 125);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(426, 37);
            this.dtDesde.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatos.Controls.Add(this.dgvCorte);
            this.gbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.gbDatos.Location = new System.Drawing.Point(31, 185);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(2135, 581);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Resumen del sistema";
            // 
            // dgvCorte
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvCorte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCorte.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCorte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCorte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCorte.EnableHeadersVisualStyles = false;
            this.dgvCorte.Location = new System.Drawing.Point(3, 35);
            this.dgvCorte.Name = "dgvCorte";
            this.dgvCorte.RowHeadersWidth = 62;
            this.dgvCorte.RowTemplate.Height = 28;
            this.dgvCorte.Size = new System.Drawing.Size(2129, 543);
            this.dgvCorte.TabIndex = 0;
            this.dgvCorte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorte_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1240, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 41);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 48);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Resumen";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblOpciones.Location = new System.Drawing.Point(924, 96);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(96, 25);
            this.lblOpciones.TabIndex = 33;
            this.lblOpciones.Text = "Opciones:";
            // 
            // CBResumen
            // 
            this.CBResumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBResumen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBResumen.FormattingEnabled = true;
            this.CBResumen.Items.AddRange(new object[] {
            "Ver Resumen",
            "Ver Entradas/Salidas"});
            this.CBResumen.Location = new System.Drawing.Point(929, 124);
            this.CBResumen.Name = "CBResumen";
            this.CBResumen.Size = new System.Drawing.Size(272, 38);
            this.CBResumen.TabIndex = 35;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.Controls.Add(this.btnBuscar);
            this.PanelPrincipal.Controls.Add(this.lblTitulo);
            this.PanelPrincipal.Controls.Add(this.dtHasta);
            this.PanelPrincipal.Controls.Add(this.lblHasta);
            this.PanelPrincipal.Controls.Add(this.lblDesde);
            this.PanelPrincipal.Controls.Add(this.CBResumen);
            this.PanelPrincipal.Controls.Add(this.dtDesde);
            this.PanelPrincipal.Controls.Add(this.lblOpciones);
            this.PanelPrincipal.Controls.Add(this.gbDatos);
            this.PanelPrincipal.Location = new System.Drawing.Point(270, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1613, 773);
            this.PanelPrincipal.TabIndex = 36;
            // 
            // CashDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1624, 790);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CashDrop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashDrop_Load);
            this.panelLateral.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.ResumeLayout(false);

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

        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DataGridView dgvCorte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.ComboBox CBResumen;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}
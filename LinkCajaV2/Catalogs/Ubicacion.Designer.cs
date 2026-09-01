namespace LinkCajaV2.Catalogs
{
    partial class Ubicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ubicacion));
            this.txtDireccionProporcionada = new System.Windows.Forms.TextBox();
            this.DireccionP = new System.Windows.Forms.Label();
            this.txtDireccionOficial = new System.Windows.Forms.TextBox();
            this.DireccionOfficial = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.Longitud = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.Latitud = new System.Windows.Forms.Label();
            this.CBCoordendadas = new System.Windows.Forms.CheckBox();
            this.LabelVista = new System.Windows.Forms.Label();
            this.btnCancelarDireccion = new System.Windows.Forms.Button();
            this.GpMap = new System.Windows.Forms.GroupBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.cmbMapas = new System.Windows.Forms.ComboBox();
            this.Tarifa = new System.Windows.Forms.Label();
            this.numCostoEnvio = new System.Windows.Forms.NumericUpDown();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.btnConfirmarDireccion = new System.Windows.Forms.Button();
            this.GpMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoEnvio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccionProporcionada
            // 
            this.txtDireccionProporcionada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionProporcionada.Location = new System.Drawing.Point(21, 35);
            this.txtDireccionProporcionada.Name = "txtDireccionProporcionada";
            this.txtDireccionProporcionada.Size = new System.Drawing.Size(1288, 32);
            this.txtDireccionProporcionada.TabIndex = 0;
            // 
            // DireccionP
            // 
            this.DireccionP.AutoSize = true;
            this.DireccionP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.DireccionP.Location = new System.Drawing.Point(17, 12);
            this.DireccionP.Name = "DireccionP";
            this.DireccionP.Size = new System.Drawing.Size(89, 20);
            this.DireccionP.TabIndex = 46;
            this.DireccionP.Text = "Dirección: *";
            // 
            // txtDireccionOficial
            // 
            this.txtDireccionOficial.Enabled = false;
            this.txtDireccionOficial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionOficial.Location = new System.Drawing.Point(21, 194);
            this.txtDireccionOficial.Name = "txtDireccionOficial";
            this.txtDireccionOficial.ReadOnly = true;
            this.txtDireccionOficial.Size = new System.Drawing.Size(908, 32);
            this.txtDireccionOficial.TabIndex = 47;
            // 
            // DireccionOfficial
            // 
            this.DireccionOfficial.AutoSize = true;
            this.DireccionOfficial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionOfficial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.DireccionOfficial.Location = new System.Drawing.Point(17, 168);
            this.DireccionOfficial.Name = "DireccionOfficial";
            this.DireccionOfficial.Size = new System.Drawing.Size(126, 20);
            this.DireccionOfficial.TabIndex = 48;
            this.DireccionOfficial.Text = "Dirección Oficial:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitud.Location = new System.Drawing.Point(222, 110);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(170, 32);
            this.txtLongitud.TabIndex = 2;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Longitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.Longitud.Location = new System.Drawing.Point(218, 83);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(76, 20);
            this.Longitud.TabIndex = 52;
            this.Longitud.Text = "Longitud:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitud.Location = new System.Drawing.Point(22, 110);
            this.txtLatitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(170, 32);
            this.txtLatitud.TabIndex = 1;
            // 
            // Latitud
            // 
            this.Latitud.AutoSize = true;
            this.Latitud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.Latitud.Location = new System.Drawing.Point(21, 83);
            this.Latitud.Name = "Latitud";
            this.Latitud.Size = new System.Drawing.Size(63, 20);
            this.Latitud.TabIndex = 51;
            this.Latitud.Text = "Latitud:";
            // 
            // CBCoordendadas
            // 
            this.CBCoordendadas.AutoSize = true;
            this.CBCoordendadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CBCoordendadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.CBCoordendadas.Location = new System.Drawing.Point(421, 118);
            this.CBCoordendadas.Name = "CBCoordendadas";
            this.CBCoordendadas.Size = new System.Drawing.Size(215, 24);
            this.CBCoordendadas.TabIndex = 3;
            this.CBCoordendadas.Text = "¿Buscar por Coordenadas?";
            this.CBCoordendadas.UseVisualStyleBackColor = true;
            this.CBCoordendadas.CheckedChanged += new System.EventHandler(this.CBCoordendadas_CheckedChanged);
            // 
            // LabelVista
            // 
            this.LabelVista.AutoSize = true;
            this.LabelVista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.LabelVista.Location = new System.Drawing.Point(1077, 168);
            this.LabelVista.Name = "LabelVista";
            this.LabelVista.Size = new System.Drawing.Size(48, 20);
            this.LabelVista.TabIndex = 55;
            this.LabelVista.Text = "Vista:";
            // 
            // btnCancelarDireccion
            // 
            this.btnCancelarDireccion.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDireccion.FlatAppearance.BorderSize = 0;
            this.btnCancelarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDireccion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancelarDireccion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDireccion.Location = new System.Drawing.Point(25, 267);
            this.btnCancelarDireccion.Name = "btnCancelarDireccion";
            this.btnCancelarDireccion.Size = new System.Drawing.Size(159, 36);
            this.btnCancelarDireccion.TabIndex = 6;
            this.btnCancelarDireccion.Text = "Cancelar Ubicación";
            this.btnCancelarDireccion.UseVisualStyleBackColor = false;
            this.btnCancelarDireccion.Click += new System.EventHandler(this.btnCancelarDireccion_Click);
            // 
            // GpMap
            // 
            this.GpMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpMap.Controls.Add(this.gMap);
            this.GpMap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GpMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GpMap.Location = new System.Drawing.Point(12, 322);
            this.GpMap.Name = "GpMap";
            this.GpMap.Size = new System.Drawing.Size(1409, 419);
            this.GpMap.TabIndex = 60;
            this.GpMap.TabStop = false;
            this.GpMap.Text = "Mapa";
            // 
            // gMap
            // 
            this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(6, 21);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1385, 379);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMap_OnMarkerEnter);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            this.gMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseUp);
            // 
            // cmbMapas
            // 
            this.cmbMapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMapas.FormattingEnabled = true;
            this.cmbMapas.Items.AddRange(new object[] {
            "Calles (Google)",
            "Satélite",
            "Híbrido",
            "OpenStreet"});
            this.cmbMapas.Location = new System.Drawing.Point(1081, 194);
            this.cmbMapas.Name = "cmbMapas";
            this.cmbMapas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMapas.Size = new System.Drawing.Size(227, 28);
            this.cmbMapas.TabIndex = 5;
            this.cmbMapas.SelectedIndexChanged += new System.EventHandler(this.cmbMapas_SelectedIndexChanged);
            // 
            // Tarifa
            // 
            this.Tarifa.AutoSize = true;
            this.Tarifa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.Tarifa.Location = new System.Drawing.Point(744, 83);
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Size = new System.Drawing.Size(64, 20);
            this.Tarifa.TabIndex = 63;
            this.Tarifa.Text = "Tarifa: *";
            // 
            // numCostoEnvio
            // 
            this.numCostoEnvio.DecimalPlaces = 2;
            this.numCostoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCostoEnvio.Location = new System.Drawing.Point(748, 118);
            this.numCostoEnvio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCostoEnvio.Name = "numCostoEnvio";
            this.numCostoEnvio.Size = new System.Drawing.Size(170, 28);
            this.numCostoEnvio.TabIndex = 4;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(1150, 267);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(159, 39);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(199, 267);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(121, 38);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnConfirmarDireccion
            // 
            this.btnConfirmarDireccion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirmarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarDireccion.FlatAppearance.BorderSize = 0;
            this.btnConfirmarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarDireccion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarDireccion.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarDireccion.Location = new System.Drawing.Point(339, 267);
            this.btnConfirmarDireccion.Name = "btnConfirmarDireccion";
            this.btnConfirmarDireccion.Size = new System.Drawing.Size(165, 36);
            this.btnConfirmarDireccion.TabIndex = 8;
            this.btnConfirmarDireccion.Text = "Confirmar Ubicación";
            this.btnConfirmarDireccion.UseVisualStyleBackColor = false;
            this.btnConfirmarDireccion.Click += new System.EventHandler(this.btnConfirmarDireccion_Click);
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 753);
            this.Controls.Add(this.btnConfirmarDireccion);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.numCostoEnvio);
            this.Controls.Add(this.Tarifa);
            this.Controls.Add(this.cmbMapas);
            this.Controls.Add(this.GpMap);
            this.Controls.Add(this.btnCancelarDireccion);
            this.Controls.Add(this.LabelVista);
            this.Controls.Add(this.CBCoordendadas);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.Latitud);
            this.Controls.Add(this.txtDireccionOficial);
            this.Controls.Add(this.DireccionOfficial);
            this.Controls.Add(this.txtDireccionProporcionada);
            this.Controls.Add(this.DireccionP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ubicacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ubicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            this.GpMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCostoEnvio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DireccionP;
        private System.Windows.Forms.Label DireccionOfficial;
        private System.Windows.Forms.Label Longitud;
        private System.Windows.Forms.Label Latitud;
        private System.Windows.Forms.CheckBox CBCoordendadas;
        private System.Windows.Forms.Label LabelVista;
        private System.Windows.Forms.Button btnCancelarDireccion;
        private System.Windows.Forms.GroupBox GpMap;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.ComboBox cmbMapas;
        private System.Windows.Forms.Label Tarifa;
        public System.Windows.Forms.TextBox txtDireccionProporcionada;
        public System.Windows.Forms.TextBox txtDireccionOficial;
        public System.Windows.Forms.TextBox txtLongitud;
        public System.Windows.Forms.TextBox txtLatitud;
        public System.Windows.Forms.NumericUpDown numCostoEnvio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button btnConfirmarDireccion;
    }
}
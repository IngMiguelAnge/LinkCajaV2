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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionOficial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCoordendadas = new System.Windows.Forms.CheckBox();
            this.LabelVista = new System.Windows.Forms.Label();
            this.btnCancelarDireccion = new System.Windows.Forms.Button();
            this.GpMap = new System.Windows.Forms.GroupBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.cmbMapas = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numCostoEnvio = new System.Windows.Forms.NumericUpDown();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
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
            this.txtDireccionProporcionada.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Direccion Proporcionada:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(17, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Direccion Oficial:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitud.Location = new System.Drawing.Point(222, 110);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(170, 32);
            this.txtLongitud.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(218, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Longitud:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitud.Location = new System.Drawing.Point(22, 110);
            this.txtLatitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(170, 32);
            this.txtLatitud.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(21, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Latitud:";
            // 
            // CBCoordendadas
            // 
            this.CBCoordendadas.AutoSize = true;
            this.CBCoordendadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CBCoordendadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.CBCoordendadas.Location = new System.Drawing.Point(421, 118);
            this.CBCoordendadas.Name = "CBCoordendadas";
            this.CBCoordendadas.Size = new System.Drawing.Size(215, 24);
            this.CBCoordendadas.TabIndex = 53;
            this.CBCoordendadas.Text = "¿Buscar por Coordenadas?";
            this.CBCoordendadas.UseVisualStyleBackColor = true;
            this.CBCoordendadas.CheckedChanged += new System.EventHandler(this.CBCoordendadas_CheckedChanged);
            // 
            // LabelVista
            // 
            this.LabelVista.AutoSize = true;
            this.LabelVista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.LabelVista.Location = new System.Drawing.Point(993, 168);
            this.LabelVista.Name = "LabelVista";
            this.LabelVista.Size = new System.Drawing.Size(48, 20);
            this.LabelVista.TabIndex = 55;
            this.LabelVista.Text = "Vista:";
            // 
            // btnCancelarDireccion
            // 
            this.btnCancelarDireccion.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDireccion.FlatAppearance.BorderSize = 0;
            this.btnCancelarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDireccion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancelarDireccion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDireccion.Location = new System.Drawing.Point(25, 266);
            this.btnCancelarDireccion.Name = "btnCancelarDireccion";
            this.btnCancelarDireccion.Size = new System.Drawing.Size(159, 36);
            this.btnCancelarDireccion.TabIndex = 58;
            this.btnCancelarDireccion.Text = "Cancelar Ubicacion";
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
            this.cmbMapas.Location = new System.Drawing.Point(987, 198);
            this.cmbMapas.Name = "cmbMapas";
            this.cmbMapas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMapas.Size = new System.Drawing.Size(227, 28);
            this.cmbMapas.TabIndex = 61;
            this.cmbMapas.SelectedIndexChanged += new System.EventHandler(this.cmbMapas_SelectedIndexChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(335, 268);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(121, 38);
            this.BtnLimpiar.TabIndex = 62;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(744, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tarifa:";
            // 
            // numCostoEnvio
            // 
            this.numCostoEnvio.DecimalPlaces = 2;
            this.numCostoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCostoEnvio.Location = new System.Drawing.Point(748, 114);
            this.numCostoEnvio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCostoEnvio.Name = "numCostoEnvio";
            this.numCostoEnvio.Size = new System.Drawing.Size(170, 28);
            this.numCostoEnvio.TabIndex = 64;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(477, 268);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(159, 39);
            this.BtnGuardar.TabIndex = 69;
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
            this.BtnBuscar.Location = new System.Drawing.Point(199, 266);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(121, 38);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 753);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.numCostoEnvio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.cmbMapas);
            this.Controls.Add(this.GpMap);
            this.Controls.Add(this.btnCancelarDireccion);
            this.Controls.Add(this.LabelVista);
            this.Controls.Add(this.CBCoordendadas);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccionOficial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccionProporcionada);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CBCoordendadas;
        private System.Windows.Forms.Label LabelVista;
        private System.Windows.Forms.Button btnCancelarDireccion;
        private System.Windows.Forms.GroupBox GpMap;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.ComboBox cmbMapas;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDireccionProporcionada;
        public System.Windows.Forms.TextBox txtDireccionOficial;
        public System.Windows.Forms.TextBox txtLongitud;
        public System.Windows.Forms.TextBox txtLatitud;
        public System.Windows.Forms.NumericUpDown numCostoEnvio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
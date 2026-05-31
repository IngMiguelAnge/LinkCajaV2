namespace LinkCajaV2.Configurations
{
    partial class Impressions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impressions));
            this.lblImpresiones = new System.Windows.Forms.Label();
            this.CBImpresiones = new System.Windows.Forms.ComboBox();
            this.lblPagina = new System.Windows.Forms.Label();
            this.CBPagina = new System.Windows.Forms.ComboBox();
            this.lblSizeLetra = new System.Windows.Forms.Label();
            this.NUDSizeLetra = new System.Windows.Forms.NumericUpDown();
            this.lblEstiloLetra = new System.Windows.Forms.Label();
            this.CBEstilo = new System.Windows.Forms.ComboBox();
            this.lblColorLetra = new System.Windows.Forms.Label();
            this.CBColorLetra = new System.Windows.Forms.ComboBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.CBModificar = new System.Windows.Forms.ComboBox();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.NUDEspacio = new System.Windows.Forms.NumericUpDown();
            this.lblAlineacion = new System.Windows.Forms.Label();
            this.CBAlineacion = new System.Windows.Forms.ComboBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.NUDAncho = new System.Windows.Forms.NumericUpDown();
            this.CBColorLinea = new System.Windows.Forms.ComboBox();
            this.lblColorLinea = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblAlturalinea = new System.Windows.Forms.Label();
            this.NUDHightLine = new System.Windows.Forms.NumericUpDown();
            this.lblAMilimetros = new System.Windows.Forms.Label();
            this.NUDAMilimetros = new System.Windows.Forms.NumericUpDown();
            this.lblAMilemetros = new System.Windows.Forms.Label();
            this.NUDALMilimetros = new System.Windows.Forms.NumericUpDown();
            this.GBMPagina = new System.Windows.Forms.GroupBox();
            this.GBLetras = new System.Windows.Forms.GroupBox();
            this.GBCuadros = new System.Windows.Forms.GroupBox();
            this.GBLinea = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.CBImprimir = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GBUnidos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSizeLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEspacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAMilimetros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDALMilimetros)).BeginInit();
            this.GBMPagina.SuspendLayout();
            this.GBLetras.SuspendLayout();
            this.GBCuadros.SuspendLayout();
            this.GBLinea.SuspendLayout();
            this.GBUnidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImpresiones
            // 
            this.lblImpresiones.AutoSize = true;
            this.lblImpresiones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblImpresiones.Location = new System.Drawing.Point(35, 100);
            this.lblImpresiones.Name = "lblImpresiones";
            this.lblImpresiones.Size = new System.Drawing.Size(198, 25);
            this.lblImpresiones.TabIndex = 0;
            this.lblImpresiones.Text = "Configurar Impresión:";
            // 
            // CBImpresiones
            // 
            this.CBImpresiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImpresiones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBImpresiones.FormattingEnabled = true;
            this.CBImpresiones.Location = new System.Drawing.Point(35, 135);
            this.CBImpresiones.Name = "CBImpresiones";
            this.CBImpresiones.Size = new System.Drawing.Size(260, 38);
            this.CBImpresiones.TabIndex = 1;
            this.CBImpresiones.SelectedIndexChanged += new System.EventHandler(this.CBImpresiones_SelectedIndexChanged);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblPagina.Location = new System.Drawing.Point(35, 200);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(123, 25);
            this.lblPagina.TabIndex = 2;
            this.lblPagina.Text = "Tipo de hoja:";
            // 
            // CBPagina
            // 
            this.CBPagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPagina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPagina.FormattingEnabled = true;
            this.CBPagina.Location = new System.Drawing.Point(35, 235);
            this.CBPagina.Name = "CBPagina";
            this.CBPagina.Size = new System.Drawing.Size(260, 38);
            this.CBPagina.TabIndex = 3;
            this.CBPagina.SelectedIndexChanged += new System.EventHandler(this.CBPagina_SelectedIndexChanged);
            // 
            // lblSizeLetra
            // 
            this.lblSizeLetra.AutoSize = true;
            this.lblSizeLetra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSizeLetra.Location = new System.Drawing.Point(20, 45);
            this.lblSizeLetra.Name = "lblSizeLetra";
            this.lblSizeLetra.Size = new System.Drawing.Size(154, 25);
            this.lblSizeLetra.TabIndex = 5;
            this.lblSizeLetra.Text = "Tamaño de letra:";
            // 
            // NUDSizeLetra
            // 
            this.NUDSizeLetra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSizeLetra.Location = new System.Drawing.Point(25, 75);
            this.NUDSizeLetra.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDSizeLetra.Name = "NUDSizeLetra";
            this.NUDSizeLetra.Size = new System.Drawing.Size(250, 37);
            this.NUDSizeLetra.TabIndex = 6;
            // 
            // lblEstiloLetra
            // 
            this.lblEstiloLetra.AutoSize = true;
            this.lblEstiloLetra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiloLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEstiloLetra.Location = new System.Drawing.Point(20, 130);
            this.lblEstiloLetra.Name = "lblEstiloLetra";
            this.lblEstiloLetra.Size = new System.Drawing.Size(133, 25);
            this.lblEstiloLetra.TabIndex = 7;
            this.lblEstiloLetra.Text = "Estilo de letra:";
            // 
            // CBEstilo
            // 
            this.CBEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstilo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstilo.FormattingEnabled = true;
            this.CBEstilo.Location = new System.Drawing.Point(25, 160);
            this.CBEstilo.Name = "CBEstilo";
            this.CBEstilo.Size = new System.Drawing.Size(250, 38);
            this.CBEstilo.TabIndex = 8;
            // 
            // lblColorLetra
            // 
            this.lblColorLetra.AutoSize = true;
            this.lblColorLetra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblColorLetra.Location = new System.Drawing.Point(20, 215);
            this.lblColorLetra.Name = "lblColorLetra";
            this.lblColorLetra.Size = new System.Drawing.Size(132, 25);
            this.lblColorLetra.TabIndex = 9;
            this.lblColorLetra.Text = "Color de letra:";
            // 
            // CBColorLetra
            // 
            this.CBColorLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorLetra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBColorLetra.FormattingEnabled = true;
            this.CBColorLetra.Location = new System.Drawing.Point(25, 245);
            this.CBColorLetra.Name = "CBColorLetra";
            this.CBColorLetra.Size = new System.Drawing.Size(250, 38);
            this.CBColorLetra.TabIndex = 10;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblModificar.Location = new System.Drawing.Point(35, 300);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(100, 25);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.Text = "Modificar:";
            // 
            // CBModificar
            // 
            this.CBModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModificar.FormattingEnabled = true;
            this.CBModificar.Location = new System.Drawing.Point(35, 335);
            this.CBModificar.Name = "CBModificar";
            this.CBModificar.Size = new System.Drawing.Size(260, 38);
            this.CBModificar.TabIndex = 12;
            this.CBModificar.SelectedIndexChanged += new System.EventHandler(this.CBModificar_SelectedIndexChanged);
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEspacio.Location = new System.Drawing.Point(20, 45);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(220, 25);
            this.lblEspacio.TabIndex = 13;
            this.lblEspacio.Text = "Espacio entre recuadros:";
            // 
            // NUDEspacio
            // 
            this.NUDEspacio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEspacio.Location = new System.Drawing.Point(25, 75);
            this.NUDEspacio.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDEspacio.Name = "NUDEspacio";
            this.NUDEspacio.Size = new System.Drawing.Size(250, 37);
            this.NUDEspacio.TabIndex = 14;
            // 
            // lblAlineacion
            // 
            this.lblAlineacion.AutoSize = true;
            this.lblAlineacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlineacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAlineacion.Location = new System.Drawing.Point(20, 130);
            this.lblAlineacion.Name = "lblAlineacion";
            this.lblAlineacion.Size = new System.Drawing.Size(107, 25);
            this.lblAlineacion.TabIndex = 15;
            this.lblAlineacion.Text = "Alineación:";
            // 
            // CBAlineacion
            // 
            this.CBAlineacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAlineacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAlineacion.FormattingEnabled = true;
            this.CBAlineacion.Location = new System.Drawing.Point(25, 160);
            this.CBAlineacion.Name = "CBAlineacion";
            this.CBAlineacion.Size = new System.Drawing.Size(250, 38);
            this.CBAlineacion.TabIndex = 16;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAncho.Location = new System.Drawing.Point(20, 215);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(179, 25);
            this.lblAncho.TabIndex = 17;
            this.lblAncho.Text = "Ancho de recuadro:";
            // 
            // NUDAncho
            // 
            this.NUDAncho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAncho.Location = new System.Drawing.Point(25, 245);
            this.NUDAncho.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NUDAncho.Name = "NUDAncho";
            this.NUDAncho.Size = new System.Drawing.Size(250, 37);
            this.NUDAncho.TabIndex = 18;
            // 
            // CBColorLinea
            // 
            this.CBColorLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorLinea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBColorLinea.FormattingEnabled = true;
            this.CBColorLinea.Location = new System.Drawing.Point(25, 160);
            this.CBColorLinea.Name = "CBColorLinea";
            this.CBColorLinea.Size = new System.Drawing.Size(250, 38);
            this.CBColorLinea.TabIndex = 20;
            // 
            // lblColorLinea
            // 
            this.lblColorLinea.AutoSize = true;
            this.lblColorLinea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorLinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblColorLinea.Location = new System.Drawing.Point(20, 130);
            this.lblColorLinea.Name = "lblColorLinea";
            this.lblColorLinea.Size = new System.Drawing.Size(134, 25);
            this.lblColorLinea.TabIndex = 19;
            this.lblColorLinea.Text = "Color de linea:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(497, 475);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(200, 48);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "  GUARDAR";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblAlturalinea
            // 
            this.lblAlturalinea.AutoSize = true;
            this.lblAlturalinea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturalinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAlturalinea.Location = new System.Drawing.Point(20, 45);
            this.lblAlturalinea.Name = "lblAlturalinea";
            this.lblAlturalinea.Size = new System.Drawing.Size(142, 25);
            this.lblAlturalinea.TabIndex = 22;
            this.lblAlturalinea.Text = "Altura de linea:";
            // 
            // NUDHightLine
            // 
            this.NUDHightLine.DecimalPlaces = 2;
            this.NUDHightLine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHightLine.Location = new System.Drawing.Point(25, 75);
            this.NUDHightLine.Name = "NUDHightLine";
            this.NUDHightLine.Size = new System.Drawing.Size(250, 37);
            this.NUDHightLine.TabIndex = 23;
            // 
            // lblAMilimetros
            // 
            this.lblAMilimetros.AutoSize = true;
            this.lblAMilimetros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMilimetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAMilimetros.Location = new System.Drawing.Point(25, 45);
            this.lblAMilimetros.Name = "lblAMilimetros";
            this.lblAMilimetros.Size = new System.Drawing.Size(72, 25);
            this.lblAMilimetros.TabIndex = 24;
            this.lblAMilimetros.Text = "Ancho:";
            // 
            // NUDAMilimetros
            // 
            this.NUDAMilimetros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAMilimetros.Location = new System.Drawing.Point(30, 75);
            this.NUDAMilimetros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDAMilimetros.Name = "NUDAMilimetros";
            this.NUDAMilimetros.Size = new System.Drawing.Size(250, 37);
            this.NUDAMilimetros.TabIndex = 25;
            // 
            // lblAMilemetros
            // 
            this.lblAMilemetros.AutoSize = true;
            this.lblAMilemetros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMilemetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAMilemetros.Location = new System.Drawing.Point(25, 140);
            this.lblAMilemetros.Name = "lblAMilemetros";
            this.lblAMilemetros.Size = new System.Drawing.Size(53, 25);
            this.lblAMilemetros.TabIndex = 26;
            this.lblAMilemetros.Text = "Alto:";
            // 
            // NUDALMilimetros
            // 
            this.NUDALMilimetros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDALMilimetros.Location = new System.Drawing.Point(30, 170);
            this.NUDALMilimetros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDALMilimetros.Name = "NUDALMilimetros";
            this.NUDALMilimetros.Size = new System.Drawing.Size(250, 37);
            this.NUDALMilimetros.TabIndex = 27;
            // 
            // GBMPagina
            // 
            this.GBMPagina.Controls.Add(this.NUDAMilimetros);
            this.GBMPagina.Controls.Add(this.NUDALMilimetros);
            this.GBMPagina.Controls.Add(this.lblAMilimetros);
            this.GBMPagina.Controls.Add(this.lblAMilemetros);
            this.GBMPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBMPagina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBMPagina.Location = new System.Drawing.Point(350, 100);
            this.GBMPagina.Name = "GBMPagina";
            this.GBMPagina.Size = new System.Drawing.Size(350, 275);
            this.GBMPagina.TabIndex = 28;
            this.GBMPagina.TabStop = false;
            this.GBMPagina.Text = "Medidas de página";
            this.GBMPagina.Visible = false;
            // 
            // GBLetras
            // 
            this.GBLetras.Controls.Add(this.NUDSizeLetra);
            this.GBLetras.Controls.Add(this.lblSizeLetra);
            this.GBLetras.Controls.Add(this.lblEstiloLetra);
            this.GBLetras.Controls.Add(this.CBEstilo);
            this.GBLetras.Controls.Add(this.lblColorLetra);
            this.GBLetras.Controls.Add(this.CBColorLetra);
            this.GBLetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBLetras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBLetras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBLetras.Location = new System.Drawing.Point(0, 0);
            this.GBLetras.Name = "GBLetras";
            this.GBLetras.Size = new System.Drawing.Size(350, 352);
            this.GBLetras.TabIndex = 29;
            this.GBLetras.TabStop = false;
            this.GBLetras.Text = "Estilo de letras";
            this.GBLetras.Visible = false;
            // 
            // GBCuadros
            // 
            this.GBCuadros.Controls.Add(this.NUDAncho);
            this.GBCuadros.Controls.Add(this.lblEspacio);
            this.GBCuadros.Controls.Add(this.NUDEspacio);
            this.GBCuadros.Controls.Add(this.lblAlineacion);
            this.GBCuadros.Controls.Add(this.CBAlineacion);
            this.GBCuadros.Controls.Add(this.lblAncho);
            this.GBCuadros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCuadros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBCuadros.Location = new System.Drawing.Point(0, 0);
            this.GBCuadros.Name = "GBCuadros";
            this.GBCuadros.Size = new System.Drawing.Size(350, 300);
            this.GBCuadros.TabIndex = 30;
            this.GBCuadros.TabStop = false;
            this.GBCuadros.Text = "Estilo de cuadros";
            this.GBCuadros.Visible = false;
            // 
            // GBLinea
            // 
            this.GBLinea.Controls.Add(this.lblColorLinea);
            this.GBLinea.Controls.Add(this.CBColorLinea);
            this.GBLinea.Controls.Add(this.lblAlturalinea);
            this.GBLinea.Controls.Add(this.NUDHightLine);
            this.GBLinea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBLinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBLinea.Location = new System.Drawing.Point(0, 0);
            this.GBLinea.Name = "GBLinea";
            this.GBLinea.Size = new System.Drawing.Size(350, 275);
            this.GBLinea.TabIndex = 31;
            this.GBLinea.TabStop = false;
            this.GBLinea.Text = "Estilo de linea";
            this.GBLinea.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(277, 475);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 48);
            this.btnImprimir.TabIndex = 32;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // CBImprimir
            // 
            this.CBImprimir.AutoSize = true;
            this.CBImprimir.Checked = true;
            this.CBImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBImprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.CBImprimir.Location = new System.Drawing.Point(40, 491);
            this.CBImprimir.Name = "CBImprimir";
            this.CBImprimir.Size = new System.Drawing.Size(215, 32);
            this.CBImprimir.TabIndex = 28;
            this.CBImprimir.Text = "¿Imprimir el ticket?";
            this.CBImprimir.UseVisualStyleBackColor = true;
            this.CBImprimir.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(487, 48);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Configuración de impresión";
            // 
            // GBUnidos
            // 
            this.GBUnidos.Controls.Add(this.GBLetras);
            this.GBUnidos.Controls.Add(this.GBCuadros);
            this.GBUnidos.Controls.Add(this.GBLinea);
            this.GBUnidos.Location = new System.Drawing.Point(350, 100);
            this.GBUnidos.Name = "GBUnidos";
            this.GBUnidos.Size = new System.Drawing.Size(350, 301);
            this.GBUnidos.TabIndex = 34;
            this.GBUnidos.TabStop = false;
            // 
            // Impressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 555);
            this.Controls.Add(this.GBUnidos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.CBImprimir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GBMPagina);
            this.Controls.Add(this.CBModificar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.CBPagina);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.CBImpresiones);
            this.Controls.Add(this.lblImpresiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Impressions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Impressions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDSizeLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEspacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAMilimetros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDALMilimetros)).EndInit();
            this.GBMPagina.ResumeLayout(false);
            this.GBMPagina.PerformLayout();
            this.GBLetras.ResumeLayout(false);
            this.GBLetras.PerformLayout();
            this.GBCuadros.ResumeLayout(false);
            this.GBCuadros.PerformLayout();
            this.GBLinea.ResumeLayout(false);
            this.GBLinea.PerformLayout();
            this.GBUnidos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImpresiones;
        private System.Windows.Forms.ComboBox CBImpresiones;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.ComboBox CBPagina;
        private System.Windows.Forms.Label lblSizeLetra;
        private System.Windows.Forms.NumericUpDown NUDSizeLetra;
        private System.Windows.Forms.Label lblEstiloLetra;
        private System.Windows.Forms.ComboBox CBEstilo;
        private System.Windows.Forms.Label lblColorLetra;
        private System.Windows.Forms.ComboBox CBColorLetra;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.ComboBox CBModificar;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.NumericUpDown NUDEspacio;
        private System.Windows.Forms.Label lblAlineacion;
        private System.Windows.Forms.ComboBox CBAlineacion;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.NumericUpDown NUDAncho;
        private System.Windows.Forms.ComboBox CBColorLinea;
        private System.Windows.Forms.Label lblColorLinea;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblAlturalinea;
        private System.Windows.Forms.NumericUpDown NUDHightLine;
        private System.Windows.Forms.Label lblAMilimetros;
        private System.Windows.Forms.NumericUpDown NUDAMilimetros;
        private System.Windows.Forms.Label lblAMilemetros;
        private System.Windows.Forms.NumericUpDown NUDALMilimetros;
        private System.Windows.Forms.GroupBox GBMPagina;
        private System.Windows.Forms.GroupBox GBLetras;
        private System.Windows.Forms.GroupBox GBCuadros;
        private System.Windows.Forms.GroupBox GBLinea;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.CheckBox CBImprimir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GBUnidos;
    }
}
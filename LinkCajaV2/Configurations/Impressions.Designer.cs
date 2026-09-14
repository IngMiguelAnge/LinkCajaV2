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
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.nudCaracteres = new System.Windows.Forms.NumericUpDown();
            this.GBCuadros = new System.Windows.Forms.GroupBox();
            this.GBLinea = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cbTicketAutomatico = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GBUnidos = new System.Windows.Forms.GroupBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.cbPosicionPrecio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSizeLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEspacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAMilimetros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDALMilimetros)).BeginInit();
            this.GBMPagina.SuspendLayout();
            this.GBLetras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaracteres)).BeginInit();
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
            this.lblImpresiones.Location = new System.Drawing.Point(23, 65);
            this.lblImpresiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpresiones.Name = "lblImpresiones";
            this.lblImpresiones.Size = new System.Drawing.Size(128, 15);
            this.lblImpresiones.TabIndex = 0;
            this.lblImpresiones.Text = "Configurar Impresión:";
            // 
            // CBImpresiones
            // 
            this.CBImpresiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImpresiones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBImpresiones.FormattingEnabled = true;
            this.CBImpresiones.Location = new System.Drawing.Point(23, 88);
            this.CBImpresiones.Margin = new System.Windows.Forms.Padding(2);
            this.CBImpresiones.Name = "CBImpresiones";
            this.CBImpresiones.Size = new System.Drawing.Size(175, 28);
            this.CBImpresiones.TabIndex = 1;
            this.CBImpresiones.SelectedIndexChanged += new System.EventHandler(this.CBImpresiones_SelectedIndexChanged);
            // 
            // lblSizeLetra
            // 
            this.lblSizeLetra.AutoSize = true;
            this.lblSizeLetra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSizeLetra.Location = new System.Drawing.Point(13, 29);
            this.lblSizeLetra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSizeLetra.Name = "lblSizeLetra";
            this.lblSizeLetra.Size = new System.Drawing.Size(99, 15);
            this.lblSizeLetra.TabIndex = 5;
            this.lblSizeLetra.Text = "Tamaño de letra:";
            // 
            // NUDSizeLetra
            // 
            this.NUDSizeLetra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSizeLetra.Location = new System.Drawing.Point(17, 49);
            this.NUDSizeLetra.Margin = new System.Windows.Forms.Padding(2);
            this.NUDSizeLetra.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDSizeLetra.Name = "NUDSizeLetra";
            this.NUDSizeLetra.Size = new System.Drawing.Size(167, 27);
            this.NUDSizeLetra.TabIndex = 6;
            // 
            // lblEstiloLetra
            // 
            this.lblEstiloLetra.AutoSize = true;
            this.lblEstiloLetra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiloLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEstiloLetra.Location = new System.Drawing.Point(13, 84);
            this.lblEstiloLetra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstiloLetra.Name = "lblEstiloLetra";
            this.lblEstiloLetra.Size = new System.Drawing.Size(85, 15);
            this.lblEstiloLetra.TabIndex = 7;
            this.lblEstiloLetra.Text = "Estilo de letra:";
            // 
            // CBEstilo
            // 
            this.CBEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstilo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstilo.FormattingEnabled = true;
            this.CBEstilo.Location = new System.Drawing.Point(17, 104);
            this.CBEstilo.Margin = new System.Windows.Forms.Padding(2);
            this.CBEstilo.Name = "CBEstilo";
            this.CBEstilo.Size = new System.Drawing.Size(168, 28);
            this.CBEstilo.TabIndex = 8;
            // 
            // lblColorLetra
            // 
            this.lblColorLetra.AutoSize = true;
            this.lblColorLetra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblColorLetra.Location = new System.Drawing.Point(13, 140);
            this.lblColorLetra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorLetra.Name = "lblColorLetra";
            this.lblColorLetra.Size = new System.Drawing.Size(85, 15);
            this.lblColorLetra.TabIndex = 9;
            this.lblColorLetra.Text = "Color de letra:";
            // 
            // CBColorLetra
            // 
            this.CBColorLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorLetra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBColorLetra.FormattingEnabled = true;
            this.CBColorLetra.Location = new System.Drawing.Point(17, 159);
            this.CBColorLetra.Margin = new System.Windows.Forms.Padding(2);
            this.CBColorLetra.Name = "CBColorLetra";
            this.CBColorLetra.Size = new System.Drawing.Size(168, 28);
            this.CBColorLetra.TabIndex = 10;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblModificar.Location = new System.Drawing.Point(23, 120);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(63, 15);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.Text = "Modificar:";
            // 
            // CBModificar
            // 
            this.CBModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModificar.FormattingEnabled = true;
            this.CBModificar.Location = new System.Drawing.Point(23, 143);
            this.CBModificar.Margin = new System.Windows.Forms.Padding(2);
            this.CBModificar.Name = "CBModificar";
            this.CBModificar.Size = new System.Drawing.Size(175, 28);
            this.CBModificar.TabIndex = 12;
            this.CBModificar.SelectedIndexChanged += new System.EventHandler(this.CBModificar_SelectedIndexChanged);
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEspacio.Location = new System.Drawing.Point(13, 29);
            this.lblEspacio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(142, 15);
            this.lblEspacio.TabIndex = 13;
            this.lblEspacio.Text = "Espacio entre recuadros:";
            // 
            // NUDEspacio
            // 
            this.NUDEspacio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEspacio.Location = new System.Drawing.Point(17, 49);
            this.NUDEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.NUDEspacio.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDEspacio.Name = "NUDEspacio";
            this.NUDEspacio.Size = new System.Drawing.Size(167, 27);
            this.NUDEspacio.TabIndex = 14;
            // 
            // lblAlineacion
            // 
            this.lblAlineacion.AutoSize = true;
            this.lblAlineacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlineacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAlineacion.Location = new System.Drawing.Point(13, 84);
            this.lblAlineacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlineacion.Name = "lblAlineacion";
            this.lblAlineacion.Size = new System.Drawing.Size(67, 15);
            this.lblAlineacion.TabIndex = 15;
            this.lblAlineacion.Text = "Alineación:";
            // 
            // CBAlineacion
            // 
            this.CBAlineacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAlineacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAlineacion.FormattingEnabled = true;
            this.CBAlineacion.Location = new System.Drawing.Point(17, 104);
            this.CBAlineacion.Margin = new System.Windows.Forms.Padding(2);
            this.CBAlineacion.Name = "CBAlineacion";
            this.CBAlineacion.Size = new System.Drawing.Size(168, 28);
            this.CBAlineacion.TabIndex = 16;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAncho.Location = new System.Drawing.Point(13, 140);
            this.lblAncho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(115, 15);
            this.lblAncho.TabIndex = 17;
            this.lblAncho.Text = "Ancho de recuadro:";
            // 
            // NUDAncho
            // 
            this.NUDAncho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAncho.Location = new System.Drawing.Point(17, 159);
            this.NUDAncho.Margin = new System.Windows.Forms.Padding(2);
            this.NUDAncho.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NUDAncho.Name = "NUDAncho";
            this.NUDAncho.Size = new System.Drawing.Size(167, 27);
            this.NUDAncho.TabIndex = 18;
            // 
            // CBColorLinea
            // 
            this.CBColorLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorLinea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBColorLinea.FormattingEnabled = true;
            this.CBColorLinea.Location = new System.Drawing.Point(17, 104);
            this.CBColorLinea.Margin = new System.Windows.Forms.Padding(2);
            this.CBColorLinea.Name = "CBColorLinea";
            this.CBColorLinea.Size = new System.Drawing.Size(168, 28);
            this.CBColorLinea.TabIndex = 20;
            // 
            // lblColorLinea
            // 
            this.lblColorLinea.AutoSize = true;
            this.lblColorLinea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorLinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblColorLinea.Location = new System.Drawing.Point(13, 84);
            this.lblColorLinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorLinea.Name = "lblColorLinea";
            this.lblColorLinea.Size = new System.Drawing.Size(85, 15);
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
            this.BtnGuardar.Location = new System.Drawing.Point(331, 346);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(133, 31);
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
            this.lblAlturalinea.Location = new System.Drawing.Point(13, 29);
            this.lblAlturalinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlturalinea.Name = "lblAlturalinea";
            this.lblAlturalinea.Size = new System.Drawing.Size(90, 15);
            this.lblAlturalinea.TabIndex = 22;
            this.lblAlturalinea.Text = "Altura de linea:";
            // 
            // NUDHightLine
            // 
            this.NUDHightLine.DecimalPlaces = 2;
            this.NUDHightLine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHightLine.Location = new System.Drawing.Point(17, 49);
            this.NUDHightLine.Margin = new System.Windows.Forms.Padding(2);
            this.NUDHightLine.Name = "NUDHightLine";
            this.NUDHightLine.Size = new System.Drawing.Size(167, 27);
            this.NUDHightLine.TabIndex = 23;
            // 
            // lblAMilimetros
            // 
            this.lblAMilimetros.AutoSize = true;
            this.lblAMilimetros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMilimetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAMilimetros.Location = new System.Drawing.Point(17, 29);
            this.lblAMilimetros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAMilimetros.Name = "lblAMilimetros";
            this.lblAMilimetros.Size = new System.Drawing.Size(45, 15);
            this.lblAMilimetros.TabIndex = 24;
            this.lblAMilimetros.Text = "Ancho:";
            // 
            // NUDAMilimetros
            // 
            this.NUDAMilimetros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAMilimetros.Location = new System.Drawing.Point(20, 49);
            this.NUDAMilimetros.Margin = new System.Windows.Forms.Padding(2);
            this.NUDAMilimetros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDAMilimetros.Name = "NUDAMilimetros";
            this.NUDAMilimetros.Size = new System.Drawing.Size(167, 27);
            this.NUDAMilimetros.TabIndex = 25;
            // 
            // lblAMilemetros
            // 
            this.lblAMilemetros.AutoSize = true;
            this.lblAMilemetros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMilemetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAMilemetros.Location = new System.Drawing.Point(17, 91);
            this.lblAMilemetros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAMilemetros.Name = "lblAMilemetros";
            this.lblAMilemetros.Size = new System.Drawing.Size(33, 15);
            this.lblAMilemetros.TabIndex = 26;
            this.lblAMilemetros.Text = "Alto:";
            // 
            // NUDALMilimetros
            // 
            this.NUDALMilimetros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDALMilimetros.Location = new System.Drawing.Point(20, 110);
            this.NUDALMilimetros.Margin = new System.Windows.Forms.Padding(2);
            this.NUDALMilimetros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDALMilimetros.Name = "NUDALMilimetros";
            this.NUDALMilimetros.Size = new System.Drawing.Size(167, 27);
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
            this.GBMPagina.Location = new System.Drawing.Point(233, 65);
            this.GBMPagina.Margin = new System.Windows.Forms.Padding(2);
            this.GBMPagina.Name = "GBMPagina";
            this.GBMPagina.Padding = new System.Windows.Forms.Padding(2);
            this.GBMPagina.Size = new System.Drawing.Size(233, 179);
            this.GBMPagina.TabIndex = 28;
            this.GBMPagina.TabStop = false;
            this.GBMPagina.Text = "Medidas de etiqueta ";
            this.GBMPagina.Visible = false;
            // 
            // GBLetras
            // 
            this.GBLetras.Controls.Add(this.NUDSizeLetra);
            this.GBLetras.Controls.Add(this.lblCaracteres);
            this.GBLetras.Controls.Add(this.nudCaracteres);
            this.GBLetras.Controls.Add(this.lblSizeLetra);
            this.GBLetras.Controls.Add(this.lblEstiloLetra);
            this.GBLetras.Controls.Add(this.CBEstilo);
            this.GBLetras.Controls.Add(this.lblColorLetra);
            this.GBLetras.Controls.Add(this.CBColorLetra);
            this.GBLetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBLetras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBLetras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBLetras.Location = new System.Drawing.Point(231, 49);
            this.GBLetras.Margin = new System.Windows.Forms.Padding(2);
            this.GBLetras.Name = "GBLetras";
            this.GBLetras.Padding = new System.Windows.Forms.Padding(2);
            this.GBLetras.Size = new System.Drawing.Size(233, 259);
            this.GBLetras.TabIndex = 29;
            this.GBLetras.TabStop = false;
            this.GBLetras.Text = "Estilo de letras";
            this.GBLetras.Visible = false;
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCaracteres.Location = new System.Drawing.Point(13, 189);
            this.lblCaracteres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(136, 15);
            this.lblCaracteres.TabIndex = 37;
            this.lblCaracteres.Text = "Cantidad de caracteres:";
            // 
            // nudCaracteres
            // 
            this.nudCaracteres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCaracteres.Location = new System.Drawing.Point(17, 207);
            this.nudCaracteres.Margin = new System.Windows.Forms.Padding(2);
            this.nudCaracteres.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCaracteres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCaracteres.Name = "nudCaracteres";
            this.nudCaracteres.Size = new System.Drawing.Size(167, 27);
            this.nudCaracteres.TabIndex = 36;
            this.nudCaracteres.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
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
            this.GBCuadros.Margin = new System.Windows.Forms.Padding(2);
            this.GBCuadros.Name = "GBCuadros";
            this.GBCuadros.Padding = new System.Windows.Forms.Padding(2);
            this.GBCuadros.Size = new System.Drawing.Size(233, 195);
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
            this.GBLinea.Margin = new System.Windows.Forms.Padding(2);
            this.GBLinea.Name = "GBLinea";
            this.GBLinea.Padding = new System.Windows.Forms.Padding(2);
            this.GBLinea.Size = new System.Drawing.Size(233, 179);
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
            this.btnImprimir.Location = new System.Drawing.Point(185, 346);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(133, 31);
            this.btnImprimir.TabIndex = 32;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cbTicketAutomatico
            // 
            this.cbTicketAutomatico.AutoSize = true;
            this.cbTicketAutomatico.Checked = true;
            this.cbTicketAutomatico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTicketAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTicketAutomatico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTicketAutomatico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.cbTicketAutomatico.Location = new System.Drawing.Point(23, 351);
            this.cbTicketAutomatico.Margin = new System.Windows.Forms.Padding(2);
            this.cbTicketAutomatico.Name = "cbTicketAutomatico";
            this.cbTicketAutomatico.Size = new System.Drawing.Size(157, 23);
            this.cbTicketAutomatico.TabIndex = 28;
            this.cbTicketAutomatico.Text = "¿Ticket automático?";
            this.cbTicketAutomatico.UseVisualStyleBackColor = true;
            this.cbTicketAutomatico.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 32);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Configuración de impresión";
            // 
            // GBUnidos
            // 
            this.GBUnidos.Controls.Add(this.GBCuadros);
            this.GBUnidos.Controls.Add(this.GBLinea);
            this.GBUnidos.Location = new System.Drawing.Point(233, 65);
            this.GBUnidos.Margin = new System.Windows.Forms.Padding(2);
            this.GBUnidos.Name = "GBUnidos";
            this.GBUnidos.Padding = new System.Windows.Forms.Padding(2);
            this.GBUnidos.Size = new System.Drawing.Size(233, 196);
            this.GBUnidos.TabIndex = 34;
            this.GBUnidos.TabStop = false;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblPosicion.Location = new System.Drawing.Point(23, 181);
            this.lblPosicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(113, 15);
            this.lblPosicion.TabIndex = 35;
            this.lblPosicion.Text = "Posición del precio:";
            // 
            // cbPosicionPrecio
            // 
            this.cbPosicionPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosicionPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosicionPrecio.FormattingEnabled = true;
            this.cbPosicionPrecio.Items.AddRange(new object[] {
            "Arriba",
            "Abajo"});
            this.cbPosicionPrecio.Location = new System.Drawing.Point(26, 205);
            this.cbPosicionPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosicionPrecio.Name = "cbPosicionPrecio";
            this.cbPosicionPrecio.Size = new System.Drawing.Size(175, 28);
            this.cbPosicionPrecio.TabIndex = 36;
            // 
            // Impressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 385);
            this.Controls.Add(this.cbPosicionPrecio);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.GBLetras);
            this.Controls.Add(this.GBUnidos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbTicketAutomatico);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GBMPagina);
            this.Controls.Add(this.CBModificar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.CBImpresiones);
            this.Controls.Add(this.lblImpresiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCaracteres)).EndInit();
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
        private System.Windows.Forms.CheckBox cbTicketAutomatico;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GBUnidos;
        private System.Windows.Forms.NumericUpDown nudCaracteres;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.ComboBox cbPosicionPrecio;
    }
}
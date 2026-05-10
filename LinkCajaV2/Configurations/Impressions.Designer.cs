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
            this.SuspendLayout();
            // 
            // lblImpresiones
            // 
            this.lblImpresiones.AutoSize = true;
            this.lblImpresiones.Location = new System.Drawing.Point(46, 23);
            this.lblImpresiones.Name = "lblImpresiones";
            this.lblImpresiones.Size = new System.Drawing.Size(161, 20);
            this.lblImpresiones.TabIndex = 0;
            this.lblImpresiones.Text = "Configurar Impresión:";
            // 
            // CBImpresiones
            // 
            this.CBImpresiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImpresiones.FormattingEnabled = true;
            this.CBImpresiones.Location = new System.Drawing.Point(50, 55);
            this.CBImpresiones.Name = "CBImpresiones";
            this.CBImpresiones.Size = new System.Drawing.Size(121, 28);
            this.CBImpresiones.TabIndex = 1;
            this.CBImpresiones.SelectedIndexChanged += new System.EventHandler(this.CBImpresiones_SelectedIndexChanged);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(247, 23);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(99, 20);
            this.lblPagina.TabIndex = 2;
            this.lblPagina.Text = "Tipo de hoja:";
            // 
            // CBPagina
            // 
            this.CBPagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPagina.FormattingEnabled = true;
            this.CBPagina.Location = new System.Drawing.Point(255, 55);
            this.CBPagina.Name = "CBPagina";
            this.CBPagina.Size = new System.Drawing.Size(121, 28);
            this.CBPagina.TabIndex = 3;
            this.CBPagina.SelectedIndexChanged += new System.EventHandler(this.CBPagina_SelectedIndexChanged);
            // 
            // lblSizeLetra
            // 
            this.lblSizeLetra.AutoSize = true;
            this.lblSizeLetra.Location = new System.Drawing.Point(11, 29);
            this.lblSizeLetra.Name = "lblSizeLetra";
            this.lblSizeLetra.Size = new System.Drawing.Size(128, 20);
            this.lblSizeLetra.TabIndex = 5;
            this.lblSizeLetra.Text = "Tamaño de letra:";
            // 
            // NUDSizeLetra
            // 
            this.NUDSizeLetra.Location = new System.Drawing.Point(15, 52);
            this.NUDSizeLetra.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDSizeLetra.Name = "NUDSizeLetra";
            this.NUDSizeLetra.Size = new System.Drawing.Size(124, 26);
            this.NUDSizeLetra.TabIndex = 6;
            // 
            // lblEstiloLetra
            // 
            this.lblEstiloLetra.AutoSize = true;
            this.lblEstiloLetra.Location = new System.Drawing.Point(206, 27);
            this.lblEstiloLetra.Name = "lblEstiloLetra";
            this.lblEstiloLetra.Size = new System.Drawing.Size(109, 20);
            this.lblEstiloLetra.TabIndex = 7;
            this.lblEstiloLetra.Text = "Estilo de letra:";
            // 
            // CBEstilo
            // 
            this.CBEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstilo.FormattingEnabled = true;
            this.CBEstilo.Location = new System.Drawing.Point(210, 50);
            this.CBEstilo.Name = "CBEstilo";
            this.CBEstilo.Size = new System.Drawing.Size(121, 28);
            this.CBEstilo.TabIndex = 8;
            // 
            // lblColorLetra
            // 
            this.lblColorLetra.AutoSize = true;
            this.lblColorLetra.Location = new System.Drawing.Point(362, 27);
            this.lblColorLetra.Name = "lblColorLetra";
            this.lblColorLetra.Size = new System.Drawing.Size(107, 20);
            this.lblColorLetra.TabIndex = 9;
            this.lblColorLetra.Text = "Color de letra:";
            // 
            // CBColorLetra
            // 
            this.CBColorLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorLetra.FormattingEnabled = true;
            this.CBColorLetra.Location = new System.Drawing.Point(366, 50);
            this.CBColorLetra.Name = "CBColorLetra";
            this.CBColorLetra.Size = new System.Drawing.Size(121, 28);
            this.CBColorLetra.TabIndex = 10;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(58, 208);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(77, 20);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.Text = "Modificar:";
            // 
            // CBModificar
            // 
            this.CBModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModificar.FormattingEnabled = true;
            this.CBModificar.Location = new System.Drawing.Point(56, 231);
            this.CBModificar.Name = "CBModificar";
            this.CBModificar.Size = new System.Drawing.Size(121, 28);
            this.CBModificar.TabIndex = 12;
            this.CBModificar.SelectedIndexChanged += new System.EventHandler(this.CBModificar_SelectedIndexChanged);
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Location = new System.Drawing.Point(11, 35);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(186, 20);
            this.lblEspacio.TabIndex = 13;
            this.lblEspacio.Text = "Espacio entre recuadros:";
            // 
            // NUDEspacio
            // 
            this.NUDEspacio.Location = new System.Drawing.Point(15, 68);
            this.NUDEspacio.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDEspacio.Name = "NUDEspacio";
            this.NUDEspacio.Size = new System.Drawing.Size(124, 26);
            this.NUDEspacio.TabIndex = 14;
            // 
            // lblAlineacion
            // 
            this.lblAlineacion.AutoSize = true;
            this.lblAlineacion.Location = new System.Drawing.Point(206, 42);
            this.lblAlineacion.Name = "lblAlineacion";
            this.lblAlineacion.Size = new System.Drawing.Size(86, 20);
            this.lblAlineacion.TabIndex = 15;
            this.lblAlineacion.Text = "Alineación:";
            // 
            // CBAlineacion
            // 
            this.CBAlineacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAlineacion.FormattingEnabled = true;
            this.CBAlineacion.Location = new System.Drawing.Point(210, 66);
            this.CBAlineacion.Name = "CBAlineacion";
            this.CBAlineacion.Size = new System.Drawing.Size(121, 28);
            this.CBAlineacion.TabIndex = 16;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(362, 41);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(148, 20);
            this.lblAncho.TabIndex = 17;
            this.lblAncho.Text = "Ancho de recuadro:";
            // 
            // NUDAncho
            // 
            this.NUDAncho.Location = new System.Drawing.Point(366, 66);
            this.NUDAncho.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NUDAncho.Name = "NUDAncho";
            this.NUDAncho.Size = new System.Drawing.Size(120, 26);
            this.NUDAncho.TabIndex = 18;
            // 
            // CBColorLinea
            // 
            this.CBColorLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorLinea.FormattingEnabled = true;
            this.CBColorLinea.Location = new System.Drawing.Point(208, 54);
            this.CBColorLinea.Name = "CBColorLinea";
            this.CBColorLinea.Size = new System.Drawing.Size(121, 28);
            this.CBColorLinea.TabIndex = 20;
            // 
            // lblColorLinea
            // 
            this.lblColorLinea.AutoSize = true;
            this.lblColorLinea.Location = new System.Drawing.Point(204, 31);
            this.lblColorLinea.Name = "lblColorLinea";
            this.lblColorLinea.Size = new System.Drawing.Size(109, 20);
            this.lblColorLinea.TabIndex = 19;
            this.lblColorLinea.Text = "Color de linea:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(41, 601);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(79, 42);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblAlturalinea
            // 
            this.lblAlturalinea.AutoSize = true;
            this.lblAlturalinea.Location = new System.Drawing.Point(12, 31);
            this.lblAlturalinea.Name = "lblAlturalinea";
            this.lblAlturalinea.Size = new System.Drawing.Size(114, 20);
            this.lblAlturalinea.TabIndex = 22;
            this.lblAlturalinea.Text = "Altura de linea:";
            // 
            // NUDHightLine
            // 
            this.NUDHightLine.DecimalPlaces = 2;
            this.NUDHightLine.Location = new System.Drawing.Point(17, 56);
            this.NUDHightLine.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDHightLine.Name = "NUDHightLine";
            this.NUDHightLine.Size = new System.Drawing.Size(120, 26);
            this.NUDHightLine.TabIndex = 23;
            // 
            // lblAMilimetros
            // 
            this.lblAMilimetros.AutoSize = true;
            this.lblAMilimetros.Location = new System.Drawing.Point(25, 24);
            this.lblAMilimetros.Name = "lblAMilimetros";
            this.lblAMilimetros.Size = new System.Drawing.Size(55, 20);
            this.lblAMilimetros.TabIndex = 24;
            this.lblAMilimetros.Text = "Ancho";
            // 
            // NUDAMilimetros
            // 
            this.NUDAMilimetros.Location = new System.Drawing.Point(29, 47);
            this.NUDAMilimetros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDAMilimetros.Name = "NUDAMilimetros";
            this.NUDAMilimetros.Size = new System.Drawing.Size(120, 26);
            this.NUDAMilimetros.TabIndex = 25;
            // 
            // lblAMilemetros
            // 
            this.lblAMilemetros.AutoSize = true;
            this.lblAMilemetros.Location = new System.Drawing.Point(224, 24);
            this.lblAMilemetros.Name = "lblAMilemetros";
            this.lblAMilemetros.Size = new System.Drawing.Size(37, 20);
            this.lblAMilemetros.TabIndex = 26;
            this.lblAMilemetros.Text = "Alto";
            // 
            // NUDALMilimetros
            // 
            this.NUDALMilimetros.Location = new System.Drawing.Point(229, 47);
            this.NUDALMilimetros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDALMilimetros.Name = "NUDALMilimetros";
            this.NUDALMilimetros.Size = new System.Drawing.Size(120, 26);
            this.NUDALMilimetros.TabIndex = 27;
            // 
            // GBMPagina
            // 
            this.GBMPagina.Controls.Add(this.NUDAMilimetros);
            this.GBMPagina.Controls.Add(this.NUDALMilimetros);
            this.GBMPagina.Controls.Add(this.lblAMilimetros);
            this.GBMPagina.Controls.Add(this.lblAMilemetros);
            this.GBMPagina.Location = new System.Drawing.Point(27, 103);
            this.GBMPagina.Name = "GBMPagina";
            this.GBMPagina.Size = new System.Drawing.Size(425, 88);
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
            this.GBLetras.Location = new System.Drawing.Point(41, 283);
            this.GBLetras.Name = "GBLetras";
            this.GBLetras.Size = new System.Drawing.Size(530, 86);
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
            this.GBCuadros.Location = new System.Drawing.Point(41, 375);
            this.GBCuadros.Name = "GBCuadros";
            this.GBCuadros.Size = new System.Drawing.Size(557, 104);
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
            this.GBLinea.Location = new System.Drawing.Point(45, 485);
            this.GBLinea.Name = "GBLinea";
            this.GBLinea.Size = new System.Drawing.Size(497, 92);
            this.GBLinea.TabIndex = 31;
            this.GBLinea.TabStop = false;
            this.GBLinea.Text = "Estilo de linea";
            this.GBLinea.Visible = false;
            // 
            // Impressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 656);
            this.Controls.Add(this.GBLinea);
            this.Controls.Add(this.GBCuadros);
            this.Controls.Add(this.GBLetras);
            this.Controls.Add(this.GBMPagina);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBModificar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.CBPagina);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.CBImpresiones);
            this.Controls.Add(this.lblImpresiones);
            this.Name = "Impressions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresiones";
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
    }
}
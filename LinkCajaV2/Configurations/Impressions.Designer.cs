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
            this.lblGrosorLetra = new System.Windows.Forms.Label();
            this.CBGrosor = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.NUDSizeLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEspacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAncho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImpresiones
            // 
            this.lblImpresiones.AutoSize = true;
            this.lblImpresiones.Location = new System.Drawing.Point(37, 23);
            this.lblImpresiones.Name = "lblImpresiones";
            this.lblImpresiones.Size = new System.Drawing.Size(161, 20);
            this.lblImpresiones.TabIndex = 0;
            this.lblImpresiones.Text = "Configurar Impresión:";
            // 
            // CBImpresiones
            // 
            this.CBImpresiones.FormattingEnabled = true;
            this.CBImpresiones.Items.AddRange(new object[] {
            "Lista de precios"});
            this.CBImpresiones.Location = new System.Drawing.Point(41, 55);
            this.CBImpresiones.Name = "CBImpresiones";
            this.CBImpresiones.Size = new System.Drawing.Size(121, 28);
            this.CBImpresiones.TabIndex = 1;
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(232, 23);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(99, 20);
            this.lblPagina.TabIndex = 2;
            this.lblPagina.Text = "Tipo de hoja:";
            // 
            // CBPagina
            // 
            this.CBPagina.FormattingEnabled = true;
            this.CBPagina.Location = new System.Drawing.Point(236, 55);
            this.CBPagina.Name = "CBPagina";
            this.CBPagina.Size = new System.Drawing.Size(121, 28);
            this.CBPagina.TabIndex = 3;
            // 
            // lblSizeLetra
            // 
            this.lblSizeLetra.AutoSize = true;
            this.lblSizeLetra.Location = new System.Drawing.Point(37, 94);
            this.lblSizeLetra.Name = "lblSizeLetra";
            this.lblSizeLetra.Size = new System.Drawing.Size(128, 20);
            this.lblSizeLetra.TabIndex = 5;
            this.lblSizeLetra.Text = "Tamaño de letra:";
            // 
            // NUDSizeLetra
            // 
            this.NUDSizeLetra.Location = new System.Drawing.Point(41, 117);
            this.NUDSizeLetra.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDSizeLetra.Name = "NUDSizeLetra";
            this.NUDSizeLetra.Size = new System.Drawing.Size(124, 26);
            this.NUDSizeLetra.TabIndex = 6;
            // 
            // lblGrosorLetra
            // 
            this.lblGrosorLetra.AutoSize = true;
            this.lblGrosorLetra.Location = new System.Drawing.Point(206, 94);
            this.lblGrosorLetra.Name = "lblGrosorLetra";
            this.lblGrosorLetra.Size = new System.Drawing.Size(119, 20);
            this.lblGrosorLetra.TabIndex = 7;
            this.lblGrosorLetra.Text = "Grosor de letra:";
            // 
            // CBGrosor
            // 
            this.CBGrosor.FormattingEnabled = true;
            this.CBGrosor.Items.AddRange(new object[] {
            "Normal",
            "Medium",
            "SemiBold",
            "Bold"});
            this.CBGrosor.Location = new System.Drawing.Point(210, 117);
            this.CBGrosor.Name = "CBGrosor";
            this.CBGrosor.Size = new System.Drawing.Size(121, 28);
            this.CBGrosor.TabIndex = 8;
            // 
            // lblColorLetra
            // 
            this.lblColorLetra.AutoSize = true;
            this.lblColorLetra.Location = new System.Drawing.Point(349, 94);
            this.lblColorLetra.Name = "lblColorLetra";
            this.lblColorLetra.Size = new System.Drawing.Size(107, 20);
            this.lblColorLetra.TabIndex = 9;
            this.lblColorLetra.Text = "Color de letra:";
            // 
            // CBColorLetra
            // 
            this.CBColorLetra.FormattingEnabled = true;
            this.CBColorLetra.Items.AddRange(new object[] {
            "Negro",
            "Rojo",
            "Azul",
            "Verde"});
            this.CBColorLetra.Location = new System.Drawing.Point(353, 117);
            this.CBColorLetra.Name = "CBColorLetra";
            this.CBColorLetra.Size = new System.Drawing.Size(121, 28);
            this.CBColorLetra.TabIndex = 10;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(389, 23);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(77, 20);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.Text = "Modificar:";
            // 
            // CBModificar
            // 
            this.CBModificar.FormattingEnabled = true;
            this.CBModificar.Items.AddRange(new object[] {
            "Titulo",
            "Fecha",
            "Articulos",
            "Precios",
            "Recuadro"});
            this.CBModificar.Location = new System.Drawing.Point(393, 55);
            this.CBModificar.Name = "CBModificar";
            this.CBModificar.Size = new System.Drawing.Size(121, 28);
            this.CBModificar.TabIndex = 12;
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Location = new System.Drawing.Point(37, 169);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(186, 20);
            this.lblEspacio.TabIndex = 13;
            this.lblEspacio.Text = "Espacio entre recuadros:";
            // 
            // NUDEspacio
            // 
            this.NUDEspacio.Location = new System.Drawing.Point(41, 202);
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
            this.lblAlineacion.Location = new System.Drawing.Point(244, 169);
            this.lblAlineacion.Name = "lblAlineacion";
            this.lblAlineacion.Size = new System.Drawing.Size(86, 20);
            this.lblAlineacion.TabIndex = 15;
            this.lblAlineacion.Text = "Alineación:";
            // 
            // CBAlineacion
            // 
            this.CBAlineacion.FormattingEnabled = true;
            this.CBAlineacion.Items.AddRange(new object[] {
            "Izquierda",
            "Centro",
            "Derecha"});
            this.CBAlineacion.Location = new System.Drawing.Point(236, 193);
            this.CBAlineacion.Name = "CBAlineacion";
            this.CBAlineacion.Size = new System.Drawing.Size(121, 28);
            this.CBAlineacion.TabIndex = 16;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(389, 169);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(148, 20);
            this.lblAncho.TabIndex = 17;
            this.lblAncho.Text = "Ancho de recuadro:";
            // 
            // NUDAncho
            // 
            this.NUDAncho.Location = new System.Drawing.Point(393, 194);
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
            this.CBColorLinea.FormattingEnabled = true;
            this.CBColorLinea.Items.AddRange(new object[] {
            "Negro",
            "Rojo",
            "Azul",
            "Verde"});
            this.CBColorLinea.Location = new System.Drawing.Point(41, 263);
            this.CBColorLinea.Name = "CBColorLinea";
            this.CBColorLinea.Size = new System.Drawing.Size(121, 28);
            this.CBColorLinea.TabIndex = 20;
            // 
            // lblColorLinea
            // 
            this.lblColorLinea.AutoSize = true;
            this.lblColorLinea.Location = new System.Drawing.Point(37, 240);
            this.lblColorLinea.Name = "lblColorLinea";
            this.lblColorLinea.Size = new System.Drawing.Size(109, 20);
            this.lblColorLinea.TabIndex = 19;
            this.lblColorLinea.Text = "Color de linea:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(41, 307);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(79, 42);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // Impressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 357);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBColorLinea);
            this.Controls.Add(this.lblColorLinea);
            this.Controls.Add(this.NUDAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.CBAlineacion);
            this.Controls.Add(this.lblAlineacion);
            this.Controls.Add(this.NUDEspacio);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.CBModificar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.CBColorLetra);
            this.Controls.Add(this.lblColorLetra);
            this.Controls.Add(this.CBGrosor);
            this.Controls.Add(this.lblGrosorLetra);
            this.Controls.Add(this.NUDSizeLetra);
            this.Controls.Add(this.lblSizeLetra);
            this.Controls.Add(this.CBPagina);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.CBImpresiones);
            this.Controls.Add(this.lblImpresiones);
            this.Name = "Impressions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresiones";
            ((System.ComponentModel.ISupportInitialize)(this.NUDSizeLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEspacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAncho)).EndInit();
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
        private System.Windows.Forms.Label lblGrosorLetra;
        private System.Windows.Forms.ComboBox CBGrosor;
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
    }
}
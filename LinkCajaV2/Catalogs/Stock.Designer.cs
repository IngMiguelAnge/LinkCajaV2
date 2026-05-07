namespace LinkCajaV2.Catalogs
{
    partial class Stock
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
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblCostoGramo = new System.Windows.Forms.Label();
            this.nudCada = new System.Windows.Forms.NumericUpDown();
            this.lblPor = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRecomendacion = new System.Windows.Forms.Label();
            this.lblMargen = new System.Windows.Forms.Label();
            this.nudMargen = new System.Windows.Forms.NumericUpDown();
            this.Porcentaje = new System.Windows.Forms.Label();
            this.lblRecomendacion2 = new System.Windows.Forms.Label();
            this.lblRecomendacion3 = new System.Windows.Forms.Label();
            this.lblPrecioGramo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(348, 329);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(29, 20);
            this.lblMedida.TabIndex = 12;
            this.lblMedida.Text = "----";
            // 
            // lblCostoGramo
            // 
            this.lblCostoGramo.AutoSize = true;
            this.lblCostoGramo.Location = new System.Drawing.Point(32, 382);
            this.lblCostoGramo.Name = "lblCostoGramo";
            this.lblCostoGramo.Size = new System.Drawing.Size(131, 20);
            this.lblCostoGramo.TabIndex = 13;
            this.lblCostoGramo.Text = "Costo por gramo:";
            this.lblCostoGramo.Visible = false;
            // 
            // nudCada
            // 
            this.nudCada.Location = new System.Drawing.Point(201, 323);
            this.nudCada.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCada.Name = "nudCada";
            this.nudCada.Size = new System.Drawing.Size(120, 26);
            this.nudCada.TabIndex = 11;
            this.nudCada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudCada_KeyUp);
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(206, 287);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(72, 20);
            this.lblPor.TabIndex = 10;
            this.lblPor.Text = "Por cada";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(36, 323);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 26);
            this.nudPrecio.TabIndex = 9;
            this.nudPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudPrecio_KeyUp);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(32, 287);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.Enabled = false;
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(36, 93);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(121, 28);
            this.cbPresentacion.TabIndex = 2;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(32, 65);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(106, 20);
            this.lblPresentacion.TabIndex = 1;
            this.lblPresentacion.Text = "Presentación:";
            // 
            // nudExistencias
            // 
            this.nudExistencias.Location = new System.Drawing.Point(201, 94);
            this.nudExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(120, 26);
            this.nudExistencias.TabIndex = 4;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(206, 65);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(93, 20);
            this.lblExistencias.TabIndex = 3;
            this.lblExistencias.Text = "Existencias:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(36, 449);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(108, 35);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre articulo";
            // 
            // lblRecomendacion
            // 
            this.lblRecomendacion.AutoSize = true;
            this.lblRecomendacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendacion.Location = new System.Drawing.Point(31, 178);
            this.lblRecomendacion.Name = "lblRecomendacion";
            this.lblRecomendacion.Size = new System.Drawing.Size(164, 25);
            this.lblRecomendacion.TabIndex = 7;
            this.lblRecomendacion.Text = "Se recomienda:";
            // 
            // lblMargen
            // 
            this.lblMargen.AutoSize = true;
            this.lblMargen.Location = new System.Drawing.Point(32, 144);
            this.lblMargen.Name = "lblMargen";
            this.lblMargen.Size = new System.Drawing.Size(158, 20);
            this.lblMargen.TabIndex = 5;
            this.lblMargen.Text = "Margen de ganancia:";
            // 
            // nudMargen
            // 
            this.nudMargen.Location = new System.Drawing.Point(201, 142);
            this.nudMargen.Name = "nudMargen";
            this.nudMargen.Size = new System.Drawing.Size(120, 26);
            this.nudMargen.TabIndex = 6;
            this.nudMargen.ValueChanged += new System.EventHandler(this.nudMargen_ValueChanged);
            this.nudMargen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudMargen_KeyUp);
            // 
            // Porcentaje
            // 
            this.Porcentaje.AutoSize = true;
            this.Porcentaje.Location = new System.Drawing.Point(327, 144);
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Size = new System.Drawing.Size(23, 20);
            this.Porcentaje.TabIndex = 15;
            this.Porcentaje.Text = "%";
            // 
            // lblRecomendacion2
            // 
            this.lblRecomendacion2.AutoSize = true;
            this.lblRecomendacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendacion2.Location = new System.Drawing.Point(31, 245);
            this.lblRecomendacion2.Name = "lblRecomendacion2";
            this.lblRecomendacion2.Size = new System.Drawing.Size(164, 25);
            this.lblRecomendacion2.TabIndex = 16;
            this.lblRecomendacion2.Text = "Se recomienda:";
            // 
            // lblRecomendacion3
            // 
            this.lblRecomendacion3.AutoSize = true;
            this.lblRecomendacion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendacion3.Location = new System.Drawing.Point(31, 210);
            this.lblRecomendacion3.Name = "lblRecomendacion3";
            this.lblRecomendacion3.Size = new System.Drawing.Size(164, 25);
            this.lblRecomendacion3.TabIndex = 17;
            this.lblRecomendacion3.Text = "Se recomienda:";
            // 
            // lblPrecioGramo
            // 
            this.lblPrecioGramo.AutoSize = true;
            this.lblPrecioGramo.Location = new System.Drawing.Point(36, 406);
            this.lblPrecioGramo.Name = "lblPrecioGramo";
            this.lblPrecioGramo.Size = new System.Drawing.Size(18, 20);
            this.lblPrecioGramo.TabIndex = 18;
            this.lblPrecioGramo.Text = "$";
            this.lblPrecioGramo.Visible = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 496);
            this.Controls.Add(this.lblPrecioGramo);
            this.Controls.Add(this.lblRecomendacion3);
            this.Controls.Add(this.lblRecomendacion2);
            this.Controls.Add(this.Porcentaje);
            this.Controls.Add(this.nudMargen);
            this.Controls.Add(this.lblMargen);
            this.Controls.Add(this.lblRecomendacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblCostoGramo);
            this.Controls.Add(this.nudCada);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.nudExistencias);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.BtnGuardar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblCostoGramo;
        private System.Windows.Forms.NumericUpDown nudCada;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.NumericUpDown nudExistencias;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRecomendacion;
        private System.Windows.Forms.Label lblMargen;
        private System.Windows.Forms.NumericUpDown nudMargen;
        private System.Windows.Forms.Label Porcentaje;
        private System.Windows.Forms.Label lblRecomendacion2;
        private System.Windows.Forms.Label lblRecomendacion3;
        private System.Windows.Forms.Label lblPrecioGramo;
    }
}
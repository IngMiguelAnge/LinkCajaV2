namespace LinkCajaV2.Catalogs
{
    partial class Article
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.PBProducto = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.nudCada = new System.Windows.Forms.NumericUpDown();
            this.lblCostoGramo = new System.Windows.Forms.Label();
            this.txtGramo = new System.Windows.Forms.TextBox();
            this.lblMedida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 64);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "*Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 58);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 83);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(571, 229);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(105, 40);
            this.btnImagen.TabIndex = 6;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // PBProducto
            // 
            this.PBProducto.Location = new System.Drawing.Point(473, 12);
            this.PBProducto.Name = "PBProducto";
            this.PBProducto.Size = new System.Drawing.Size(320, 211);
            this.PBProducto.TabIndex = 15;
            this.PBProducto.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(36, 400);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(108, 35);
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(216, 214);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(93, 20);
            this.lblExistencias.TabIndex = 9;
            this.lblExistencias.Text = "Existencias:";
            // 
            // nudExistencias
            // 
            this.nudExistencias.Location = new System.Drawing.Point(201, 243);
            this.nudExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(120, 26);
            this.nudExistencias.TabIndex = 10;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(38, 212);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(106, 20);
            this.lblPresentacion.TabIndex = 7;
            this.lblPresentacion.Text = "Presentación:";
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(23, 241);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(121, 28);
            this.cbPresentacion.TabIndex = 8;
            this.cbPresentacion.SelectedIndexChanged += new System.EventHandler(this.cbPresentacion_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(32, 303);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(125, 20);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio Sugerido:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(36, 339);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 26);
            this.nudPrecio.TabIndex = 12;
            this.nudPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudPrecio_KeyUp);
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(206, 303);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(72, 20);
            this.lblPor.TabIndex = 13;
            this.lblPor.Text = "Por cada";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 161);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "*Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 158);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(334, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // nudCada
            // 
            this.nudCada.Location = new System.Drawing.Point(201, 339);
            this.nudCada.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCada.Name = "nudCada";
            this.nudCada.Size = new System.Drawing.Size(120, 26);
            this.nudCada.TabIndex = 14;
            this.nudCada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudCada_KeyUp);
            // 
            // lblCostoGramo
            // 
            this.lblCostoGramo.AutoSize = true;
            this.lblCostoGramo.Location = new System.Drawing.Point(407, 310);
            this.lblCostoGramo.Name = "lblCostoGramo";
            this.lblCostoGramo.Size = new System.Drawing.Size(131, 20);
            this.lblCostoGramo.TabIndex = 19;
            this.lblCostoGramo.Text = "Costo por gramo:";
            this.lblCostoGramo.Visible = false;
            // 
            // txtGramo
            // 
            this.txtGramo.Enabled = false;
            this.txtGramo.Location = new System.Drawing.Point(411, 338);
            this.txtGramo.Name = "txtGramo";
            this.txtGramo.Size = new System.Drawing.Size(127, 26);
            this.txtGramo.TabIndex = 20;
            this.txtGramo.Visible = false;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(348, 345);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(29, 20);
            this.lblMedida.TabIndex = 21;
            this.lblMedida.Text = "----";
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 449);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.txtGramo);
            this.Controls.Add(this.lblCostoGramo);
            this.Controls.Add(this.nudCada);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.nudExistencias);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PBProducto);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox PBProducto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.NumericUpDown nudExistencias;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown nudCada;
        private System.Windows.Forms.Label lblCostoGramo;
        private System.Windows.Forms.TextBox txtGramo;
        private System.Windows.Forms.Label lblMedida;
    }
}
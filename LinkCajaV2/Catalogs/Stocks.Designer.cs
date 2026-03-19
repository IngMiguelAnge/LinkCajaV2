namespace LinkCajaV2.Catalogs
{
    partial class Stocks
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
            this.cbPresentacion2 = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblM = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CBCaducidad = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPresentacion2
            // 
            this.cbPresentacion2.FormattingEnabled = true;
            this.cbPresentacion2.Location = new System.Drawing.Point(319, 225);
            this.cbPresentacion2.Name = "cbPresentacion2";
            this.cbPresentacion2.Size = new System.Drawing.Size(121, 28);
            this.cbPresentacion2.TabIndex = 10;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(168, 225);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 26);
            this.nudCantidad.TabIndex = 9;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(178, 188);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(72, 20);
            this.lblM.TabIndex = 8;
            this.lblM.Text = "Por cada";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(28, 225);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 26);
            this.nudPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 188);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(27, 140);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(121, 28);
            this.cbPresentacion.TabIndex = 3;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(23, 113);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(102, 20);
            this.lblPresentacion.TabIndex = 2;
            this.lblPresentacion.Text = "Presentación";
            // 
            // nudExistencias
            // 
            this.nudExistencias.Location = new System.Drawing.Point(168, 141);
            this.nudExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(120, 26);
            this.nudExistencias.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(164, 114);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(143, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad Existente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(27, 66);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(292, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // CBCaducidad
            // 
            this.CBCaducidad.AutoSize = true;
            this.CBCaducidad.Location = new System.Drawing.Point(27, 26);
            this.CBCaducidad.Name = "CBCaducidad";
            this.CBCaducidad.Size = new System.Drawing.Size(261, 24);
            this.CBCaducidad.TabIndex = 0;
            this.CBCaducidad.Text = "¿La existencia tiene caducidad?";
            this.CBCaducidad.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(27, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 36);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvExistencias);
            this.groupBox1.Location = new System.Drawing.Point(463, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 326);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existencias";
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExistencias.Location = new System.Drawing.Point(3, 22);
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.RowHeadersWidth = 62;
            this.dgvExistencias.RowTemplate.Height = 28;
            this.dgvExistencias.Size = new System.Drawing.Size(488, 301);
            this.dgvExistencias.TabIndex = 14;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbPresentacion2);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.nudExistencias);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.CBCaducidad);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbPresentacion2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.NumericUpDown nudExistencias;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox CBCaducidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExistencias;
    }
}
namespace LinkCajaV2.Catalogs
{
    partial class PricesSuppliers
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
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.gbProveedores = new System.Windows.Forms.GroupBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.gbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(252, 38);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(121, 28);
            this.cbPresentacion.TabIndex = 4;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(27, 41);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(143, 20);
            this.lblPresentacion.TabIndex = 3;
            this.lblPresentacion.Text = "Unidad de compra:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(253, 167);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 26);
            this.nudPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(27, 169);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(215, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio de compra por unidad:";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(252, 118);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(121, 28);
            this.cbProveedores.TabIndex = 10;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(27, 126);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(219, 20);
            this.lblProveedor.TabIndex = 9;
            this.lblProveedor.Text = "¿Que proveedor se lo vendio?";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 37);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(27, 73);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(358, 20);
            this.lblNota.TabIndex = 12;
            this.lblNota.Text = "Nota: La unidad elegida afectara a las existencias";
            // 
            // gbProveedores
            // 
            this.gbProveedores.Controls.Add(this.dgvProveedores);
            this.gbProveedores.Location = new System.Drawing.Point(31, 273);
            this.gbProveedores.Name = "gbProveedores";
            this.gbProveedores.Size = new System.Drawing.Size(475, 233);
            this.gbProveedores.TabIndex = 13;
            this.gbProveedores.TabStop = false;
            this.gbProveedores.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(3, 22);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 62;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.Size = new System.Drawing.Size(469, 208);
            this.dgvProveedores.TabIndex = 14;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            this.dgvProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProveedores_CellPainting);
            this.dgvProveedores.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProveedores_CellValidating);
            this.dgvProveedores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellValueChanged);
            this.dgvProveedores.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProveedores_EditingControlShowing);
            // 
            // PricesSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 518);
            this.Controls.Add(this.gbProveedores);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Name = "PricesSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores del articulo";
            this.Load += new System.EventHandler(this.PricesSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.gbProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.GroupBox gbProveedores;
        private System.Windows.Forms.DataGridView dgvProveedores;
    }
}
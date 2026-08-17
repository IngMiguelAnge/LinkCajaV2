namespace LinkCajaV2.Reports
{
    partial class SalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.gbDetalleVentas = new System.Windows.Forms.GroupBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnImpresion = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDetalleVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDesde
            // 
            this.dtDesde.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtDesde.Location = new System.Drawing.Point(15, 101);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(379, 32);
            this.dtDesde.TabIndex = 0;
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtHasta.Location = new System.Drawing.Point(431, 103);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(379, 32);
            this.dtHasta.TabIndex = 1;
            // 
            // gbDetalleVentas
            // 
            this.gbDetalleVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleVentas.Controls.Add(this.dgvVentas);
            this.gbDetalleVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbDetalleVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.gbDetalleVentas.Location = new System.Drawing.Point(12, 162);
            this.gbDetalleVentas.Name = "gbDetalleVentas";
            this.gbDetalleVentas.Size = new System.Drawing.Size(1302, 357);
            this.gbDetalleVentas.TabIndex = 4;
            this.gbDetalleVentas.TabStop = false;
            this.gbDetalleVentas.Text = "Resumen de Ventas";
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ColumnHeadersHeight = 35;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.LightGray;
            this.dgvVentas.Location = new System.Drawing.Point(3, 24);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 30;
            this.dgvVentas.Size = new System.Drawing.Size(1275, 330);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVentas_ColumnHeaderMouseDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(988, 101);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 33);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 10);
            this.progressBar1.TabIndex = 36;
            // 
            // BtnImpresion
            // 
            this.BtnImpresion.BackColor = System.Drawing.Color.White;
            this.BtnImpresion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.BtnImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImpresion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImpresion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.BtnImpresion.Image = ((System.Drawing.Image)(resources.GetObject("BtnImpresion.Image")));
            this.BtnImpresion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImpresion.Location = new System.Drawing.Point(839, 103);
            this.BtnImpresion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImpresion.Name = "BtnImpresion";
            this.BtnImpresion.Size = new System.Drawing.Size(120, 30);
            this.BtnImpresion.TabIndex = 37;
            this.BtnImpresion.Text = "  Imprimir";
            this.BtnImpresion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImpresion.UseVisualStyleBackColor = false;
            this.BtnImpresion.Click += new System.EventHandler(this.BtnImpresion_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(291, 33);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 32);
            this.txtDescripcion.TabIndex = 41;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDescripcion.Location = new System.Drawing.Point(287, 7);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 20);
            this.lblDescripcion.TabIndex = 40;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 32);
            this.txtNombre.TabIndex = 39;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombre.Location = new System.Drawing.Point(14, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(593, 33);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(250, 33);
            this.cbProveedor.TabIndex = 43;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblProveedor.Location = new System.Drawing.Point(589, 7);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(86, 20);
            this.lblProveedor.TabIndex = 42;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(872, 33);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(250, 33);
            this.cbCategoria.TabIndex = 45;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCategoria.Location = new System.Drawing.Point(868, 7);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 20);
            this.lblCategoria.TabIndex = 44;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDesde.Location = new System.Drawing.Point(14, 80);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 46;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHasta.Location = new System.Drawing.Point(427, 80);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(53, 20);
            this.lblHasta.TabIndex = 47;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeneral.Location = new System.Drawing.Point(1118, 108);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(68, 25);
            this.lblTotalGeneral.TabIndex = 48;
            this.lblTotalGeneral.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1191, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnImpresion);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbDetalleVentas);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.gbDetalleVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.GroupBox gbDetalleVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnImpresion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label label2;
    }
}
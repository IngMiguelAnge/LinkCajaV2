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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblInversionTotal = new System.Windows.Forms.Label();
            this.lblGananciaTotal = new System.Windows.Forms.Label();
            this.lblTotalEnvio = new System.Windows.Forms.Label();
            this.gbDetalleVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDesde
            // 
            this.dtDesde.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtDesde.Location = new System.Drawing.Point(17, 126);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(426, 37);
            this.dtDesde.TabIndex = 4;
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtHasta.Location = new System.Drawing.Point(485, 129);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(426, 37);
            this.dtHasta.TabIndex = 5;
            // 
            // gbDetalleVentas
            // 
            this.gbDetalleVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleVentas.Controls.Add(this.dgvVentas);
            this.gbDetalleVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbDetalleVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.gbDetalleVentas.Location = new System.Drawing.Point(14, 202);
            this.gbDetalleVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleVentas.Name = "gbDetalleVentas";
            this.gbDetalleVentas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleVentas.Size = new System.Drawing.Size(1693, 446);
            this.gbDetalleVentas.TabIndex = 4;
            this.gbDetalleVentas.TabStop = false;
            this.gbDetalleVentas.Text = "Resumen de Ventas";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.ColumnHeadersHeight = 35;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.LightGray;
            this.dgvVentas.Location = new System.Drawing.Point(3, 36);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 30;
            this.dgvVentas.Size = new System.Drawing.Size(1687, 406);
            this.dgvVentas.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1112, 126);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 41);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 182);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 12);
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
            this.BtnImpresion.Location = new System.Drawing.Point(944, 129);
            this.BtnImpresion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImpresion.Name = "BtnImpresion";
            this.BtnImpresion.Size = new System.Drawing.Size(135, 38);
            this.BtnImpresion.TabIndex = 6;
            this.BtnImpresion.Text = "  Imprimir";
            this.BtnImpresion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImpresion.UseVisualStyleBackColor = false;
            this.BtnImpresion.Click += new System.EventHandler(this.BtnImpresion_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(327, 41);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(306, 37);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDescripcion.Location = new System.Drawing.Point(323, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 25);
            this.lblDescripcion.TabIndex = 40;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(17, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 37);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombre.Location = new System.Drawing.Point(16, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(667, 41);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(281, 38);
            this.cbProveedor.TabIndex = 2;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblProveedor.Location = new System.Drawing.Point(663, 9);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(106, 25);
            this.lblProveedor.TabIndex = 42;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(981, 41);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(281, 38);
            this.cbCategoria.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCategoria.Location = new System.Drawing.Point(976, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 25);
            this.lblCategoria.TabIndex = 44;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDesde.Location = new System.Drawing.Point(16, 100);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(69, 25);
            this.lblDesde.TabIndex = 46;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHasta.Location = new System.Drawing.Point(480, 100);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(66, 25);
            this.lblHasta.TabIndex = 47;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalGeneral.Location = new System.Drawing.Point(1303, 50);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(113, 25);
            this.lblTotalGeneral.TabIndex = 48;
            this.lblTotalGeneral.Text = "Venta Total:";
            // 
            // lblInversionTotal
            // 
            this.lblInversionTotal.AutoSize = true;
            this.lblInversionTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInversionTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblInversionTotal.Location = new System.Drawing.Point(1303, 170);
            this.lblInversionTotal.Name = "lblInversionTotal";
            this.lblInversionTotal.Size = new System.Drawing.Size(143, 25);
            this.lblInversionTotal.TabIndex = 49;
            this.lblInversionTotal.Text = "Inversion Total:";
            // 
            // lblGananciaTotal
            // 
            this.lblGananciaTotal.AutoSize = true;
            this.lblGananciaTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGananciaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblGananciaTotal.Location = new System.Drawing.Point(1304, 129);
            this.lblGananciaTotal.Name = "lblGananciaTotal";
            this.lblGananciaTotal.Size = new System.Drawing.Size(143, 25);
            this.lblGananciaTotal.TabIndex = 50;
            this.lblGananciaTotal.Text = "Ganancia Total:";
            // 
            // lblTotalEnvio
            // 
            this.lblTotalEnvio.AutoSize = true;
            this.lblTotalEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalEnvio.Location = new System.Drawing.Point(1304, 88);
            this.lblTotalEnvio.Name = "lblTotalEnvio";
            this.lblTotalEnvio.Size = new System.Drawing.Size(111, 25);
            this.lblTotalEnvio.TabIndex = 51;
            this.lblTotalEnvio.Text = "Envio Total:";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1720, 664);
            this.Controls.Add(this.lblTotalEnvio);
            this.Controls.Add(this.lblGananciaTotal);
            this.Controls.Add(this.lblInversionTotal);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesReport";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Label lblInversionTotal;
        private System.Windows.Forms.Label lblGananciaTotal;
        private System.Windows.Forms.Label lblTotalEnvio;
    }
}
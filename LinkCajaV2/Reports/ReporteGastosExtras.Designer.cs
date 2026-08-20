namespace LinkCajaV2.Catalogs
{
    partial class ReporteGastosExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteGastosExtras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.BtnImpresion = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.gbDetalleGastos = new System.Windows.Forms.GroupBox();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbDetalleGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHasta.Location = new System.Drawing.Point(478, 11);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(66, 25);
            this.lblHasta.TabIndex = 53;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDesde.Location = new System.Drawing.Point(14, 11);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(69, 25);
            this.lblDesde.TabIndex = 52;
            this.lblDesde.Text = "Desde:";
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
            this.BtnImpresion.Location = new System.Drawing.Point(942, 40);
            this.BtnImpresion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImpresion.Name = "BtnImpresion";
            this.BtnImpresion.Size = new System.Drawing.Size(135, 38);
            this.BtnImpresion.TabIndex = 50;
            this.BtnImpresion.Text = "  Imprimir";
            this.BtnImpresion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImpresion.UseVisualStyleBackColor = false;
            this.BtnImpresion.Click += new System.EventHandler(this.BtnImpresion_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1109, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 41);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtHasta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHasta.Location = new System.Drawing.Point(483, 40);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(426, 37);
            this.dtHasta.TabIndex = 49;
            // 
            // dtDesde
            // 
            this.dtDesde.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDesde.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDesde.Location = new System.Drawing.Point(15, 38);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(426, 37);
            this.dtDesde.TabIndex = 48;
            // 
            // gbDetalleGastos
            // 
            this.gbDetalleGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleGastos.Controls.Add(this.dgvGastos);
            this.gbDetalleGastos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbDetalleGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.gbDetalleGastos.Location = new System.Drawing.Point(15, 150);
            this.gbDetalleGastos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleGastos.Name = "gbDetalleGastos";
            this.gbDetalleGastos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleGastos.Size = new System.Drawing.Size(1474, 452);
            this.gbDetalleGastos.TabIndex = 54;
            this.gbDetalleGastos.TabStop = false;
            this.gbDetalleGastos.Text = "Gastos";
            // 
            // dgvGastos
            // 
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGastos.ColumnHeadersHeight = 35;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGastos.EnableHeadersVisualStyles = false;
            this.dgvGastos.GridColor = System.Drawing.Color.LightGray;
            this.dgvGastos.Location = new System.Drawing.Point(3, 36);
            this.dgvGastos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.RowHeadersWidth = 51;
            this.dgvGastos.RowTemplate.Height = 30;
            this.dgvGastos.Size = new System.Drawing.Size(1468, 412);
            this.dgvGastos.TabIndex = 0;
            this.dgvGastos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellDoubleClick);
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalGastos.Location = new System.Drawing.Point(1259, 55);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(147, 25);
            this.lblTotalGastos.TabIndex = 55;
            this.lblTotalGastos.Text = "Total de Gastos:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 112);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 12);
            this.progressBar1.TabIndex = 56;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // ReporteGastosExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 651);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTotalGastos);
            this.Controls.Add(this.gbDetalleGastos);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.BtnImpresion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ReporteGastosExtras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbDetalleGastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button BtnImpresion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.GroupBox gbDetalleGastos;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
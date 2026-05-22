namespace LinkCajaV2.Reports
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.CBFecha = new System.Windows.Forms.CheckBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.NUDTicket = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GBTickets = new System.Windows.Forms.GroupBox();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.lblVenta = new System.Windows.Forms.Label();
            this.RBCreacion = new System.Windows.Forms.RadioButton();
            this.RBModificacion = new System.Windows.Forms.RadioButton();
            this.lblTotalDevolucion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTicket)).BeginInit();
            this.GBTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDesde
            // 
            this.dtDesde.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Location = new System.Drawing.Point(41, 198);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(272, 37);
            this.dtDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDesde.Location = new System.Drawing.Point(42, 161);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(69, 25);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHasta.Location = new System.Drawing.Point(335, 166);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(66, 25);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Location = new System.Drawing.Point(340, 198);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(272, 37);
            this.dtHasta.TabIndex = 6;
            // 
            // CBFecha
            // 
            this.CBFecha.AutoSize = true;
            this.CBFecha.Checked = true;
            this.CBFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.CBFecha.Location = new System.Drawing.Point(46, 106);
            this.CBFecha.Name = "CBFecha";
            this.CBFecha.Size = new System.Drawing.Size(210, 32);
            this.CBFecha.TabIndex = 0;
            this.CBFecha.Text = "¿Buscar por fecha?";
            this.CBFecha.UseVisualStyleBackColor = true;
            this.CBFecha.CheckedChanged += new System.EventHandler(this.CBBuscar_CheckedChanged);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTicket.Location = new System.Drawing.Point(42, 261);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(95, 25);
            this.lblTicket.TabIndex = 7;
            this.lblTicket.Text = "N° Ticket:";
            // 
            // NUDTicket
            // 
            this.NUDTicket.Enabled = false;
            this.NUDTicket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDTicket.Location = new System.Drawing.Point(41, 289);
            this.NUDTicket.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NUDTicket.Name = "NUDTicket";
            this.NUDTicket.Size = new System.Drawing.Size(272, 37);
            this.NUDTicket.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(340, 289);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 37);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GBTickets
            // 
            this.GBTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBTickets.Controls.Add(this.dgvTickets);
            this.GBTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.GBTickets.Location = new System.Drawing.Point(34, 332);
            this.GBTickets.Name = "GBTickets";
            this.GBTickets.Size = new System.Drawing.Size(816, 209);
            this.GBTickets.TabIndex = 12;
            this.GBTickets.TabStop = false;
            this.GBTickets.Text = "Tickets:";
            // 
            // dgvTickets
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.EnableHeadersVisualStyles = false;
            this.dgvTickets.Location = new System.Drawing.Point(3, 35);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 62;
            this.dgvTickets.RowTemplate.Height = 28;
            this.dgvTickets.Size = new System.Drawing.Size(810, 171);
            this.dgvTickets.TabIndex = 13;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblVenta.Location = new System.Drawing.Point(547, 261);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(166, 25);
            this.lblVenta.TabIndex = 10;
            this.lblVenta.Text = "Venta total $: 0.00";
            // 
            // RBCreacion
            // 
            this.RBCreacion.AutoSize = true;
            this.RBCreacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCreacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.RBCreacion.Location = new System.Drawing.Point(303, 105);
            this.RBCreacion.Name = "RBCreacion";
            this.RBCreacion.Size = new System.Drawing.Size(207, 32);
            this.RBCreacion.TabIndex = 1;
            this.RBCreacion.TabStop = true;
            this.RBCreacion.Text = "Desde que se creo";
            this.RBCreacion.UseVisualStyleBackColor = true;
            this.RBCreacion.CheckedChanged += new System.EventHandler(this.RBCreacion_CheckedChanged);
            // 
            // RBModificacion
            // 
            this.RBModificacion.AutoSize = true;
            this.RBModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBModificacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.RBModificacion.Location = new System.Drawing.Point(542, 105);
            this.RBModificacion.Name = "RBModificacion";
            this.RBModificacion.Size = new System.Drawing.Size(227, 32);
            this.RBModificacion.TabIndex = 2;
            this.RBModificacion.TabStop = true;
            this.RBModificacion.Text = "Ultima modificación";
            this.RBModificacion.UseVisualStyleBackColor = true;
            this.RBModificacion.CheckedChanged += new System.EventHandler(this.RBModificacion_CheckedChanged);
            // 
            // lblTotalDevolucion
            // 
            this.lblTotalDevolucion.AutoSize = true;
            this.lblTotalDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalDevolucion.Location = new System.Drawing.Point(547, 301);
            this.lblTotalDevolucion.Name = "lblTotalDevolucion";
            this.lblTotalDevolucion.Size = new System.Drawing.Size(213, 25);
            this.lblTotalDevolucion.TabIndex = 11;
            this.lblTotalDevolucion.Text = "Devolución total $: 0.00";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 48);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Lista de Tickets";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 571);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotalDevolucion);
            this.Controls.Add(this.RBModificacion);
            this.Controls.Add(this.RBCreacion);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.GBTickets);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.NUDTicket);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.CBFecha);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtDesde);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tickets";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTicket)).EndInit();
            this.GBTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.CheckBox CBFecha;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.NumericUpDown NUDTicket;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox GBTickets;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.RadioButton RBCreacion;
        private System.Windows.Forms.RadioButton RBModificacion;
        private System.Windows.Forms.Label lblTotalDevolucion;
        private System.Windows.Forms.Label lblTitulo;
    }
}
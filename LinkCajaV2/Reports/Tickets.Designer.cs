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
            ((System.ComponentModel.ISupportInitialize)(this.NUDTicket)).BeginInit();
            this.GBTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(34, 101);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 26);
            this.dtDesde.TabIndex = 5;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(30, 78);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(287, 78);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(291, 101);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 26);
            this.dtHasta.TabIndex = 6;
            // 
            // CBFecha
            // 
            this.CBFecha.AutoSize = true;
            this.CBFecha.Checked = true;
            this.CBFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBFecha.Location = new System.Drawing.Point(34, 23);
            this.CBFecha.Name = "CBFecha";
            this.CBFecha.Size = new System.Drawing.Size(174, 24);
            this.CBFecha.TabIndex = 0;
            this.CBFecha.Text = "¿Buscar por fecha?";
            this.CBFecha.UseVisualStyleBackColor = true;
            this.CBFecha.CheckedChanged += new System.EventHandler(this.CBBuscar_CheckedChanged);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(30, 164);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(75, 20);
            this.lblTicket.TabIndex = 8;
            this.lblTicket.Text = "N° Ticket:";
            // 
            // NUDTicket
            // 
            this.NUDTicket.Enabled = false;
            this.NUDTicket.Location = new System.Drawing.Point(114, 158);
            this.NUDTicket.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NUDTicket.Name = "NUDTicket";
            this.NUDTicket.Size = new System.Drawing.Size(120, 26);
            this.NUDTicket.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(291, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 41);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GBTickets
            // 
            this.GBTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBTickets.Controls.Add(this.dgvTickets);
            this.GBTickets.Location = new System.Drawing.Point(34, 208);
            this.GBTickets.Name = "GBTickets";
            this.GBTickets.Size = new System.Drawing.Size(644, 212);
            this.GBTickets.TabIndex = 1;
            this.GBTickets.TabStop = false;
            this.GBTickets.Text = "Tickets:";
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.Location = new System.Drawing.Point(3, 22);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 62;
            this.dgvTickets.RowTemplate.Height = 28;
            this.dgvTickets.Size = new System.Drawing.Size(638, 187);
            this.dgvTickets.TabIndex = 12;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(434, 153);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(139, 20);
            this.lblVenta.TabIndex = 7;
            this.lblVenta.Text = "Venta total $: 0.00";
            // 
            // RBCreacion
            // 
            this.RBCreacion.AutoSize = true;
            this.RBCreacion.Location = new System.Drawing.Point(291, 22);
            this.RBCreacion.Name = "RBCreacion";
            this.RBCreacion.Size = new System.Drawing.Size(168, 24);
            this.RBCreacion.TabIndex = 1;
            this.RBCreacion.TabStop = true;
            this.RBCreacion.Text = "Desde que se creo";
            this.RBCreacion.UseVisualStyleBackColor = true;
            this.RBCreacion.CheckedChanged += new System.EventHandler(this.RBCreacion_CheckedChanged);
            // 
            // RBModificacion
            // 
            this.RBModificacion.AutoSize = true;
            this.RBModificacion.Location = new System.Drawing.Point(496, 23);
            this.RBModificacion.Name = "RBModificacion";
            this.RBModificacion.Size = new System.Drawing.Size(171, 24);
            this.RBModificacion.TabIndex = 2;
            this.RBModificacion.TabStop = true;
            this.RBModificacion.Text = "Ultima modificación";
            this.RBModificacion.UseVisualStyleBackColor = true;
            this.RBModificacion.CheckedChanged += new System.EventHandler(this.RBModificacion_CheckedChanged);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
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
            this.Name = "Tickets";
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
    }
}
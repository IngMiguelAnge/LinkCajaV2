namespace LinkCajaV2.Items
{
    partial class Fund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fund));
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.dtFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.CBCajas = new System.Windows.Forms.ComboBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblCierre = new System.Windows.Forms.Label();
            this.dtFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.nudInicio = new System.Windows.Forms.NumericUpDown();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.lblTotalDevolucion = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.NudRetiro = new System.Windows.Forms.NumericUpDown();
            this.lblFondoQueda = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelEspaciador = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRetiro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaApertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblFechaApertura.Location = new System.Drawing.Point(48, 198);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(171, 25);
            this.lblFechaApertura.TabIndex = 2;
            this.lblFechaApertura.Text = "Fecha de apertura:";
            // 
            // dtFechaApertura
            // 
            this.dtFechaApertura.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtFechaApertura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaApertura.Location = new System.Drawing.Point(53, 234);
            this.dtFechaApertura.Name = "dtFechaApertura";
            this.dtFechaApertura.Size = new System.Drawing.Size(287, 37);
            this.dtFechaApertura.TabIndex = 3;
            this.dtFechaApertura.ValueChanged += new System.EventHandler(this.dtFechaApertura_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(297, 865);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 48);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 48);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Corte de Caja";
            // 
            // CBCajas
            // 
            this.CBCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCajas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCajas.FormattingEnabled = true;
            this.CBCajas.Location = new System.Drawing.Point(54, 141);
            this.CBCajas.Name = "CBCajas";
            this.CBCajas.Size = new System.Drawing.Size(286, 38);
            this.CBCajas.TabIndex = 1;
            this.CBCajas.SelectedIndexChanged += new System.EventHandler(this.CBCajas_SelectedIndexChanged);
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCaja.Location = new System.Drawing.Point(49, 102);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(53, 25);
            this.lblCaja.TabIndex = 0;
            this.lblCaja.Text = "Caja:";
            // 
            // lblCierre
            // 
            this.lblCierre.AutoSize = true;
            this.lblCierre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCierre.Location = new System.Drawing.Point(49, 283);
            this.lblCierre.Name = "lblCierre";
            this.lblCierre.Size = new System.Drawing.Size(145, 25);
            this.lblCierre.TabIndex = 4;
            this.lblCierre.Text = "Fecha de cierre:";
            // 
            // dtFechaCierre
            // 
            this.dtFechaCierre.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtFechaCierre.Enabled = false;
            this.dtFechaCierre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaCierre.Location = new System.Drawing.Point(54, 321);
            this.dtFechaCierre.Name = "dtFechaCierre";
            this.dtFechaCierre.Size = new System.Drawing.Size(287, 37);
            this.dtFechaCierre.TabIndex = 5;
            this.dtFechaCierre.ValueChanged += new System.EventHandler(this.dtFechaCierre_ValueChanged);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblIngresos.Location = new System.Drawing.Point(49, 372);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(84, 25);
            this.lblIngresos.TabIndex = 6;
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblInicio.Location = new System.Drawing.Point(49, 409);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(182, 25);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Saldo Inicial del día:";
            // 
            // nudInicio
            // 
            this.nudInicio.DecimalPlaces = 2;
            this.nudInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInicio.Location = new System.Drawing.Point(50, 446);
            this.nudInicio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudInicio.Name = "nudInicio";
            this.nudInicio.Size = new System.Drawing.Size(250, 37);
            this.nudInicio.TabIndex = 8;
            this.nudInicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudInicio_KeyUp);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblVenta.Location = new System.Drawing.Point(45, 498);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(168, 25);
            this.lblVenta.TabIndex = 9;
            this.lblVenta.Text = "Venta Total $: 0.00";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEgresos.Location = new System.Drawing.Point(44, 548);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(82, 25);
            this.lblEgresos.TabIndex = 10;
            this.lblEgresos.Text = "Egresos:";
            // 
            // lblTotalDevolucion
            // 
            this.lblTotalDevolucion.AutoSize = true;
            this.lblTotalDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalDevolucion.Location = new System.Drawing.Point(44, 599);
            this.lblTotalDevolucion.Name = "lblTotalDevolucion";
            this.lblTotalDevolucion.Size = new System.Drawing.Size(215, 25);
            this.lblTotalDevolucion.TabIndex = 11;
            this.lblTotalDevolucion.Text = "Devolución Total $: 0.00";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSaldoTotal.Location = new System.Drawing.Point(43, 648);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(281, 25);
            this.lblSaldoTotal.TabIndex = 12;
            this.lblSaldoTotal.Text = "Saldo en Efectivo en Caja: $0.00";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRetiro.Location = new System.Drawing.Point(49, 704);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(164, 25);
            this.lblRetiro.TabIndex = 13;
            this.lblRetiro.Text = "Efectivo Retirado:";
            // 
            // NudRetiro
            // 
            this.NudRetiro.DecimalPlaces = 2;
            this.NudRetiro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudRetiro.Location = new System.Drawing.Point(54, 748);
            this.NudRetiro.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudRetiro.Name = "NudRetiro";
            this.NudRetiro.Size = new System.Drawing.Size(250, 37);
            this.NudRetiro.TabIndex = 14;
            this.NudRetiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NudRetiro_KeyUp);
            // 
            // lblFondoQueda
            // 
            this.lblFondoQueda.AutoSize = true;
            this.lblFondoQueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondoQueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblFondoQueda.Location = new System.Drawing.Point(49, 812);
            this.lblFondoQueda.Name = "lblFondoQueda";
            this.lblFondoQueda.Size = new System.Drawing.Size(238, 25);
            this.lblFondoQueda.TabIndex = 15;
            this.lblFondoQueda.Text = "Fondo que se queda: $0.00";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(52, 865);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(200, 48);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelEspaciador
            // 
            this.panelEspaciador.Location = new System.Drawing.Point(52, 915);
            this.panelEspaciador.Name = "panelEspaciador";
            this.panelEspaciador.Size = new System.Drawing.Size(445, 35);
            this.panelEspaciador.TabIndex = 18;
            // 
            // Fund
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 955);
            this.Controls.Add(this.panelEspaciador);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFondoQueda);
            this.Controls.Add(this.NudRetiro);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.lblTotalDevolucion);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.nudInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblCierre);
            this.Controls.Add(this.dtFechaCierre);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.CBCajas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFechaApertura);
            this.Controls.Add(this.dtFechaApertura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Fund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRetiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.DateTimePicker dtFechaApertura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox CBCajas;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblCierre;
        private System.Windows.Forms.DateTimePicker dtFechaCierre;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.NumericUpDown nudInicio;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.Label lblTotalDevolucion;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.NumericUpDown NudRetiro;
        private System.Windows.Forms.Label lblFondoQueda;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelEspaciador; // Definición del objeto espaciador
    }
}
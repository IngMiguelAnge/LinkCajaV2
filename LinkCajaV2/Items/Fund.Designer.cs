using System.Drawing;
using System.Windows.Forms;

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
            this.lblSaldoEfectivoCaja = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.NudRetiro = new System.Windows.Forms.NumericUpDown();
            this.lblFondoQueda = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblVentaContarjeta = new System.Windows.Forms.Label();
            this.lbTotallDevolucionTarjeta = new System.Windows.Forms.Label();
            this.lbltotales = new System.Windows.Forms.Label();
            this.lblSaldoTotalTarjeta = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnAgregar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRetiro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaApertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblFechaApertura.Location = new System.Drawing.Point(35, 195);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(171, 25);
            this.lblFechaApertura.TabIndex = 2;
            this.lblFechaApertura.Text = "Fecha de apertura:";
            // 
            // dtFechaApertura
            // 
            this.dtFechaApertura.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtFechaApertura.Enabled = false;
            this.dtFechaApertura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaApertura.Location = new System.Drawing.Point(35, 225);
            this.dtFechaApertura.Name = "dtFechaApertura";
            this.dtFechaApertura.Size = new System.Drawing.Size(307, 37);
            this.dtFechaApertura.TabIndex = 3;
            this.dtFechaApertura.ValueChanged += new System.EventHandler(this.dtFechaApertura_ValueChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
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
            this.CBCajas.Location = new System.Drawing.Point(35, 125);
            this.CBCajas.Name = "CBCajas";
            this.CBCajas.Size = new System.Drawing.Size(250, 38);
            this.CBCajas.TabIndex = 1;
            this.CBCajas.SelectedIndexChanged += new System.EventHandler(this.CBCajas_SelectedIndexChanged);
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCaja.Location = new System.Drawing.Point(35, 95);
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
            this.lblCierre.Location = new System.Drawing.Point(35, 295);
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
            this.dtFechaCierre.Location = new System.Drawing.Point(35, 325);
            this.dtFechaCierre.Name = "dtFechaCierre";
            this.dtFechaCierre.Size = new System.Drawing.Size(307, 37);
            this.dtFechaCierre.TabIndex = 5;
            this.dtFechaCierre.ValueChanged += new System.EventHandler(this.dtFechaCierre_ValueChanged);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblIngresos.Location = new System.Drawing.Point(412, 98);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(183, 30);
            this.lblIngresos.TabIndex = 6;
            this.lblIngresos.Text = "Flujo de Efectivo";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblInicio.Location = new System.Drawing.Point(414, 138);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(181, 25);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Saldo inicial del día:";
            // 
            // nudInicio
            // 
            this.nudInicio.DecimalPlaces = 2;
            this.nudInicio.Enabled = false;
            this.nudInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInicio.Location = new System.Drawing.Point(419, 174);
            this.nudInicio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudInicio.Name = "nudInicio";
            this.nudInicio.Size = new System.Drawing.Size(240, 37);
            this.nudInicio.TabIndex = 8;
            this.nudInicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudInicio_KeyUp);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.Black;
            this.lblVenta.Location = new System.Drawing.Point(414, 225);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(241, 25);
            this.lblVenta.TabIndex = 9;
            this.lblVenta.Text = "Venta total en efectivo: $0.00";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEgresos.Location = new System.Drawing.Point(414, 259);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(82, 25);
            this.lblEgresos.TabIndex = 10;
            this.lblEgresos.Text = "Egresos:";
            // 
            // lblTotalDevolucion
            // 
            this.lblTotalDevolucion.AutoSize = true;
            this.lblTotalDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDevolucion.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDevolucion.Location = new System.Drawing.Point(414, 295);
            this.lblTotalDevolucion.Name = "lblTotalDevolucion";
            this.lblTotalDevolucion.Size = new System.Drawing.Size(286, 25);
            this.lblTotalDevolucion.TabIndex = 11;
            this.lblTotalDevolucion.Text = "Devolución total en efectivo: $0.00";
            // 
            // lblSaldoEfectivoCaja
            // 
            this.lblSaldoEfectivoCaja.AutoSize = true;
            this.lblSaldoEfectivoCaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoEfectivoCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.lblSaldoEfectivoCaja.Location = new System.Drawing.Point(414, 334);
            this.lblSaldoEfectivoCaja.Name = "lblSaldoEfectivoCaja";
            this.lblSaldoEfectivoCaja.Size = new System.Drawing.Size(313, 28);
            this.lblSaldoEfectivoCaja.TabIndex = 12;
            this.lblSaldoEfectivoCaja.Text = "Saldo en efectivo en caja: $0.00";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRetiro.Location = new System.Drawing.Point(414, 380);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(214, 25);
            this.lblRetiro.TabIndex = 13;
            this.lblRetiro.Text = "Retirar efectivo de caja:";
            // 
            // NudRetiro
            // 
            this.NudRetiro.DecimalPlaces = 2;
            this.NudRetiro.Enabled = false;
            this.NudRetiro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudRetiro.Location = new System.Drawing.Point(419, 422);
            this.NudRetiro.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudRetiro.Name = "NudRetiro";
            this.NudRetiro.Size = new System.Drawing.Size(240, 37);
            this.NudRetiro.TabIndex = 14;
            this.NudRetiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NudRetiro_KeyUp);
            // 
            // lblFondoQueda
            // 
            this.lblFondoQueda.AutoSize = true;
            this.lblFondoQueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondoQueda.ForeColor = System.Drawing.Color.DimGray;
            this.lblFondoQueda.Location = new System.Drawing.Point(414, 483);
            this.lblFondoQueda.Name = "lblFondoQueda";
            this.lblFondoQueda.Size = new System.Drawing.Size(313, 25);
            this.lblFondoQueda.TabIndex = 16;
            this.lblFondoQueda.Text = "Fondo en efectivo que se queda: $0.00";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(875, 408);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(250, 48);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "CERRAR CORTE";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblVentaContarjeta
            // 
            this.lblVentaContarjeta.AutoSize = true;
            this.lblVentaContarjeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaContarjeta.ForeColor = System.Drawing.Color.Black;
            this.lblVentaContarjeta.Location = new System.Drawing.Point(870, 138);
            this.lblVentaContarjeta.Name = "lblVentaContarjeta";
            this.lblVentaContarjeta.Size = new System.Drawing.Size(238, 25);
            this.lblVentaContarjeta.TabIndex = 18;
            this.lblVentaContarjeta.Text = "Venta total con tarjeta: $0.00";
            // 
            // lbTotallDevolucionTarjeta
            // 
            this.lbTotallDevolucionTarjeta.AutoSize = true;
            this.lbTotallDevolucionTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotallDevolucionTarjeta.ForeColor = System.Drawing.Color.Black;
            this.lbTotallDevolucionTarjeta.Location = new System.Drawing.Point(870, 180);
            this.lbTotallDevolucionTarjeta.Name = "lbTotallDevolucionTarjeta";
            this.lbTotallDevolucionTarjeta.Size = new System.Drawing.Size(273, 25);
            this.lbTotallDevolucionTarjeta.TabIndex = 19;
            this.lbTotallDevolucionTarjeta.Text = "Devolución total en tarjeta: $0.00";
            // 
            // lbltotales
            // 
            this.lbltotales.AutoSize = true;
            this.lbltotales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lbltotales.Location = new System.Drawing.Point(870, 98);
            this.lbltotales.Name = "lbltotales";
            this.lbltotales.Size = new System.Drawing.Size(181, 30);
            this.lbltotales.TabIndex = 17;
            this.lbltotales.Text = "Flujo de Tarjetas";
            // 
            // lblSaldoTotalTarjeta
            // 
            this.lblSaldoTotalTarjeta.AutoSize = true;
            this.lblSaldoTotalTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotalTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblSaldoTotalTarjeta.Location = new System.Drawing.Point(870, 225);
            this.lblSaldoTotalTarjeta.Name = "lblSaldoTotalTarjeta";
            this.lblSaldoTotalTarjeta.Size = new System.Drawing.Size(226, 28);
            this.lblSaldoTotalTarjeta.TabIndex = 20;
            this.lblSaldoTotalTarjeta.Text = "Saldo en tarjeta: $0.00";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.Color.White;
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.Location = new System.Drawing.Point(875, 325);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(250, 48);
            this.BtnAbrir.TabIndex = 21;
            this.BtnAbrir.Text = "ABRIR CORTE";
            this.BtnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Visible = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(682, 412);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(45, 47);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Visible = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnAgregar2
            // 
            this.BtnAgregar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar2.Image")));
            this.BtnAgregar2.Location = new System.Drawing.Point(682, 164);
            this.BtnAgregar2.Name = "BtnAgregar2";
            this.BtnAgregar2.Size = new System.Drawing.Size(45, 47);
            this.BtnAgregar2.TabIndex = 26;
            this.BtnAgregar2.UseVisualStyleBackColor = true;
            this.BtnAgregar2.Visible = false;
            this.BtnAgregar2.Click += new System.EventHandler(this.BtnAgregar2_Click);
            // 
            // Fund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 557);
            this.Controls.Add(this.BtnAgregar2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.lblSaldoTotalTarjeta);
            this.Controls.Add(this.lbltotales);
            this.Controls.Add(this.lbTotallDevolucionTarjeta);
            this.Controls.Add(this.lblVentaContarjeta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFondoQueda);
            this.Controls.Add(this.NudRetiro);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblSaldoEfectivoCaja);
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
        private System.Windows.Forms.Label lblSaldoEfectivoCaja;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.NumericUpDown NudRetiro;
        private System.Windows.Forms.Label lblFondoQueda;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblVentaContarjeta;
        private System.Windows.Forms.Label lbTotallDevolucionTarjeta;
        private System.Windows.Forms.Label lbltotales;
        private System.Windows.Forms.Label lblSaldoTotalTarjeta;
        private Button BtnAbrir;
        private Button BtnAgregar;
        private Button BtnAgregar2;
    }
}
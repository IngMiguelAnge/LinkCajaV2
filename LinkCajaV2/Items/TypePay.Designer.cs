namespace LinkCajaV2.Items
{
    partial class TypePay
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btbEfectivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarjeta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnTarjeta.Location = new System.Drawing.Point(19, 111);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(240, 45);
            this.btnTarjeta.TabIndex = 4;
            this.btnTarjeta.Text = "TARJETA";
            this.btnTarjeta.UseVisualStyleBackColor = false;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btbEfectivo
            // 
            this.btbEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btbEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbEfectivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbEfectivo.ForeColor = System.Drawing.Color.White;
            this.btbEfectivo.Location = new System.Drawing.Point(290, 111);
            this.btbEfectivo.Name = "btbEfectivo";
            this.btbEfectivo.Size = new System.Drawing.Size(240, 45);
            this.btbEfectivo.TabIndex = 3;
            this.btbEfectivo.Text = "EFECTIVO";
            this.btbEfectivo.UseVisualStyleBackColor = false;
            this.btbEfectivo.Click += new System.EventHandler(this.btbEfectivo_Click);
            // 
            // TypePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 208);
            this.ControlBox = false;
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.btbEfectivo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypePay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Button btbEfectivo;
    }
}
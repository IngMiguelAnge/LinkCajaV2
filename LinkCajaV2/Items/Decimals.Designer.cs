namespace LinkCajaV2.Items
{
    partial class Decimals
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
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.NUDKilos = new System.Windows.Forms.NumericUpDown();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.lblMensaje3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKilos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblMensaje1.Location = new System.Drawing.Point(12, 20);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(260, 25);
            this.lblMensaje1.TabIndex = 0;
            this.lblMensaje1.Text = "Este articulo se vende por kilos,";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblMensaje2.Location = new System.Drawing.Point(17, 99);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(53, 25);
            this.lblMensaje2.TabIndex = 1;
            this.lblMensaje2.Text = "Kilos:";
            // 
            // NUDKilos
            // 
            this.NUDKilos.DecimalPlaces = 3;
            this.NUDKilos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDKilos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            this.NUDKilos.Location = new System.Drawing.Point(22, 138);
            this.NUDKilos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDKilos.Name = "NUDKilos";
            this.NUDKilos.Size = new System.Drawing.Size(250, 37);
            this.NUDKilos.TabIndex = 2;
            this.NUDKilos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NUDKilos_KeyDown);
            this.NUDKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUDKilos_KeyPress);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(200, 211);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(162, 49);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "CONFIRMAR";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // lblMensaje3
            // 
            this.lblMensaje3.AutoSize = true;
            this.lblMensaje3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblMensaje3.Location = new System.Drawing.Point(12, 53);
            this.lblMensaje3.Name = "lblMensaje3";
            this.lblMensaje3.Size = new System.Drawing.Size(320, 25);
            this.lblMensaje3.TabIndex = 4;
            this.lblMensaje3.Text = "Porfavor de poner la cantidad a vender";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.Location = new System.Drawing.Point(12, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 49);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Decimals
            // 
            this.AcceptButton = this.BtnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(414, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMensaje3);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.NUDKilos);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.lblMensaje1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Decimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Decimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDKilos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.NumericUpDown NUDKilos;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Label lblMensaje3;
        private System.Windows.Forms.Button btnCancelar;
    }
}
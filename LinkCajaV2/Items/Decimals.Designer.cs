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
            ((System.ComponentModel.ISupportInitialize)(this.NUDKilos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Location = new System.Drawing.Point(12, 20);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(231, 20);
            this.lblMensaje1.TabIndex = 0;
            this.lblMensaje1.Text = "Este articulo se vende por kilos,";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Location = new System.Drawing.Point(57, 104);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(46, 20);
            this.lblMensaje2.TabIndex = 1;
            this.lblMensaje2.Text = "Kilos:";
            // 
            // NUDKilos
            // 
            this.NUDKilos.DecimalPlaces = 3;
            this.NUDKilos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            this.NUDKilos.Location = new System.Drawing.Point(154, 98);
            this.NUDKilos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDKilos.Name = "NUDKilos";
            this.NUDKilos.Size = new System.Drawing.Size(120, 26);
            this.NUDKilos.TabIndex = 2;
            this.NUDKilos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NUDKilos_KeyDown);
            this.NUDKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUDKilos_KeyPress);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(107, 143);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(96, 39);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // lblMensaje3
            // 
            this.lblMensaje3.AutoSize = true;
            this.lblMensaje3.Location = new System.Drawing.Point(12, 53);
            this.lblMensaje3.Name = "lblMensaje3";
            this.lblMensaje3.Size = new System.Drawing.Size(281, 20);
            this.lblMensaje3.TabIndex = 4;
            this.lblMensaje3.Text = "Porfavor de poner la cantidad a vender";
            // 
            // Decimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 208);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensaje3);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.NUDKilos);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.lblMensaje1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Decimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}
namespace LinkCajaV2.Items
{
    partial class Instalador
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.cbLicencias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Location = new System.Drawing.Point(24, 27);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(246, 20);
            this.lblMensaje1.TabIndex = 0;
            this.lblMensaje1.Text = "¿Cual es  la contraseña principal?";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(28, 67);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(302, 26);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(101, 205);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 35);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Location = new System.Drawing.Point(24, 115);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(211, 20);
            this.lblMensaje2.TabIndex = 3;
            this.lblMensaje2.Text = "¿Que licencia quiere activar?";
            // 
            // cbLicencias
            // 
            this.cbLicencias.Enabled = false;
            this.cbLicencias.FormattingEnabled = true;
            this.cbLicencias.Location = new System.Drawing.Point(28, 149);
            this.cbLicencias.Name = "cbLicencias";
            this.cbLicencias.Size = new System.Drawing.Size(302, 28);
            this.cbLicencias.TabIndex = 4;
            // 
            // Instalador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 275);
            this.Controls.Add(this.cbLicencias);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblMensaje1);
            this.MaximizeBox = false;
            this.Name = "Instalador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador";
            this.Load += new System.EventHandler(this.Instalador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.ComboBox cbLicencias;
    }
}
namespace LinkCajaV2.Catalogs
{
    partial class Client
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(31, 168);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 33);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 26);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(453, 69);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(236, 26);
            this.txtTelefono2.TabIndex = 18;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(368, 75);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(84, 20);
            this.lblTelefono2.TabIndex = 17;
            this.lblTelefono2.Text = "Telefono2:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(117, 69);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(221, 26);
            this.txtTelefono1.TabIndex = 16;
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Location = new System.Drawing.Point(27, 75);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(90, 20);
            this.lblTelefono1.TabIndex = 15;
            this.lblTelefono1.Text = "*Telefono1:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(443, 12);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(246, 26);
            this.txtDireccion.TabIndex = 14;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(368, 18);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 20);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "*Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 26);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "*Nombre:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 213);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.lblTelefono1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}
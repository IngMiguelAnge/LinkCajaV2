namespace LinkCajaV2.Items
{
    partial class Note
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
            this.lblMotive = new System.Windows.Forms.Label();
            this.txtMotive = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMotive
            // 
            this.lblMotive.AutoSize = true;
            this.lblMotive.Location = new System.Drawing.Point(26, 23);
            this.lblMotive.Name = "lblMotive";
            this.lblMotive.Size = new System.Drawing.Size(185, 20);
            this.lblMotive.TabIndex = 0;
            this.lblMotive.Text = "Motivo de la cancelación:";
            // 
            // txtMotive
            // 
            this.txtMotive.Location = new System.Drawing.Point(30, 46);
            this.txtMotive.Multiline = true;
            this.txtMotive.Name = "txtMotive";
            this.txtMotive.Size = new System.Drawing.Size(458, 163);
            this.txtMotive.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(30, 231);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 48);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Continuar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 282);
            this.ControlBox = false;
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtMotive);
            this.Controls.Add(this.lblMotive);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotive;
        private System.Windows.Forms.TextBox txtMotive;
        private System.Windows.Forms.Button BtnGuardar;
    }
}
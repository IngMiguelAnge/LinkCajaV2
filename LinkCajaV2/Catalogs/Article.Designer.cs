namespace LinkCajaV2.Catalogs
{
    partial class Article
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.PBProducto = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.CBDevoluciones = new System.Windows.Forms.CheckBox();
            this.lblClaveSAT = new System.Windows.Forms.Label();
            this.txtClaveSAT = new System.Windows.Forms.TextBox();
            this.cbMedicine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "*Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 123);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 171);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "*Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(138, 168);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 83);
            this.txtDescripcion.TabIndex = 7;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(571, 229);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(105, 40);
            this.btnImagen.TabIndex = 10;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // PBProducto
            // 
            this.PBProducto.Location = new System.Drawing.Point(490, 12);
            this.PBProducto.Name = "PBProducto";
            this.PBProducto.Size = new System.Drawing.Size(320, 211);
            this.PBProducto.TabIndex = 15;
            this.PBProducto.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(23, 319);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(108, 35);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "*Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(138, 29);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(334, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // CBDevoluciones
            // 
            this.CBDevoluciones.AutoSize = true;
            this.CBDevoluciones.Location = new System.Drawing.Point(23, 270);
            this.CBDevoluciones.Name = "CBDevoluciones";
            this.CBDevoluciones.Size = new System.Drawing.Size(200, 24);
            this.CBDevoluciones.TabIndex = 8;
            this.CBDevoluciones.Text = "¿Acepta devolusiones?";
            this.CBDevoluciones.UseVisualStyleBackColor = true;
            // 
            // lblClaveSAT
            // 
            this.lblClaveSAT.AutoSize = true;
            this.lblClaveSAT.Location = new System.Drawing.Point(19, 76);
            this.lblClaveSAT.Name = "lblClaveSAT";
            this.lblClaveSAT.Size = new System.Drawing.Size(93, 20);
            this.lblClaveSAT.TabIndex = 2;
            this.lblClaveSAT.Text = "*Clave SAT:";
            // 
            // txtClaveSAT
            // 
            this.txtClaveSAT.Location = new System.Drawing.Point(138, 76);
            this.txtClaveSAT.MaxLength = 50;
            this.txtClaveSAT.Name = "txtClaveSAT";
            this.txtClaveSAT.Size = new System.Drawing.Size(334, 26);
            this.txtClaveSAT.TabIndex = 3;
            // 
            // cbMedicine
            // 
            this.cbMedicine.AutoSize = true;
            this.cbMedicine.Location = new System.Drawing.Point(242, 270);
            this.cbMedicine.Name = "cbMedicine";
            this.cbMedicine.Size = new System.Drawing.Size(172, 24);
            this.cbMedicine.TabIndex = 9;
            this.cbMedicine.Text = "¿Es medicamento?";
            this.cbMedicine.UseVisualStyleBackColor = true;
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 376);
            this.Controls.Add(this.cbMedicine);
            this.Controls.Add(this.txtClaveSAT);
            this.Controls.Add(this.lblClaveSAT);
            this.Controls.Add(this.CBDevoluciones);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PBProducto);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox PBProducto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox CBDevoluciones;
        private System.Windows.Forms.Label lblClaveSAT;
        private System.Windows.Forms.TextBox txtClaveSAT;
        private System.Windows.Forms.CheckBox cbMedicine;
    }
}
namespace LinkCajaV2.Catalogs
{
    partial class Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblHard = new System.Windows.Forms.Label();
            this.txtHard = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPublicidad = new System.Windows.Forms.Label();
            this.CBPublicidad = new System.Windows.Forms.ComboBox();
            this.CBRuleta = new System.Windows.Forms.ComboBox();
            this.lblRuleta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAssetsVisuales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombre.Location = new System.Drawing.Point(24, 62);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(27, 94);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // lblHard
            // 
            this.lblHard.AutoSize = true;
            this.lblHard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblHard.Location = new System.Drawing.Point(24, 135);
            this.lblHard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHard.Name = "lblHard";
            this.lblHard.Size = new System.Drawing.Size(84, 15);
            this.lblHard.TabIndex = 2;
            this.lblHard.Text = "ID del equipo:";
            // 
            // txtHard
            // 
            this.txtHard.Enabled = false;
            this.txtHard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHard.Location = new System.Drawing.Point(27, 163);
            this.txtHard.Margin = new System.Windows.Forms.Padding(2);
            this.txtHard.Name = "txtHard";
            this.txtHard.Size = new System.Drawing.Size(183, 27);
            this.txtHard.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(289, 280);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 31);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.lblTitulo.Location = new System.Drawing.Point(22, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 32);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Información";
            // 
            // lblPublicidad
            // 
            this.lblPublicidad.AutoSize = true;
            this.lblPublicidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblPublicidad.Location = new System.Drawing.Point(237, 62);
            this.lblPublicidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublicidad.Name = "lblPublicidad";
            this.lblPublicidad.Size = new System.Drawing.Size(66, 15);
            this.lblPublicidad.TabIndex = 25;
            this.lblPublicidad.Text = "Publicidad:";
            // 
            // CBPublicidad
            // 
            this.CBPublicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPublicidad.Enabled = false;
            this.CBPublicidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPublicidad.FormattingEnabled = true;
            this.CBPublicidad.Items.AddRange(new object[] {
            "Seleccione",
            "No ver publicidad",
            "Ver publicidad"});
            this.CBPublicidad.Location = new System.Drawing.Point(241, 93);
            this.CBPublicidad.Margin = new System.Windows.Forms.Padding(2);
            this.CBPublicidad.Name = "CBPublicidad";
            this.CBPublicidad.Size = new System.Drawing.Size(183, 28);
            this.CBPublicidad.TabIndex = 26;
            // 
            // CBRuleta
            // 
            this.CBRuleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRuleta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRuleta.FormattingEnabled = true;
            this.CBRuleta.Items.AddRange(new object[] {
            "Seleccione",
            "Activar",
            "Desactivar"});
            this.CBRuleta.Location = new System.Drawing.Point(241, 163);
            this.CBRuleta.Margin = new System.Windows.Forms.Padding(2);
            this.CBRuleta.Name = "CBRuleta";
            this.CBRuleta.Size = new System.Drawing.Size(183, 28);
            this.CBRuleta.TabIndex = 28;
            this.CBRuleta.SelectedIndexChanged += new System.EventHandler(this.CBRuleta_SelectedIndexChanged);
            // 
            // lblRuleta
            // 
            this.lblRuleta.AutoSize = true;
            this.lblRuleta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRuleta.Location = new System.Drawing.Point(237, 133);
            this.lblRuleta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuleta.Name = "lblRuleta";
            this.lblRuleta.Size = new System.Drawing.Size(46, 15);
            this.lblRuleta.TabIndex = 27;
            this.lblRuleta.Text = "Ruleta:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCantidad.Location = new System.Drawing.Point(237, 208);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(143, 15);
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Activar ruleta apartir de:";
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSimbolo.Location = new System.Drawing.Point(237, 233);
            this.lblSimbolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(18, 20);
            this.lblSimbolo.TabIndex = 30;
            this.lblSimbolo.Text = "$";
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(265, 233);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(157, 27);
            this.nudCantidad.TabIndex = 31;
            // 
            // btnAssetsVisuales
            // 
            this.btnAssetsVisuales.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAssetsVisuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssetsVisuales.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAssetsVisuales.ForeColor = System.Drawing.Color.White;
            this.btnAssetsVisuales.Location = new System.Drawing.Point(28, 229);
            this.btnAssetsVisuales.Name = "btnAssetsVisuales";
            this.btnAssetsVisuales.Size = new System.Drawing.Size(150, 30);
            this.btnAssetsVisuales.TabIndex = 32;
            this.btnAssetsVisuales.Text = "Configurar imágenes";
            this.btnAssetsVisuales.UseVisualStyleBackColor = false;
            this.btnAssetsVisuales.Click += new System.EventHandler(this.btnAssetsVisuales_Click);
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 319);
            this.Controls.Add(this.btnAssetsVisuales);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.CBRuleta);
            this.Controls.Add(this.lblRuleta);
            this.Controls.Add(this.CBPublicidad);
            this.Controls.Add(this.lblPublicidad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtHard);
            this.Controls.Add(this.lblHard);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Box";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Box_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblHard;
        private System.Windows.Forms.TextBox txtHard;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPublicidad;
        private System.Windows.Forms.ComboBox CBPublicidad;
        private System.Windows.Forms.ComboBox CBRuleta;
        private System.Windows.Forms.Label lblRuleta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAssetsVisuales;
    }
}
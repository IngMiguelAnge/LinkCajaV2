namespace LinkCajaV2.Catalogs
{
    partial class RetirementConcept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetirementConcept));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.NudRetiro = new System.Windows.Forms.NumericUpDown();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvRetiros = new System.Windows.Forms.DataGridView();
            this.dgRetiros = new System.Windows.Forms.GroupBox();
            this.lblConcept = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpRetiro = new System.Windows.Forms.DateTimePicker();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudRetiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiros)).BeginInit();
            this.dgRetiros.SuspendLayout();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRetiro.Location = new System.Drawing.Point(22, 110);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(76, 25);
            this.lblRetiro.TabIndex = 2;
            this.lblRetiro.Text = "Retirar:";
            // 
            // NudRetiro
            // 
            this.NudRetiro.DecimalPlaces = 2;
            this.NudRetiro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudRetiro.Location = new System.Drawing.Point(27, 138);
            this.NudRetiro.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudRetiro.Name = "NudRetiro";
            this.NudRetiro.Size = new System.Drawing.Size(161, 37);
            this.NudRetiro.TabIndex = 3;
            this.NudRetiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NudRetiro_KeyUp);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(824, 53);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(147, 41);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvRetiros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRetiros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRetiros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRetiros.BackgroundColor = System.Drawing.Color.White;
            this.dgvRetiros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRetiros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRetiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRetiros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRetiros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRetiros.EnableHeadersVisualStyles = false;
            this.dgvRetiros.Location = new System.Drawing.Point(3, 35);
            this.dgvRetiros.Name = "dgvRetiros";
            this.dgvRetiros.RowHeadersWidth = 62;
            this.dgvRetiros.RowTemplate.Height = 28;
            this.dgvRetiros.Size = new System.Drawing.Size(1049, 236);
            this.dgvRetiros.TabIndex = 9;
            this.dgvRetiros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRetiros_CellContentClick);
            // 
            // dgRetiros
            // 
            this.dgRetiros.Controls.Add(this.dgvRetiros);
            this.dgRetiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgRetiros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRetiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.dgRetiros.Location = new System.Drawing.Point(34, 209);
            this.dgRetiros.Name = "dgRetiros";
            this.dgRetiros.Size = new System.Drawing.Size(1055, 274);
            this.dgRetiros.TabIndex = 8;
            this.dgRetiros.TabStop = false;
            this.dgRetiros.Text = "Retiros";
            // 
            // lblConcept
            // 
            this.lblConcept.AutoSize = true;
            this.lblConcept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblConcept.Location = new System.Drawing.Point(474, 23);
            this.lblConcept.Name = "lblConcept";
            this.lblConcept.Size = new System.Drawing.Size(98, 25);
            this.lblConcept.TabIndex = 4;
            this.lblConcept.Text = "Concepto:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(479, 51);
            this.txtMotivo.MaxLength = 50;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(317, 124);
            this.txtMotivo.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(818, 134);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(153, 41);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblFecha.Location = new System.Drawing.Point(22, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(144, 25);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de retiro:";
            // 
            // dtpRetiro
            // 
            this.dtpRetiro.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpRetiro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetiro.Location = new System.Drawing.Point(27, 51);
            this.dtpRetiro.Name = "dtpRetiro";
            this.dtpRetiro.Size = new System.Drawing.Size(424, 37);
            this.dtpRetiro.TabIndex = 1;
            this.dtpRetiro.ValueChanged += new System.EventHandler(this.dtpRetiro_ValueChanged);
            // 
            // GBOpciones
            // 
            this.GBOpciones.Controls.Add(this.dtpRetiro);
            this.GBOpciones.Controls.Add(this.btnActualizar);
            this.GBOpciones.Controls.Add(this.lblRetiro);
            this.GBOpciones.Controls.Add(this.txtMotivo);
            this.GBOpciones.Controls.Add(this.btnNuevo);
            this.GBOpciones.Controls.Add(this.lblFecha);
            this.GBOpciones.Controls.Add(this.lblConcept);
            this.GBOpciones.Controls.Add(this.NudRetiro);
            this.GBOpciones.Location = new System.Drawing.Point(37, 8);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(1052, 195);
            this.GBOpciones.TabIndex = 9;
            this.GBOpciones.TabStop = false;
            // 
            // RetirementConcept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 524);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.dgRetiros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RetirementConcept";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RetirementConcept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudRetiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiros)).EndInit();
            this.dgRetiros.ResumeLayout(false);
            this.GBOpciones.ResumeLayout(false);
            this.GBOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.NumericUpDown NudRetiro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvRetiros;
        private System.Windows.Forms.GroupBox dgRetiros;
        private System.Windows.Forms.Label lblConcept;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.GroupBox GBOpciones;
    }
}
namespace LinkCajaV2.Items
{
    partial class VisualAssetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualAssetsForm));
            this.WinnerGroup = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbTipoAsset = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.WinnerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // WinnerGroup
            // 
            this.WinnerGroup.BackColor = System.Drawing.Color.Transparent;
            this.WinnerGroup.Controls.Add(this.BtnGuardar);
            this.WinnerGroup.Controls.Add(this.lblTipo);
            this.WinnerGroup.Controls.Add(this.lblInfo);
            this.WinnerGroup.Controls.Add(this.cbTipoAsset);
            this.WinnerGroup.Controls.Add(this.btnSeleccionar);
            this.WinnerGroup.Controls.Add(this.pbPreview);
            this.WinnerGroup.Location = new System.Drawing.Point(12, 12);
            this.WinnerGroup.Name = "WinnerGroup";
            this.WinnerGroup.Size = new System.Drawing.Size(296, 344);
            this.WinnerGroup.TabIndex = 0;
            this.WinnerGroup.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(143, 297);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(133, 31);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTipo.Location = new System.Drawing.Point(21, 23);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(70, 15);
            this.lblTipo.TabIndex = 30;
            this.lblTipo.Text = "Seleccione:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblInfo.Location = new System.Drawing.Point(21, 268);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(75, 15);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Info Imagen";
            // 
            // cbTipoAsset
            // 
            this.cbTipoAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAsset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoAsset.FormattingEnabled = true;
            this.cbTipoAsset.Items.AddRange(new object[] {
            "Ganador",
            "No Ganador"});
            this.cbTipoAsset.Location = new System.Drawing.Point(21, 49);
            this.cbTipoAsset.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoAsset.Name = "cbTipoAsset";
            this.cbTipoAsset.Size = new System.Drawing.Size(183, 28);
            this.cbTipoAsset.TabIndex = 29;
            this.cbTipoAsset.SelectedIndexChanged += new System.EventHandler(this.cbTipoAsset_SelectedIndexChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(21, 237);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(148, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar imagen";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(21, 91);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(255, 130);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 1;
            this.pbPreview.TabStop = false;
            // 
            // VisualAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 368);
            this.Controls.Add(this.WinnerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualAssetsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VisualAssetsForm_Load);
            this.WinnerGroup.ResumeLayout(false);
            this.WinnerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WinnerGroup;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox cbTipoAsset;
        private System.Windows.Forms.Label lblTipo;
    }
}
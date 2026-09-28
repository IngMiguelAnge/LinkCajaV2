namespace LinkCajaV2.Catalogs
{
    partial class Bundle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bundle));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.PBProducto = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.grpComponentes = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblCostoGramo = new System.Windows.Forms.Label();
            this.nudCada = new System.Windows.Forms.NumericUpDown();
            this.lblPor = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoReceta = new System.Windows.Forms.Label();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.PBSeleccion = new System.Windows.Forms.PictureBox();
            this.grpDatosPaquete = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).BeginInit();
            this.grpComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            this.grpResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSeleccion)).BeginInit();
            this.grpDatosPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(14, 149);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(232, 55);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDescripcion.Location = new System.Drawing.Point(11, 132);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 15);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "*Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(14, 45);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblNombre.Location = new System.Drawing.Point(11, 28);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // PBProducto
            // 
            this.PBProducto.Location = new System.Drawing.Point(344, 45);
            this.PBProducto.Margin = new System.Windows.Forms.Padding(2);
            this.PBProducto.Name = "PBProducto";
            this.PBProducto.Size = new System.Drawing.Size(213, 137);
            this.PBProducto.TabIndex = 17;
            this.PBProducto.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnImagen.ForeColor = System.Drawing.Color.White;
            this.btnImagen.Location = new System.Drawing.Point(412, 195);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(90, 25);
            this.btnImagen.TabIndex = 6;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblAgregar.Location = new System.Drawing.Point(735, 572);
            this.lblAgregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(293, 15);
            this.lblAgregar.TabIndex = 7;
            this.lblAgregar.Text = "Agregue los artículos que forman parte del paquete";
            this.lblAgregar.Visible = false;
            // 
            // grpComponentes
            // 
            this.grpComponentes.Controls.Add(this.dgvArticulos);
            this.grpComponentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.grpComponentes.Location = new System.Drawing.Point(12, 338);
            this.grpComponentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpComponentes.Name = "grpComponentes";
            this.grpComponentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpComponentes.Size = new System.Drawing.Size(589, 284);
            this.grpComponentes.TabIndex = 13;
            this.grpComponentes.TabStop = false;
            this.grpComponentes.Text = "Componentes del paquete";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.Color.White;
            this.dgvArticulos.Location = new System.Drawing.Point(4, 26);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.Size = new System.Drawing.Size(581, 241);
            this.dgvArticulos.TabIndex = 14;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvArticulos_CellPainting);
            this.dgvArticulos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvArticulos_CellValidating);
            this.dgvArticulos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellValueChanged);
            this.dgvArticulos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvArticulos_EditingControlShowing);
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCantidad.Location = new System.Drawing.Point(14, 264);
            this.NUDCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.NUDCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(80, 23);
            this.NUDCantidad.TabIndex = 4;
            this.NUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCantidad.Location = new System.Drawing.Point(10, 245);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(118, 262);
            this.txtCodigoBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(224, 25);
            this.txtCodigoBusqueda.TabIndex = 5;
            this.txtCodigoBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCodigo.Location = new System.Drawing.Point(115, 243);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(122, 15);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código del producto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(17, 35);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(290, 18);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Se tiene que vender minimo en: $0.00";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(893, 358);
            this.lblMedida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(19, 13);
            this.lblMedida.TabIndex = 25;
            this.lblMedida.Text = "----";
            this.lblMedida.Visible = false;
            // 
            // lblCostoGramo
            // 
            this.lblCostoGramo.AutoSize = true;
            this.lblCostoGramo.Location = new System.Drawing.Point(720, 400);
            this.lblCostoGramo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoGramo.Name = "lblCostoGramo";
            this.lblCostoGramo.Size = new System.Drawing.Size(87, 13);
            this.lblCostoGramo.TabIndex = 22;
            this.lblCostoGramo.Text = "Costo por gramo:";
            this.lblCostoGramo.Visible = false;
            // 
            // nudCada
            // 
            this.nudCada.Location = new System.Drawing.Point(845, 373);
            this.nudCada.Margin = new System.Windows.Forms.Padding(2);
            this.nudCada.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCada.Name = "nudCada";
            this.nudCada.Size = new System.Drawing.Size(80, 20);
            this.nudCada.TabIndex = 24;
            this.nudCada.Visible = false;
            this.nudCada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudCada_KeyUp);
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(720, 374);
            this.lblPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(114, 13);
            this.lblPor.TabIndex = 21;
            this.lblPor.Text = "En la compra de cada:";
            this.lblPor.Visible = false;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(83, 66);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(134, 25);
            this.nudPrecio.TabIndex = 6;
            this.nudPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudPrecio_KeyUp);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblPrecio.Location = new System.Drawing.Point(17, 68);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 17);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio:";
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(723, 349);
            this.cbPresentacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(82, 21);
            this.cbPresentacion.TabIndex = 18;
            this.cbPresentacion.Visible = false;
            this.cbPresentacion.SelectedIndexChanged += new System.EventHandler(this.cbPresentacion_SelectedIndexChanged);
            // 
            // nudExistencias
            // 
            this.nudExistencias.Location = new System.Drawing.Point(948, 374);
            this.nudExistencias.Margin = new System.Windows.Forms.Padding(2);
            this.nudExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(80, 20);
            this.nudExistencias.TabIndex = 19;
            this.nudExistencias.Visible = false;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(822, 404);
            this.lblExistencias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(221, 13);
            this.lblExistencias.TabIndex = 17;
            this.lblExistencias.Text = "El inventario incrementara sus existencias en:";
            this.lblExistencias.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 100);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(232, 25);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigoReceta
            // 
            this.lblCodigoReceta.AutoSize = true;
            this.lblCodigoReceta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigoReceta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCodigoReceta.Location = new System.Drawing.Point(11, 83);
            this.lblCodigoReceta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoReceta.Name = "lblCodigoReceta";
            this.lblCodigoReceta.Size = new System.Drawing.Size(119, 15);
            this.lblCodigoReceta.TabIndex = 4;
            this.lblCodigoReceta.Text = "*Código del paquete";
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblMensaje1.Location = new System.Drawing.Point(720, 323);
            this.lblMensaje1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(344, 15);
            this.lblMensaje1.TabIndex = 28;
            this.lblMensaje1.Text = "Al crear esta receta el articulo generado se presentara como:";
            this.lblMensaje1.Visible = false;
            // 
            // grpResumen
            // 
            this.grpResumen.Controls.Add(this.btnGuardar);
            this.grpResumen.Controls.Add(this.lblTotal);
            this.grpResumen.Controls.Add(this.lblPrecio);
            this.grpResumen.Controls.Add(this.nudPrecio);
            this.grpResumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.grpResumen.Location = new System.Drawing.Point(12, 626);
            this.grpResumen.Margin = new System.Windows.Forms.Padding(2);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Padding = new System.Windows.Forms.Padding(2);
            this.grpResumen.Size = new System.Drawing.Size(584, 153);
            this.grpResumen.TabIndex = 29;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(10, 107);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 31);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.chkActivo.Location = new System.Drawing.Point(800, 606);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(68, 23);
            this.chkActivo.TabIndex = 32;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.Visible = false;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(974, 500);
            this.lblSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(110, 13);
            this.lblSeleccionado.TabIndex = 31;
            this.lblSeleccionado.Text = "Articulo Seleccionado";
            this.lblSeleccionado.Visible = false;
            // 
            // PBSeleccion
            // 
            this.PBSeleccion.Location = new System.Drawing.Point(757, 433);
            this.PBSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.PBSeleccion.Name = "PBSeleccion";
            this.PBSeleccion.Size = new System.Drawing.Size(213, 137);
            this.PBSeleccion.TabIndex = 30;
            this.PBSeleccion.TabStop = false;
            this.PBSeleccion.Visible = false;
            // 
            // grpDatosPaquete
            // 
            this.grpDatosPaquete.Controls.Add(this.btnAgregar);
            this.grpDatosPaquete.Controls.Add(this.PBProducto);
            this.grpDatosPaquete.Controls.Add(this.lblCodigoReceta);
            this.grpDatosPaquete.Controls.Add(this.txtCodigoBusqueda);
            this.grpDatosPaquete.Controls.Add(this.lblCodigo);
            this.grpDatosPaquete.Controls.Add(this.NUDCantidad);
            this.grpDatosPaquete.Controls.Add(this.lblCantidad);
            this.grpDatosPaquete.Controls.Add(this.txtCodigo);
            this.grpDatosPaquete.Controls.Add(this.btnImagen);
            this.grpDatosPaquete.Controls.Add(this.txtNombre);
            this.grpDatosPaquete.Controls.Add(this.lblNombre);
            this.grpDatosPaquete.Controls.Add(this.lblDescripcion);
            this.grpDatosPaquete.Controls.Add(this.txtDescripcion);
            this.grpDatosPaquete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDatosPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(203)))));
            this.grpDatosPaquete.Location = new System.Drawing.Point(11, 3);
            this.grpDatosPaquete.Name = "grpDatosPaquete";
            this.grpDatosPaquete.Size = new System.Drawing.Size(588, 314);
            this.grpDatosPaquete.TabIndex = 30;
            this.grpDatosPaquete.TabStop = false;
            this.grpDatosPaquete.Text = "Datos de el paquete";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(58)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(412, 256);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 33);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Bundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 790);
            this.Controls.Add(this.grpDatosPaquete);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.grpResumen);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.lblMensaje1);
            this.Controls.Add(this.PBSeleccion);
            this.Controls.Add(this.nudExistencias);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.grpComponentes);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.nudCada);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.lblCostoGramo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Bundle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Bundle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).EndInit();
            this.grpComponentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            this.grpResumen.ResumeLayout(false);
            this.grpResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSeleccion)).EndInit();
            this.grpDatosPaquete.ResumeLayout(false);
            this.grpDatosPaquete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox PBProducto;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.GroupBox grpComponentes;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblCostoGramo;
        private System.Windows.Forms.NumericUpDown nudCada;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.NumericUpDown nudExistencias;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoReceta;
        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.PictureBox PBSeleccion;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.GroupBox grpDatosPaquete;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
    }
}
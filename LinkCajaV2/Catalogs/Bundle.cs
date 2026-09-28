using ImageMagick;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{

    public partial class Bundle : System.Windows.Forms.Form
    {
        private SoundPlayer lectorSonido;
        public int Id { get; set; }
        private bool isLoaded = false;
        private decimal _precioMinimoRecomendado = 0m;
        public Bundle()
        {
            InitializeComponent();
            nudPrecio.TextChanged += (s, e) => CalcularPrecioPorGramo();
            nudCada.TextChanged += (s, e) => CalcularPrecioPorGramo();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selector = new OpenFileDialog();
            selector.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (selector.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Usamos MagickImage para leer el archivo (aunque sea WebP con extensión .jpg)
                    using (MagickImage image = new MagickImage(selector.FileName))
                    {
                        // 2. Definimos explícitamente el formato a Bmp para asegurar compatibilidad
                        image.Format = MagickFormat.Bmp;

                        // 3. Obtenemos los bytes de la imagen convertida
                        byte[] bytes = image.ToByteArray();

                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            // 4. CREAR UN NUEVO BITMAP: Esto es vital. 
                            // Al hacer 'new Bitmap(ms)', el PictureBox ya no depende del stream.
                            Bitmap bmp = new Bitmap(ms);

                            // 5. Limpieza de memoria de la imagen anterior
                            if (PBProducto.Image != null)
                            {
                                PBProducto.Image.Dispose();
                            }

                            // 6. Asignamos la nueva imagen y refrescamos
                            PBProducto.Image = bmp;
                            PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                            PBProducto.Refresh(); // Forzamos al control a redibujarse
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error visualizando la imagen: " + ex.Message);
                }
            }
        }
        public byte[] ImageToByteArray()
        {
            if (PBProducto.Image == null) return null;

            // Creamos una copia de la imagen para evitar bloqueos de GDI+
            using (Bitmap tempImage = new Bitmap(PBProducto.Image))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Forzamos el guardado en un formato específico (ej. Png o Jpeg)
                    // Esto es mucho más seguro que usar RawFormat
                    tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    return ms.ToArray();
                }
            }
        }
        private async void Bundle_Load(object sender, EventArgs e)
        {
            
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "beep.wav");
            lectorSonido = new SoundPlayer(ruta);
            AppRepository obj = new AppRepository();
            var ListPresentation = await obj.GetPresentations();
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione", Decimals = 0 });
            cbPresentacion.DisplayMember = "Name";
            cbPresentacion.ValueMember = "Id";
            cbPresentacion.DataSource = ListPresentation;
            cbPresentacion.SelectedIndex = 0;
            CrearGridView();
            if (Id == 0)
            {
                chkActivo.Checked = true;
                isLoaded = true;
                return;
            }
            var Recipe = await obj.GetRecipeByIdorCode(Id, string.Empty);
            txtNombre.Text = Recipe.Name;
            txtDescripcion.Text = Recipe.Description;
            if (Recipe.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(Recipe.Image))
                {
                    PBProducto.Image = Image.FromStream(ms);
                    PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            txtCodigo.Text = Recipe.Code;
            nudPrecio.Value = Recipe.Price;
            chkActivo.Checked = Recipe.Status;
            var lista = await Task.Run(() => obj.GetItemsRecipe(Id));

            if (lista != null)
            {
                // Usamos BindingList para que sea fácil agregar/quitar después
                var bindingList = new BindingList<ItemsRecipeModel>(lista);
                dgvArticulos.DataSource = bindingList;
                ActualizarTotalGeneral();
            }

        
        }
        public async void AgregarArticulo(int id, string codigo)
        {
            AppRepository obj = new AppRepository();

            // Buscar artículo activo por Id o código
            var Articulo = await obj.GetArticleActive(id, codigo);

            if (Articulo == null)
            {
                MessageBox.Show(
                    "Código no válido o artículo inactivo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Obtener la lista enlazada al grid
            var bindingList =
                dgvArticulos.DataSource as BindingList<ItemsRecipeModel>;

            if (bindingList == null)
            {
                bindingList = new BindingList<ItemsRecipeModel>();
                dgvArticulos.DataSource = bindingList;
            }

            // Obtener presentación del artículo
            var Presentacion =
                await obj.GetPresentationbyId(Articulo.IdPresentation);

            if (Presentacion == null)
            {
                MessageBox.Show(
                    "No se encontró la presentación del artículo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Cantidad indicada para el paquete
            decimal cantidad = NUDCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "Ingrese una cantidad mayor a cero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Precio unitario
            decimal precioFinal = Articulo.Price;

            // Si maneja decimales/granel
            if (Presentacion.Decimals > 0)
            {
                if (Articulo.SuggestedStock > 0)
                {
                    precioFinal =
                        Articulo.Price /
                        (Articulo.SuggestedStock * 1000);
                }
            }

            // Revisar si el SKU ya está en el paquete
            var itemExistente =
                bindingList.FirstOrDefault(
                    x => x.IdArticle == Articulo.Id
                );

            if (itemExistente != null)
            {
                // Aumentar cantidad
                itemExistente.Stock += cantidad;

                dgvArticulos.Refresh();
            }
            else
            {
                // Agregar nuevo componente
                bindingList.Add(new ItemsRecipeModel
                {
                    IdArticle = Articulo.Id,
                    Code = Articulo.Code,
                    Name = Articulo.Name,
                    Stock = cantidad,
                    Presentation = Presentacion.Name,
                    Price = precioFinal,
                    Decimals = Presentacion.Decimals,
                    Image = Articulo.Image
                });
            }

            // Mostrar imagen del último artículo agregado
            if (Articulo.Image != null)
            {
                using (MemoryStream ms =
                    new MemoryStream(Articulo.Image))
                {
                    PBSeleccion.Image = Image.FromStream(ms);
                    PBSeleccion.SizeMode =
                        PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                PBSeleccion.Image = null;
            }

            // Actualizar precio lista base
            ActualizarTotalGeneral();

            // Limpiar para el siguiente artículo
            NUDCantidad.Value = 1;
            txtCodigoBusqueda.Clear();
            txtCodigoBusqueda.Focus();
        }
        public string CalcularPrecioPorGramo(decimal Precio, decimal Cada)
        {
            if (Cada > 0)
            {
                //Precio / (Kilos * 1000)
                decimal resultado = Precio / (Cada * 1000);
                return resultado.ToString("N4"); // N4 es mejor para gramos
            }
            else
            {
                return "0.00";
            }
        }
        public void CrearGridView()
        {
            dgvArticulos.Columns.Clear();
            dgvArticulos.AutoGenerateColumns = false;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "IdArticle",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Code",
                ReadOnly = true,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                ReadOnly = true,
                Width = 300
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Stock",
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Presentacion",
                HeaderText = "Presentación",
                DataPropertyName = "Presentation",
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "Price",
                DefaultCellStyle = { Format = "C4" },
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total",
                DataPropertyName = "Total",
                DefaultCellStyle = { Format = "C2" },
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "Quitar",
                HeaderText = "Acción",
                Text = "Quitar",
                UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                Width = 80,
                FlatStyle = FlatStyle.Flat
            };

            //Boton
            btnEliminar.DefaultCellStyle.BackColor =Color.FromArgb(245, 245, 245);
            btnEliminar.DefaultCellStyle.ForeColor = Color.FromArgb(0, 102, 204);
            btnEliminar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            btnEliminar.DefaultCellStyle.SelectionForeColor =Color.FromArgb(0, 102, 204);
            btnEliminar.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArticulos.Columns.Add(btnEliminar);

            // TAMAÑO DE COLUMNAS
            dgvArticulos.Columns["Codigo"].Width = 100;
            dgvArticulos.Columns["Nombre"].Width = 260;
            dgvArticulos.Columns["Cantidad"].Width = 90;
            dgvArticulos.Columns["Presentacion"].Width = 120;
            dgvArticulos.Columns["Precio"].Width = 100;
            dgvArticulos.Columns["Total"].Width = 100;
            dgvArticulos.Columns["Quitar"].Width = 90;           
            // CONFIGURACIÓN GENERAL         
            dgvArticulos.EnableHeadersVisualStyles = false;
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.BackgroundColor = Color.White;
            dgvArticulos.BorderStyle = BorderStyle.FixedSingle;
            dgvArticulos.GridColor = Color.FromArgb(220, 220, 220);
            dgvArticulos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvArticulos.RowTemplate.Height = 32;
            // HEADER
            dgvArticulos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 112, 192);
            dgvArticulos.ColumnHeadersDefaultCellStyle.ForeColor =Color.White;
            dgvArticulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvArticulos.ColumnHeadersDefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleLeft;
            dgvArticulos.ColumnHeadersHeight = 36;
            // FILAS         
            dgvArticulos.DefaultCellStyle.BackColor =Color.White;
            dgvArticulos.DefaultCellStyle.ForeColor =Color.FromArgb(0, 102, 204);
            dgvArticulos.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);         
            // FILA SELECCIONADA
            dgvArticulos.DefaultCellStyle.SelectionBackColor =Color.FromArgb(230, 240, 250);
            dgvArticulos.DefaultCellStyle.SelectionForeColor =Color.FromArgb(0, 102, 204);
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lectorSonido.Play(); // Reproducción instantánea sin lag
                e.SuppressKeyPress = true;
                AgregarArticulo(0, txtCodigoBusqueda.Text);
                txtCodigoBusqueda.Clear();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articles article = new Articles();
            article.IsVenta = true;
            if (article.ShowDialog() == DialogResult.OK)
            {
                AgregarArticulo(article.IdSeleccionado, string.Empty);
                txtCodigoBusqueda.Clear();
            }
        }
        private void dgvArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validaciones iniciales
            if (e.RowIndex < 0 || dgvArticulos.Columns[e.ColumnIndex].Name != "Cantidad") return;

            // 2. Manejo del punto inicial (".5" -> "0.5")
            string valor = dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value?.ToString() ?? "0";
            if (valor.StartsWith("."))
            {
                dgvArticulos.CellValueChanged -= dgvArticulos_CellValueChanged;
                dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value = "0" + valor;
                dgvArticulos.CellValueChanged += dgvArticulos_CellValueChanged;
            }

            dgvArticulos.InvalidateRow(e.RowIndex);

            ActualizarTotalGeneral();
        }
        private void dgvArticulos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvArticulos.CurrentCell.ColumnIndex == dgvArticulos.Columns["Cantidad"].Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= Cantidad_KeyPress;
                    txt.KeyPress += Cantidad_KeyPress;
                }
            }
        }
        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Obtenemos el formato actual de la columna para saber si permitimos puntos
            string formato = dgvArticulos.Columns["Cantidad"].DefaultCellStyle.Format;

            // 1. Si el formato es "0" (Piezas), BLOQUEAMOS el punto decimal completamente
            if (formato == "0")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            // 2. Si el formato permite decimales ("0.000")
            else
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    // Controlar que no meta más de 3 decimales
                    if (txt.Text.Contains(".") && !char.IsControl(e.KeyChar))
                    {
                        string[] partes = txt.Text.Split('.');
                        if (partes[1].Length >= 3 && txt.SelectionLength == 0)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else if (e.KeyChar == '.')
                {
                    // Solo un punto permitido
                    e.Handled = txt.Text.Contains(".");
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void dgvArticulos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // 1. Solo validamos la columna "Cantidad"
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                string valor = e.FormattedValue.ToString();

                // 2. Si la celda está vacía, no hacemos nada (o podrías poner e.Cancel = true si es obligatorio)
                if (string.IsNullOrEmpty(valor)) return;

                // 3. Intentamos convertir a decimal
                if (!decimal.TryParse(valor, out decimal resultado))
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida", "Error de formato");
                    e.Cancel = true;
                    return;
                }

                // 4. VALIDACIÓN DE ORO: Miramos los decimales permitidos del OBJETO en esta fila
                var item = (ItemsRecipeModel)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

                if (item != null && item.Decimals == 0) // Es modo piezas
                {
                    // Verificamos si el número ingresado tiene parte decimal
                    if (resultado % 1 != 0)
                    {
                        MessageBox.Show("Este artículo no permite decimales.", "Validación");
                        e.Cancel = true;
                    }
                }
            }
        }
        private void dgvArticulos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvArticulos.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Dibujamos un borde gris oscuro simulando un TextBox
                using (System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Gray, 1))
                {
                    Rectangle rect = e.CellBounds;
                    rect.Width -= 2;
                    rect.Height -= 2;
                    e.Graphics.DrawRectangle(p, rect);
                }

                e.Handled = true;
            }
        }
        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "Quitar":
                    // 2. Obtener la lista que está enlazada al Grid
                    var bindingList = (BindingList<ItemsRecipeModel>)dgvArticulos.DataSource;

                    if (bindingList != null)
                    {
                        // 3. Borrar el objeto de la lista (el Grid se actualiza solo)
                        bindingList.RemoveAt(e.RowIndex);

                        // 4. Recalcular el total que muestras en el Label
                        ActualizarTotalGeneral();
                    }
                    break;
            }
        }
        private void ActualizarTotalGeneral()
        {
            var bindingList =dgvArticulos.DataSource as BindingList<ItemsRecipeModel>;

            if (bindingList != null && bindingList.Count > 0)
            {
                decimal totalGeneral =bindingList.Sum(item => item.Total);
                // Guardamos el precio mínimo recomendado
                _precioMinimoRecomendado = totalGeneral;

                lblTotal.Text = $"Se tiene que vender mínimo en: {_precioMinimoRecomendado:C2}";
            }
            else
            {
                _precioMinimoRecomendado = 0m;

                lblTotal.Text ="Se tiene que vender mínimo en: $0.00";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||string.IsNullOrWhiteSpace(txtNombre.Text) ||dgvArticulos.RowCount <= 0 ||nudPrecio.Value <= 0)
            {
                MessageBox.Show( "Datos incompletos. Revise la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

            }
            //if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
            //   string.IsNullOrEmpty(txtNombre.Text) || (int)cbPresentacion.SelectedValue == 0 ||
            //  dgvArticulos.RowCount <= 0 || nudExistencias.Value <= 0 || nudPrecio.Value <= 0 ||
            //  nudCada.Value <= 0)
            //{
            //    MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            AppRepository obj = new AppRepository();
            var exist = obj.GetRecipeByIdorCode(0, txtCodigo.Text).Result;
            if (exist != null && exist.Id != Id)
            {
                MessageBox.Show("Ya se encuentra el codigo en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudPrecio.Value < _precioMinimoRecomendado)
            {
                DialogResult respuesta = MessageBox.Show(
                    $"El precio de venta ingresado ({nudPrecio.Value:C2}) " +
                    $"es menor al precio mínimo recomendado ({_precioMinimoRecomendado:C2}).\n\n" +
                    "Vender este paquete a un precio menor puede reducir el margen de ganancia " +
                    "respecto a la venta individual de sus componentes.\n\n" +
                    "¿Desea continuar de todos modos?",
                    "Advertencia de precio",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.No)
                {
                    nudPrecio.Focus();
                    return;
                }
            }
            RecipeModel Receta = new RecipeModel()
            {
                Id = Id,
                Name = txtNombre.Text,
                Description = txtDescripcion.Text,
                Image = PBProducto.Image != null ? ImageToByteArray() : null,
                Code = txtCodigo.Text,
                Stock = 0,
                IdPresentation = 0,
                Price = nudPrecio.Value,
                SuggestedStock = 0,
                Status = chkActivo.Checked
            };
            Receta.Id = obj.SaveRecipe(Receta).Result;
            if (Receta.Id > 0)
            {
                var r = obj.UpdateAllStatusItems(Receta.Id).Result;
                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    ItemModel item = new ItemModel()
                    {
                        IdRecipe = Receta.Id,
                        IdArticle = Convert.ToInt32(fila.Cells["Id"].Value.ToString()),
                        Use_Stock = Convert.ToDecimal(fila.Cells["Cantidad"].Value),
                    };
                    obj.SaveItem(item).Wait();
                }
                MessageBox.Show("Articulo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void cbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            CambiarPresentacion();
        }
        public void CambiarPresentacion()
        {
            if (cbPresentacion.SelectedIndex > 0)
            {
                if (cbPresentacion.SelectedItem is ListPresentationsModel row)
                {
                    lblMedida.Text = row.Name;

                    int decimals = row.Decimals;

                    if (decimals == 3)
                    {
                        nudExistencias.DecimalPlaces = 3;
                        nudExistencias.Increment = 0.010M;
                        nudExistencias.Maximum = 10000;
                        nudCada.DecimalPlaces = 3;
                        nudCada.Maximum = 1000000;
                        nudCada.Increment = 0.010M;
                        nudCada.Enabled = true;

                        if (isLoaded)
                        {
                            nudExistencias.Value = 0.000M;
                            nudCada.Value = 0.000M;
                        }
                    }
                    else
                    {
                        nudExistencias.DecimalPlaces = 0;
                        nudExistencias.Increment = 1M;
                        nudExistencias.Maximum = 1000000;
                        nudCada.DecimalPlaces = 0;
                        nudCada.Maximum = 1000000;
                        nudCada.Increment = 1M;
                        nudCada.Enabled = false;

                        if (isLoaded)
                        {
                            nudExistencias.Value = 0;
                            nudCada.Value = 1;
                        }
                    }
                    if (decimals > 1)
                    {
                        lblCostoGramo.Visible = true;
                        CalcularPrecioPorGramo();
                    }
                    else
                    {
                        lblCostoGramo.Visible = false;
                    }
                }
            }
        }
        public void CalcularPrecioPorGramo()
        {
            string submedida = lblMedida.Text == "Kg" ? "gramo" :
                             lblMedida.Text == "L" ? "mililitro" :
                             lblMedida.Text == "M" ? "centimetro" : lblMedida.Text;
            lblCostoGramo.Text = "El costo por " + submedida + " es";
            string txtP = nudPrecio.Text.Replace("$", "").Trim();
            string txtC = nudCada.Text.Trim();

            decimal.TryParse(txtP, out decimal vPrecio);
            decimal.TryParse(txtC, out decimal vCada);

            if (vCada > 0)
            {
                //Precio / (Kilos * 1000)
                decimal resultado = vPrecio / (vCada * 1000);
                lblCostoGramo.Text += " $" + resultado.ToString("N4"); // N4 es mejor para gramos
            }
            else
            {
                lblCostoGramo.Text += " $" + "0.00";
            }
        }
        private void nudPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            DomainUpDown dud = sender as DomainUpDown;
            if (dud == null) return;

            // Buscamos el TextBox interno de forma segura
            TextBox tb = null;
            foreach (Control c in dud.Controls)
            {
                if (c is TextBox)
                {
                    tb = (TextBox)c;
                    break;
                }
            }

            if (tb != null)
            {
                int cursorPosition = tb.SelectionStart;
                CalcularPrecioPorGramo();
                tb.SelectionStart = cursorPosition;
            }
            else
            {
                CalcularPrecioPorGramo();
            }
        }
        private void nudCada_KeyUp(object sender, KeyEventArgs e)
        {
            DomainUpDown dud = sender as DomainUpDown;
            if (dud == null) return;

            // Buscamos el TextBox interno de forma segura
            TextBox tb = null;
            foreach (Control c in dud.Controls)
            {
                if (c is TextBox)
                {
                    tb = (TextBox)c;
                    break;
                }
            }

            if (tb != null)
            {
                int cursorPosition = tb.SelectionStart;
                CalcularPrecioPorGramo();
                tb.SelectionStart = cursorPosition;
            }
            else
            {
                CalcularPrecioPorGramo();
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (ItemsRecipeModel)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

            if (item != null)
            {
                if (item.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream(item.Image))
                    {
                        PBSeleccion.Image = Image.FromStream(ms);
                        PBSeleccion.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    // 4. Si no tiene imagen, poner una por defecto o limpiar
                    PBSeleccion.Image = null; // O poner una imagen de "Sin imagen"
                }
            }
        }
    }
}

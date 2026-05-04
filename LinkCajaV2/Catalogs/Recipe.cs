using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Recipe : Form
    {
        private SoundPlayer lectorSonido;
        public int Id { get; set; }
        private bool isLoaded = false;
        public Recipe()
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
                PBProducto.Image = Image.FromFile(selector.FileName);
                // Ajustamos la imagen al tamaño del PictureBox
                PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
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
        private void Recipe_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var ListPresentation = obj.GetPresentations().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione", Decimals = 0 });
            cbPresentacion.Items.Clear();
            // Configuramos el ComboBox
            cbPresentacion.DisplayMember = "Name";
            cbPresentacion.ValueMember = "Id";
            cbPresentacion.DataSource = ListPresentation;
            cbPresentacion.SelectedIndex = 0;
            if (Id == 0)
            {
                isLoaded = true;
                return;
            }
            var Recipe = obj.GetRecipeByIdorCode(Id, string.Empty).Result;
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
            txtCodigoBusqueda.Text = Recipe.Code.Replace("Rec-","");
            cbPresentacion.SelectedValue = Recipe.IdPresentation;
            nudExistencias.Value = Recipe.Stock;
            nudPrecio.Value = Recipe.Price;
            nudCada.Value = Recipe.SuggestedStock;
            CambiarPresentacion();
            if (ListPresentation.Where(l => l.Id == Recipe.IdPresentation).FirstOrDefault()?.Decimals > 1)
            {
                lblCostoGramo.Visible = true;
                lblCostoGramo.Text = "El costo por " + ListPresentation.Where(l => l.Id == Recipe.IdPresentation).FirstOrDefault()?.Name.ToLower();
                CalcularPrecioPorGramo();
            }
            else
            {
                lblCostoGramo.Visible = false;
            }
            isLoaded = true;
        }
        public void AgregarArticulo(int id, string codigo)
        {
            AppRepository obj = new AppRepository();
            ArticleModel Articulo = new ArticleModel();
            Articulo = obj.GetArticleByIdorCode(id, codigo).Result;

            if (Articulo == null)
            {
                MessageBox.Show("Codigo no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (dgvArticulos.Rows.Count == 0)
            {
                CrearGridView();
            }
            var Presentacion = obj.GetPresentationbyId(Articulo.IdPresentation).Result;
            decimal Cantidad = (int)NUDCantidad.Value;
            string PrecioUnitario = Articulo.Price.ToString();
            if (Presentacion.Decimals > 0)
            {
                Decimals d = new Decimals();
                d.ShowDialog();
                Cantidad = d.Kilos;
                PrecioUnitario = CalcularPrecioPorGramo(Articulo.Price, Articulo.SuggestedStock);
            }
            bool existe = false;
            decimal Total = 0;
            foreach (DataGridViewRow fila in dgvArticulos.Rows)
            {
                if (fila.Cells["Codigo"].Value.ToString() == Articulo.Code)
                {
                    decimal cantidadActual = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    fila.Cells["Cantidad"].Value = cantidadActual + Cantidad;
                    string[] partes = fila.Cells["Precio"].Value.ToString().Split('$');
                    decimal costounitario = Convert.ToDecimal(partes[1]);
                    if (Presentacion.Decimals == 3)
                        fila.Cells["Total"].Value = "$" + (costounitario * ((cantidadActual + Cantidad) * 1000)).ToString("N2");
                    else
                        fila.Cells["Total"].Value = "$" + (costounitario * (cantidadActual + Cantidad)).ToString("N2");
                    fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    existe = true;
                }
                Total = Total + Convert.ToDecimal(fila.Cells["Total"].Value.ToString().Replace("$", ""));
            }

            if (!existe)
            {
                decimal totalFila = 0;
                if (Presentacion.Decimals == 3)
                    totalFila = (Convert.ToDecimal(Cantidad) * 1000) * Convert.ToDecimal(PrecioUnitario);
                else
                    totalFila = Convert.ToDecimal(Cantidad) * Convert.ToDecimal(PrecioUnitario);
                int rowIndex = dgvArticulos.Rows.Add(Articulo.Code,
                Articulo.Name, Cantidad, "$" + PrecioUnitario, "$" + (totalFila).ToString("N2"));
                dgvArticulos.Rows[dgvArticulos.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                if (Presentacion.Decimals == 3)
                {
                    Total = Total + totalFila;
                    dgvArticulos.Rows[rowIndex].Cells["Cantidad"].Style.Format = "N3";
                }
                else
                {
                    dgvArticulos.Rows[rowIndex].Cells["Cantidad"].Style.Format = "N0";
                    Total = Total +
                        Math.Round(Convert.ToDecimal(Cantidad * Convert.ToDecimal(PrecioUnitario)), 2);
                }

            }

            if (Articulo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(Articulo.Image))
                {
                    PBProducto.Image = Image.FromStream(ms);
                    PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            lblTotal.Text = "Se recomienda venderlo en $" + Total.ToString("N2");
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
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                ReadOnly = true,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                ReadOnly = true,
                Width = 300
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                ReadOnly = false, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total",
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "Quitar",
                HeaderText = "Acción",
                Text = "Quitar",
                UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                Width = 80
            };
            dgvArticulos.Columns.Add(btnEliminar);
            dgvArticulos.AllowUserToAddRows = false;
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
            if (e.RowIndex < 0 || dgvArticulos.Columns[e.ColumnIndex].Name != "Cantidad") return;

            DataGridViewRow fila = dgvArticulos.Rows[e.RowIndex];
            string valorIngresado = fila.Cells["Cantidad"].Value?.ToString() ?? "0";
            if (valorIngresado.StartsWith("."))
            {
                valorIngresado = "0" + valorIngresado;
                // Suspendemos eventos temporalmente para que no se cicle al cambiar el valor
                dgvArticulos.CellValueChanged -= dgvArticulos_CellValueChanged;
                fila.Cells["Cantidad"].Value = valorIngresado;
                dgvArticulos.CellValueChanged += dgvArticulos_CellValueChanged;
            }

            if (decimal.TryParse(valorIngresado, out decimal cantidad))
            {
                string[] partes = fila.Cells["Precio"].Value.ToString().Split('$');
                decimal precio = Convert.ToDecimal(partes[1]);
                decimal subtotal = cantidad * precio;
                fila.Cells["Total"].Value = subtotal.ToString("N2"); // Formato con 2 decimales
            }

            decimal Total = 0;
            foreach (DataGridViewRow filas in dgvArticulos.Rows)
            {
                Total = Total + Convert.ToDecimal(filas.Cells["Total"].Value.ToString().Replace("$", ""));
            }
            lblTotal.Text = "Se recomienda venderlo en $" + Total.ToString("N2");

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
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                string formato = dgvArticulos.Columns["Cantidad"].DefaultCellStyle.Format;
                if (formato == "0") // Modo Piezas
                {
                    if (e.FormattedValue.ToString().Contains("."))
                    {
                        MessageBox.Show("Este artículo no permite decimales.");
                        e.Cancel = true;
                    }
                }
                string valor = e.FormattedValue.ToString();
                // Intentamos convertir a decimal. Si falla, cancelamos la salida de la celda.
                if (!decimal.TryParse(valor, out decimal resultado) && !string.IsNullOrEmpty(valor))
                {
                    MessageBox.Show("Por favor, ingresa una cantidad valida", "Error de formato");
                    e.Cancel = true; // No deja que el usuario se mueva de celda hasta que corrija
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
                    dgvArticulos.Rows.RemoveAt(e.RowIndex);
                    break;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

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
                    string texto = row.Name.ToUpper();

                    lblMedida.Text = texto == "KG" ? "Kg" :
                                     texto == "LT" ? "Lt" :
                                     texto == "MTS" ? "Mts" : row.Name;

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
                        lblCostoGramo.Text = "El costo por " + row.Name;
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
    }
}

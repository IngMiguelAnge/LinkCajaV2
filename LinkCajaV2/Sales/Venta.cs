using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Net.WebRequestMethods;
using static System.Runtime.CompilerServices.RuntimeHelpers;
namespace LinkCajaV2.Sales
{
    public partial class Venta : Form
    {
        private SoundPlayer lectorSonido;
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "beep.wav");
            lectorSonido = new SoundPlayer(ruta);
            lblUsuario.Text = "Bien venido " + NameUser;

            AppRepository obj = new AppRepository();
            var Empresa = obj.GetCompany().Result;
            if (Empresa != null)
            {
                lblNombreEmpresa.Text = Empresa.Name;
                if (Empresa.Logo != null)
                {
                    using (MemoryStream ms = new MemoryStream(Empresa.Logo))
                    {
                        PBLogo.Image = Image.FromStream(ms);
                        PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lectorSonido.Play(); // Reproducción instantánea sin lag
                e.SuppressKeyPress = true;
                AgregarArticulo(0, txtCodigo.Text);
                txtCodigo.Clear();
            }
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
        public void AgregarArticulo(int id, string codigo)
        {
            AppRepository obj = new AppRepository();
            ArticleModel Articulo = new ArticleModel();
            if (codigo != string.Empty)
                Articulo = obj.GetArticleByCode(codigo).Result;
            else
                Articulo = obj.GetArticlebyId(id).Result;
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
                        fila.Cells["Total"].Value = "$" + (costounitario * ((cantidadActual + Cantidad)*1000)).ToString("N2");
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
                Articulo.Description, Cantidad, "$" + PrecioUnitario, "$" + (totalFila).ToString("N2"));
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
            lblTotal.Text = "Total: $" + Total.ToString("N2");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articles article = new Articles();
            article.IsVenta = true;
            if (article.ShowDialog() == DialogResult.OK)
            {
                AgregarArticulo(article.IdSeleccionado, string.Empty);
                txtCodigo.Clear();
            }

        }

        private void Venta_Shown(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearGridView();
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
                Name = "Descripcion",
                HeaderText = "Descripción",
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
            lblTotal.Text = "Total: $" + Total.ToString();
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

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "Quitar":
                    dgvArticulos.Rows.RemoveAt(e.RowIndex);
                    break;
            }
        }
    }
}

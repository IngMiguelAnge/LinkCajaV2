using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Stock : Form
    {
        public int IdArticle { get; set; }
        public string Nombre { get; set; }
        private bool isLoaded = false;
        private decimal MyCostoMax = 0;
        public Stock()
        {
            InitializeComponent();
            nudPrecio.TextChanged += (s, e) => CalcularPrecioPorGramo();
            nudCada.TextChanged += (s, e) => CalcularPrecioPorGramo();
        }

        public void CambiarPresentacion()
        {
            if (cbPresentacion.SelectedIndex > 0)
            {
                if (cbPresentacion.SelectedItem is ListPresentationsModel row)
                {
                    lblMedida.Text = row.Presentation;
                    string submedida = row.Presentation == "Kg" ? "gramo" :
                 row.Presentation == "L" ? "mililitro" :
                 row.Presentation == "M" ? "centimetro" : row.Name;
                    lblCostoGramo.Text = "El costo por " + submedida + " es:";
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
                        nudExistencias.Value = 0;
                        nudCada.Value = 1;
                    }
                    if (decimals > 1)
                    {
                        lblCostoGramo.Visible = true;
                        lblPrecioGramo.Visible = true;
                        CalcularPrecioPorGramo();
                    }
                    else
                    {
                        lblCostoGramo.Visible = false;
                    }
                }
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
                lblPrecioGramo.Text = "$" + resultado.ToString("N4"); // N4 es mejor para gramos
            }
            else
            {
                lblPrecioGramo.Text = "$0.00";
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if ((int)cbPresentacion.SelectedValue == 0 ||
               nudPrecio.Value <= 0 || nudCada.Value <= 0)
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StockModel Stock = new StockModel()
            {
                Id = IdArticle,
                Stock = nudExistencias.Value,
                IdPresentation = (int)cbPresentacion.SelectedValue,
                Price = nudPrecio.Value,
                SuggestedStock = nudCada.Value,
                Margen = nudMargen.Value
            };
            AppRepository obj = new AppRepository();
            if (obj.SaveStock(Stock).Result)
            {
                MessageBox.Show("Stock guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Erro al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Stock de " + Nombre;
            AppRepository obj = new AppRepository();
            var CostoMax = obj.GetHighPrice(IdArticle).Result;
            if (CostoMax == null)
            {
                MessageBox.Show("No se han encontrado proveedores con precios registrados, por favor registre al menos un proveedor para configurar el stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MyCostoMax = CostoMax.Price;
            decimal precioMax = MyCostoMax / ((100 - 0) / 100);
            lblRecomendacion.Text = "Se recomienda vender en:";
            lblRecomendacion3.Text = "$" + precioMax.ToString("N2");
            lblRecomendacion2.Text = "por cada " + CostoMax.Presentation.Substring(0, CostoMax.Presentation.Length - 1);
            nudPrecio.Value = Convert.ToDecimal(precioMax.ToString("N2"));
            var ListPresentation = obj.GetPresentations().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione", Presentation = string.Empty, Decimals = 0 });
            cbPresentacion.Items.Clear();
            // Configuramos el ComboBox
            cbPresentacion.DisplayMember = "Name";
            cbPresentacion.ValueMember = "Id";
            cbPresentacion.DataSource = ListPresentation;
            cbPresentacion.SelectedIndex = 0;

            var Article = obj.GetStock(IdArticle).Result;
            cbPresentacion.SelectedValue = CostoMax.IdPresentation;
            CambiarPresentacion();
            if (ListPresentation.Where(l => l.Id == CostoMax.IdPresentation).FirstOrDefault()?.Decimals > 1)
            {
                lblCostoGramo.Visible = true;
            }
            else
            {
                lblCostoGramo.Visible = false;
            }
            if (IdArticle == 0 || Article == null)
            {
                isLoaded = true;
                return;
            }
            nudMargen.Value = Article.Margen;
            nudExistencias.Value = Article.Stock;
            nudPrecio.Value = Article.Price;
            nudCada.Value = Article.SuggestedStock;
            isLoaded = true;
        }

        private void nudMargen_KeyUp(object sender, KeyEventArgs e)
        {
            if (nudMargen.Value >= 100)
            {
                nudMargen.Value = 99.99M;
            }
            decimal precioMax = MyCostoMax / ((100 - nudMargen.Value) / 100);
            lblRecomendacion3.Text = "$" + precioMax.ToString("N2");
            nudPrecio.Value = Convert.ToDecimal(precioMax.ToString("N2"));
        }

        private void nudMargen_ValueChanged(object sender, EventArgs e)
        {
            if(nudMargen.Value >= 100)
            {
                nudMargen.Value = 99.99M;
            }
            decimal precioMax = MyCostoMax / ((100 - nudMargen.Value) / 100);
            lblRecomendacion3.Text = "$" + precioMax.ToString("N2");
            nudPrecio.Value = Convert.ToDecimal(precioMax.ToString("N2"));
        }
        public void CalcularMargen()
        {
            if (MyCostoMax > 0 && nudPrecio.Value > 0)
            {
                decimal margenCalculado = ((nudPrecio.Value - MyCostoMax) / nudPrecio.Value) * 100;
                nudMargen.Value = Math.Round(margenCalculado, 2);
            }
            else
            {
                nudMargen.Value = 0;
            }
        }
    }
}

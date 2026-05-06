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
        public int Id { get; set; }
        public string Nombre { get; set; }
        private bool isLoaded = false;
        private decimal MyCostoMax = 0;
        public Stock()
        {
            InitializeComponent();
            nudPrecio.TextChanged += (s, e) => CalcularPrecioPorGramo();
            nudCada.TextChanged += (s, e) => CalcularPrecioPorGramo();
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
                lblCostoGramo.Text += " $0.00";
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
                Id = Id,
                Stock = nudExistencias.Value,
                IdPresentation = (int)cbPresentacion.SelectedValue,
                Price = nudPrecio.Value,
                SuggestedStock = nudCada.Value,
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
            var CostoMax = obj.GetHighPrice(Id).Result;
            if(CostoMax == null)
            {
                MessageBox.Show("No se han encontrado proveedores con precios registrados, por favor registre al menos un proveedor para configurar el stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MyCostoMax = CostoMax.Price;
            decimal precioMax = MyCostoMax/((100-0)/100);
            lblRecomendacion.Text = "Se recomienda vender en: $" + precioMax.ToString("N2");
            lblRecomendacion2.Text = "por cada " + CostoMax.Presentation.Substring(0, CostoMax.Presentation.Length - 1);
            nudPrecio.Value = Convert.ToDecimal(precioMax.ToString("N2"));
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
            var Article = obj.GetStock(Id).Result;
            cbPresentacion.SelectedValue = Article.IdPresentation;
            nudExistencias.Value = Article.Stock;
            nudPrecio.Value = Article.Price;
            nudCada.Value = Article.SuggestedStock;
            precioMax = MyCostoMax/ ((100 - Article.Margen) / 100);
            lblRecomendacion.Text += "Se recomienda vender en: $" + precioMax.ToString("N2");
            CambiarPresentacion();
            if (ListPresentation.Where(l => l.Id == Article.IdPresentation).FirstOrDefault()?.Decimals > 1)
            {
                lblCostoGramo.Visible = true;
                CalcularPrecioPorGramo();
            }
            else
            {
                lblCostoGramo.Visible = false;
            }
            isLoaded = true;
        }

        private void nudMargen_KeyUp(object sender, KeyEventArgs e)
        {
            decimal precioMax = MyCostoMax / ((100 - nudMargen.Value) / 100);
            lblRecomendacion.Text = "Se recomienda vender en: $" + precioMax.ToString("N2");
            nudPrecio.Value = Convert.ToDecimal(precioMax.ToString("N2"));
        }
    }
}

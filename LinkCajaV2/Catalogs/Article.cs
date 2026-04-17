using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Article : Form
    {
        private bool isLoaded = false;
        public int Id { get; set; }
        public Article()
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) || (int)cbPresentacion.SelectedValue == 0
               )
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();

            var exist = obj.GetArticleByIdorCode(0,txtCodigo.Text).Result;
            if (exist != null && exist.Id != Id)
            {
                MessageBox.Show("Ya se encuentra el codigo en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ArticleModel Articulo = new ArticleModel()
            {
                Id = Id,
                Name = txtNombre.Text,
                Description = txtDescripcion.Text,
                Image = PBProducto.Image != null ? ImageToByteArray() : null,
                Code = txtCodigo.Text,
                Stock = nudExistencias.Value,
                IdPresentation = (int)cbPresentacion.SelectedValue,
                Price = nudPrecio.Value,
                SuggestedStock = nudCada.Value,
            };
            if (obj.SaveArticle(Articulo).Result)
            {
                MessageBox.Show("Articulo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Erro al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Article_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var ListPresentation = obj.GetPresentations().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione" });
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
            var Article = obj.GetArticleByIdorCode(Id,string.Empty).Result;
            txtNombre.Text = Article.Name;
            txtDescripcion.Text = Article.Description;
            if (Article.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(Article.Image))
                {
                    PBProducto.Image = Image.FromStream(ms);
                    PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            txtCodigo.Text = Article.Code;
            cbPresentacion.SelectedValue = Article.IdPresentation;
            nudExistencias.Value = Article.Stock;
            nudPrecio.Value = Article.Price;
            nudCada.Value = Article.SuggestedStock;
            CambiarPresentacion();
            if (Article.IdPresentation < 3)
            {
                lblCostoGramo.Visible = true;
                txtGramo.Visible = true;
                CalcularPrecioPorGramo();
            }
            else
            {
                lblCostoGramo.Visible = false;
                txtGramo.Visible = false;
            }
            isLoaded = true;
        }

        private void cbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            CambiarPresentacion();
        }
        public void CambiarPresentacion()
        {
            List<ListPresentationsModel> ListPresentation = new List<ListPresentationsModel>();
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione" });
            if (cbPresentacion.SelectedIndex > 0)
            {
                switch (cbPresentacion.Text.ToUpper())
                {
                    case "KG":
                        ListPresentation.Insert(1, new ListPresentationsModel { Id = 1, Name = "Kg" });
                        nudExistencias.DecimalPlaces = 3;
                        nudExistencias.Increment = 0.010M;
                        nudExistencias.Maximum = 10000;
                        nudCada.DecimalPlaces = 3;
                        nudCada.Maximum = 1000000;
                        nudCada.Increment = 0.010M;
                        nudCada.Enabled = true;
                        lblMedida.Text = "Kg";
                        if (isLoaded)
                        {
                            nudExistencias.Value = 0.000M;
                            nudCada.Value = 0.000M;
                        }
                        break;
                    case "LT":
                        ListPresentation.Insert(1, new ListPresentationsModel { Id = 2, Name = "Lt" });
                        nudExistencias.DecimalPlaces = 3;
                        nudExistencias.Increment = 0.010M;
                        nudExistencias.Maximum = 10000;
                        nudCada.DecimalPlaces = 3;
                        nudCada.Maximum = 1000000;
                        nudCada.Increment = 0.010M;
                        nudCada.Enabled = true;
                        lblMedida.Text = "Lt";
                        if (isLoaded)
                        {
                            nudExistencias.Value = 0.000M;
                            nudCada.Value = 0.000M;
                        }
                        break;
                    default:
                        ListPresentation.Insert(1, new ListPresentationsModel { Id = Id, Name = cbPresentacion.Text });
                        nudExistencias.DecimalPlaces = 0;
                        nudExistencias.Increment = 1M;
                        nudExistencias.Maximum = 1000000;
                        nudCada.DecimalPlaces = 0;
                        nudCada.Maximum = 1000000;
                        nudCada.Increment = 1M;
                        nudCada.Enabled = false;
                        lblMedida.Text = cbPresentacion.Text;
                        if (isLoaded)
                        {
                            nudExistencias.Value = 0;
                            nudCada.Value = 1;
                        }
                        break;
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
                // Guardamos posición
                int cursorPosition = tb.SelectionStart;

                // Tu lógica de cálculo
                CalcularPrecioPorGramo();

                // Restauramos posición
                tb.SelectionStart = cursorPosition;
            }
            else
            {
                // Si no encontró el TextBox (raro, pero puede pasar), solo calcula
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
                txtGramo.Text = resultado.ToString("N4"); // N4 es mejor para gramos
            }
            else
            {
                txtGramo.Text = "0.00";
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
                // Guardamos posición
                int cursorPosition = tb.SelectionStart;

                // Tu lógica de cálculo
                CalcularPrecioPorGramo();

                // Restauramos posición
                tb.SelectionStart = cursorPosition;
            }
            else
            {
                // Si no encontró el TextBox (raro, pero puede pasar), solo calcula
                CalcularPrecioPorGramo();
            }
        }
    }
}

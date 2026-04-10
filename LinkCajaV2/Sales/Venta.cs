using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Model;
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
            lblUsuario.Text = "Bien venido "+ NameUser;
            
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
                AgregarArticulo(0,txtCodigo.Text);
                txtCodigo.Clear();
            }
        }

        public void AgregarArticulo(int id,string codigo)
        {
            AppRepository obj = new AppRepository();
            ArticleModel Articulo = new ArticleModel();
            if(codigo != string.Empty)
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
            bool existe = false;
            decimal Total = 0;
            foreach (DataGridViewRow fila in dgvArticulos.Rows)
            {
                if (fila.Cells["Codigo"].Value.ToString() == txtCodigo.Text)
                {
                    int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    fila.Cells["Cantidad"].Value = cantidadActual + (int)NUDCantidad.Value;
                    string[] partes = fila.Cells["Precio"].Value.ToString().Split('$');
                    decimal costounitario = Convert.ToDecimal(partes[1]);
                    fila.Cells["Total"].Value = "$" + (costounitario * (cantidadActual + (int)NUDCantidad.Value)).ToString();
                    fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    existe = true;
                    //break;
                }
                Total = Total + Convert.ToDecimal(fila.Cells["Total"].Value.ToString().Replace("$", ""));
            }

            if (!existe)
            {
                dgvArticulos.Rows.Add(Articulo.Code,
                Articulo.Description, (int)NUDCantidad.Value, "$" + Articulo.Price.ToString(), "$" + Articulo.Price.ToString());
                dgvArticulos.Rows[dgvArticulos.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;

                Total = Total + Convert.ToDecimal((int)NUDCantidad.Value * Articulo.Price);
            }

            if (Articulo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(Articulo.Image))
                {
                    PBProducto.Image = Image.FromStream(ms);
                    PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            lblTotal.Text = "Total: $" + Total.ToString();
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
        public void CrearGridView() {
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
                Name = "Accion",
                HeaderText = "Acción",
                Text = "Quitar",
                UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                Width = 80
            };
            dgvArticulos.Columns.Add(btnEliminar);
            dgvArticulos.AllowUserToAddRows = false;
        }
    }
}

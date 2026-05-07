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
    public partial class PricesSuppliers : Form
    {
        public int IdArticle { get; set; }
        private bool hayarticulos = false;
        public PricesSuppliers()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if((int)cbPresentacion.SelectedValue == 0 || (int)cbProveedores.SelectedValue == 0
                || nudPrecio.Value == 0)
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cbPresentacion.Enabled = false;
            // Obtenemos la lista que ya está conectada al Grid
            var bindingList = (BindingList<ListPricesSuppliersModel>)dgvProveedores.DataSource;

            // Si la lista no existe (porque es el primer artículo), la inicializamos
            if (bindingList == null)
            {
                bindingList = new BindingList<ListPricesSuppliersModel>();
                dgvProveedores.DataSource = bindingList;
            }
            var Existente = bindingList.FirstOrDefault(x => x.IdSupplier == (int)cbProveedores.SelectedValue);

            if (Existente != null)
            {
                Existente.PriceUnit = nudPrecio.Value;
                dgvProveedores.Refresh(); 
            }
            else
            {
                // Si es nuevo, lo agregamos a la lista
                bindingList.Add(new ListPricesSuppliersModel
                {
                    Id = 0,
                    IdSupplier = (int)cbProveedores.SelectedValue,
                    Name = cbProveedores.Text,
                    PriceUnit = nudPrecio.Value
                });
            }
        }

        private async void PricesSuppliers_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var ListPresentation = obj.GetPresentations().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione", Presentation=string.Empty, Decimals = 0 });
            cbPresentacion.Items.Clear();
            // Configuramos el ComboBox
            cbPresentacion.DisplayMember = "Name";
            cbPresentacion.ValueMember = "Id";
            cbPresentacion.DataSource = ListPresentation;
            cbPresentacion.SelectedIndex = 0;
            var ListProveedores = obj.GetSuppliersActives().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListProveedores.Insert(0, new ListSuppliersActivesModel { Id = 0, Name = "Seleccione" });
            cbProveedores.Items.Clear();
            cbProveedores.DisplayMember = "Name";
            cbProveedores.ValueMember = "Id";
            cbProveedores.DataSource = ListProveedores;
            cbProveedores.SelectedIndex = 0;
            CrearGridView();
            var lista = await Task.Run(() => obj.GetPricesSuppliersActives(IdArticle));

            if (lista != null && lista.Count > 0)
            {
                // Usamos BindingList para que sea fácil agregar/quitar después
                var bindingList = new BindingList<ListPricesSuppliersModel>(lista);
                dgvProveedores.DataSource = bindingList;
                cbPresentacion.SelectedValue = lista.FirstOrDefault().IdPresentation;
                cbPresentacion.Enabled = false;
            }
            var Article = obj.GetStock(IdArticle).Result;
            if (Article != null) {
                hayarticulos = true;
                cbPresentacion.Enabled = false;
                cbPresentacion.SelectedValue = Article.IdPresentation;
                MessageBox.Show("Este articulo ya cuenta con un stock no se puede cambiar la presentación", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void CrearGridView()
        {
            dgvProveedores.Columns.Clear();
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdSupplier",
                HeaderText = "IdSupplier",
                DataPropertyName = "IdSupplier",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Proveedor",
                HeaderText = "Proveedor",
                DataPropertyName = "Name",
                ReadOnly = true,
                Width = 100
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {           
                Name = "Costo",
                HeaderText = "Costo",
                DataPropertyName = "PriceUnit",
                ReadOnly = false, // Aquí permites la edición
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
            dgvProveedores.Columns.Add(btnEliminar);
            dgvProveedores.AllowUserToAddRows = false;
        }

        private void dgvProveedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validaciones iniciales
            if (e.RowIndex < 0 || dgvProveedores.Columns[e.ColumnIndex].Name != "Cantidad") return;

            // 2. Manejo del punto inicial (".5" -> "0.5")
            string valor = dgvProveedores.Rows[e.RowIndex].Cells["Costo"].Value?.ToString() ?? "0";
            if (valor.StartsWith("."))
            {
                dgvProveedores.CellValueChanged -= dgvProveedores_CellValueChanged;
                dgvProveedores.Rows[e.RowIndex].Cells["Costo"].Value = "0" + valor;
                dgvProveedores.CellValueChanged += dgvProveedores_CellValueChanged;
            }

            dgvProveedores.InvalidateRow(e.RowIndex);
        }

        private void dgvProveedores_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProveedores.CurrentCell.ColumnIndex == dgvProveedores.Columns["Costo"].Index)
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
            string formato = dgvProveedores.Columns["Costo"].DefaultCellStyle.Format;

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

        private void dgvProveedores_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // 1. Solo validamos la columna "Costo"
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "Costo")
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
            }
        }

        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvProveedores.Columns["Costo"].Index && e.RowIndex >= 0)
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

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (dgvProveedores.Columns[e.ColumnIndex].Name)
            {
                case "Quitar":
                    var bindingList = (BindingList<ListPricesSuppliersModel>)dgvProveedores.DataSource;

                    if (bindingList != null && bindingList.Count > 0)
                        bindingList.RemoveAt(e.RowIndex);
                    if (bindingList.Count == 0 && hayarticulos == false)
                        cbPresentacion.Enabled = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(dgvProveedores.Rows.Count == 0)
            {
                MessageBox.Show("No hay proveedores para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();
            var r = obj.UpdateAllStatusPrices(IdArticle).Result;
            foreach (DataGridViewRow fila in dgvProveedores.Rows)
            {
                PricesSuppliersModel item = new PricesSuppliersModel()
                {
                    Id = Convert.ToInt32(fila.Cells["Id"].Value.ToString()),
                    IdSupplier = Convert.ToInt32(fila.Cells["IdSupplier"].Value.ToString()),
                    IdArticle = IdArticle, 
                    PriceUnit = Convert.ToDecimal(fila.Cells["Costo"].Value),
                    IdPresentation = (int)cbPresentacion.SelectedValue,
                    Status = true
                };
          
                obj.SavePricesSuppliers(item).Wait();
            }
            MessageBox.Show("Articulo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

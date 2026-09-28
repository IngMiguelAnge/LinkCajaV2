using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkCajaV2.Data;
using LinkCajaV2.Model;


namespace LinkCajaV2.Catalogs
{
    public partial class Bundles : System.Windows.Forms.Form
    {
        public Bundles()
        {
            InitializeComponent();
        }

        public void CrearGridView()
        {
            dgvBundles.DataSource = null;
            dgvBundles.Columns.Clear();
            dgvBundles.AutoGenerateColumns = false;
            dgvBundles.ReadOnly = true;
            dgvBundles.AllowUserToAddRows = false;
            dgvBundles.RowHeadersVisible = false;

            // Id solo interno
            dgvBundles.Columns.Add(new DataGridViewTextBoxColumn{ Name = "Id",DataPropertyName = "Id",Visible = false } );
            dgvBundles.Columns.Add( new DataGridViewTextBoxColumn{Name = "Codigo",HeaderText = "Código",DataPropertyName = "Code",Width = 150});
            dgvBundles.Columns.Add(new DataGridViewTextBoxColumn{Name = "Nombre",HeaderText = "Nombre", DataPropertyName = "Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill});
            dgvBundles.Columns.Add( new DataGridViewTextBoxColumn{ Name = "PrecioBase", HeaderText = "Precio Base", DataPropertyName = "BasePrice",Width = 150, DefaultCellStyle = new DataGridViewCellStyle{ Format = "C2",FormatProvider =new CultureInfo("es-MX") } } );
            dgvBundles.Columns.Add( new DataGridViewTextBoxColumn{ Name = "PrecioOferta", HeaderText = "Precio oferta", DataPropertyName = "OfferPrice", Width = 130, DefaultCellStyle = new DataGridViewCellStyle{Format = "C2", FormatProvider = new CultureInfo("es-MX")}} );
            dgvBundles.Columns.Add(new DataGridViewTextBoxColumn{Name = "Disponible",HeaderText = "Disponible",DataPropertyName = "Available",ReadOnly = true,Width = 100});
            dgvBundles.Columns.Add(new DataGridViewTextBoxColumn{ Name = "Estado",HeaderText = "Estado", DataPropertyName = "Status",Width = 100 });
            DataGridViewButtonColumn btnEditar =new DataGridViewButtonColumn

                {
                    Name = "Editar",
                    HeaderText = "Acción",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 100,
                    FlatStyle = FlatStyle.Flat
                };

            dgvBundles.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnEstado = new DataGridViewButtonColumn
            {
                Name = "CambiarEstado",
                HeaderText = "Estado",   
                UseColumnTextForButtonValue = false,
                Width = 110,
                FlatStyle = FlatStyle.Flat
            };

            dgvBundles.EnableHeadersVisualStyles = false;
            dgvBundles.AllowUserToAddRows = false;
            dgvBundles.RowHeadersVisible = false;
            dgvBundles.BackgroundColor = Color.White;
            dgvBundles.BorderStyle = BorderStyle.FixedSingle;
            dgvBundles.GridColor = Color.FromArgb(220, 220, 220);
            dgvBundles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBundles.RowTemplate.Height = 32;
            dgvBundles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBundles.MultiSelect = false;

            dgvBundles.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 112, 192);
            dgvBundles.ColumnHeadersDefaultCellStyle.ForeColor =  Color.White;
            dgvBundles.ColumnHeadersDefaultCellStyle.Font =new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvBundles.ColumnHeadersDefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleLeft;
            dgvBundles.ColumnHeadersHeight = 36;

            dgvBundles.DefaultCellStyle.BackColor =Color.White;
            dgvBundles.DefaultCellStyle.ForeColor =Color.FromArgb(0, 102, 204);
            dgvBundles.DefaultCellStyle.Font =new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvBundles.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dgvBundles.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 102, 204);
            dgvBundles.Columns.Add(btnEstado);
        }

        private async void Buscar()
        {
            try
            {
                // Mostrar animación de carga
                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 30;
                AppRepository obj = new AppRepository();

                string codigo = txtCodigo.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                var lista = await obj.GetBundles(codigo, nombre);
                dgvBundles.DataSource = lista;

                foreach (DataGridViewRow row in dgvBundles.Rows)
                {
                    if (row.DataBoundItem is ListBundleModel item)
                    {
                        row.Cells["CambiarEstado"].Value =
                            item.Status == "Activo" ? "Desactivar" : "Activar";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar los paquetes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Ocultar la barra al terminar, haya error o no
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Visible = false;
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            Bundle bundle = new Bundle();
            bundle.ShowDialog();
            Buscar();
        }

        private async void dgvBundles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var fila = dgvBundles.Rows[e.RowIndex].DataBoundItem as ListBundleModel;
            if (fila == null) return;
            switch (dgvBundles.Columns[e.ColumnIndex].Name)
            {
                case "Editar":
                    {
                        Bundle bundle = new Bundle();
                        bundle.Id = fila.Id;
                        bundle.ShowDialog();
                        Buscar();
                        break;
                    }

                case "CambiarEstado":
                    {
                        bool nuevoEstado =
                            fila.Status != "Activo";

                        string accion =nuevoEstado? "activar": "desactivar";

                        DialogResult respuesta = MessageBox.Show($"¿Desea {accion} este paquete?","Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta != DialogResult.Yes)return;

                        AppRepository obj =new AppRepository();
                        bool resultado = await obj.UpdateBundleStatus(fila.Id, nuevoEstado);
                        if (resultado)
                        {
                            MessageBox.Show($"Paquete {(nuevoEstado ? "activado" : "desactivado")} correctamente.","Información", MessageBoxButtons.OK,MessageBoxIcon.Information );

                            Buscar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el estado del paquete.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                        break;
                    }
            }
        }

        private void Bundles_Load(object sender, EventArgs e)
        {
            CrearGridView();
            Buscar();
        }
    }
}

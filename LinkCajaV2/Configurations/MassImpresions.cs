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

namespace LinkCajaV2.Configurations
{
    public partial class MassImpresions : Form
    {
        public List<ListArticlesModel> ListaArticulos { get; set; }
        public MassImpresions()
        {
            InitializeComponent();
        }

        private void MassImpresions_Load(object sender, EventArgs e)
        {
            CargarGrid();
            cbImpresion.SelectedIndex = 0;
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnQuitar")
            {
                ListArticlesModel articulo =
                    dgvArticulos.Rows[e.RowIndex].DataBoundItem as ListArticlesModel;

                if (articulo == null)
                    return;

                ListaArticulos.RemoveAll(x => x.Id == articulo.Id);

                CargarGrid();
            }
        }
        private void CargarGrid()
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.Columns.Clear();
            dgvArticulos.DataSource = ListaArticulos;

            // Ocultar todas las columnas del modelo
            foreach (DataGridViewColumn columna in dgvArticulos.Columns)
            {
                columna.Visible = false;
            }

            // Mostrar únicamente las columnas necesarias
            if (dgvArticulos.Columns["Codigo"] != null)
                dgvArticulos.Columns["Codigo"].Visible = true;

            if (dgvArticulos.Columns["Articulo"] != null)
                dgvArticulos.Columns["Articulo"].Visible = true;

            if (dgvArticulos.Columns["Categoria"] != null)
                dgvArticulos.Columns["Categoria"].Visible = true;

            if (dgvArticulos.Columns["ClaveSAT"] != null)
                dgvArticulos.Columns["ClaveSAT"].Visible = true;

            if (dgvArticulos.Columns["Existencias"] != null)
                dgvArticulos.Columns["Existencias"].Visible = true;

            if (dgvArticulos.Columns["ExistenciasMinimas"] != null)
                dgvArticulos.Columns["ExistenciasMinimas"].Visible = true;
            DataGridViewButtonColumn btnQuitar = new DataGridViewButtonColumn();
            btnQuitar.Name = "btnQuitar";
            btnQuitar.HeaderText = "Acción";
            btnQuitar.Text = "Quitar";
            btnQuitar.UseColumnTextForButtonValue = true;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnQuitar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvArticulos.Columns.Add(btnQuitar);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListaArticulos == null || ListaArticulos.Count == 0)
                {
                    MessageBox.Show(
                        "No hay artículos para imprimir.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }
                if (cbImpresion.SelectedIndex == 0)
                {
                    MessageBox.Show(
                        "Seleccione un formato de impresión.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                List<PrinterPricesModel> articulos = ListaArticulos
                    .Select(x => new PrinterPricesModel
                    {
                        Codigo = x.Codigo,
                        Articulo = x.Articulo,
                        Categoria = x.Categoria,
                        ClaveSAT = x.ClaveSAT,
                        Precio = x.Precio,
                        Stock = x.Existencias,
                        StockMinimo = x.ExistenciasMinimas
                    })
                    .ToList();

                ImpressionsGeneral im = new ImpressionsGeneral();

                switch (cbImpresion.SelectedIndex)
                {
                    case 1: // Etiquetas
                        im.ImpresionEtiquetas(articulos);
                        break;

                    case 2: // General
                        im.ImpresionListaPrecios(articulos);
                        break;

                    case 3: // Agotados

                        var articulosAgotados = ListaArticulos
                            .Where(x => x.Stock <= 0)
                            .Select(x => new PrinterPricesModel
                            {
                                Codigo = x.Codigo,
                                Articulo = x.Articulo,
                                Categoria = x.Categoria,
                                ClaveSAT = x.ClaveSAT,
                                Precio = x.Precio,
                                Stock = x.Existencias,
                                StockMinimo = x.ExistenciasMinimas
                            })
                            .ToList();

                        if (articulosAgotados.Count == 0)
                        {
                            MessageBox.Show(
                                "Los artículos seleccionados no tienen productos agotados.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            return;
                        }
                        im.ImpresionListaAgotados(articulosAgotados);
                        break;
                }

                // Limpiar la lista temporal después de imprimir
                ListaArticulos.Clear();

                CargarGrid();

                MessageBox.Show(
                    "Impresión generada correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar la impresión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

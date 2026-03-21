using LinkCajaV2.Data;
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
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
                progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
                btnNuevo.Enabled = false; 
                BtnBuscar.Enabled = false; 
                dgvArticulos.DataSource = null;
                dgvArticulos.Columns.Clear();
                try
                {
                    AppRepository obj = new AppRepository();
                    var lista = await Task.Run(() => obj.GetArticles(txtNombre.Text,txtDescripcion.Text));
                    dgvArticulos.DataSource = lista != null && lista.Count > 0 ? lista : null;
                    if (lista == null || lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron articulos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        AgregarBotones();
                        MessageBox.Show("Carga completa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    progressBar1.Value = 0;
                    btnNuevo.Enabled = true;
                    BtnBuscar.Enabled = true;
                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Article m = new Article();
            m.Id = 0;
            m.Show();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            var Id = dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Article m = new Article();
                    m.Id = Convert.ToInt32(Id);
                    m.Show();
                    break;
            }
        }
        private void AgregarBotones()
        {
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnEditar);
        }

    }
}

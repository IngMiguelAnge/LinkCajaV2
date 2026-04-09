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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Client m = new Client();
            m.Id = 0;
            m.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los proveedores pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            BuscarClientes();
        }
        public async void BuscarClientes()
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnBuscar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
            btnNuevo.Enabled = false;
            dgvClientes.DataSource = null;
            dgvClientes.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => obj.GetClients(txtNombre.Text));
                dgvClientes.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnBuscar.Enabled = true;
                btnNuevo.Enabled = true;
            }
        }
        private void AgregarBotones()
        {
            // Botón Checket
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvClientes.Columns.Add(btnEditar);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            var Id = dgvClientes.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvClientes.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Client m = new Client();
                    m.Id = Convert.ToInt32(Id);
                    m.ShowDialog();
                    BuscarClientes();
                    break;
            }
        }
    }
}

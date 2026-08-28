using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mikrotik_Administrador.Settings;

namespace LinkCajaV2.Catalogs
{
    public partial class FrmCatClientes : Form
    {
        public FrmCatClientes()
        {
            InitializeComponent();
        }


        public async Task BuscarClientes(string filtro = "")
        {
            // Barra
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            // Apagamos botones
            btnNuevo.Enabled = false;
            txtBuscar.Enabled = false;
      

            try
            {
                LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();
                var listaClientes = await Task.Run(() => app.GetClientesFiltro(filtro));

                if (listaClientes == null || listaClientes.Count == 0)
                {
                    dgvClientes.DataSource = null;
                    return;
                }

                var listaOrdenable = new Mikrotik_Administrador.Settings.SortableBindingList<LinkCajaV2.Model.ClienteModel>(listaClientes);
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaOrdenable;
                dgvClientes.ReadOnly = true;
                dgvClientes.AllowUserToAddRows = false;

                // Oculto lo qu eno necesito aca
                string[] columnasOcultas = { "Id", "Correo", "Telefono1", "Telefono2", "Direccion", "Latitud", "Longitud", "Estatus" };
                foreach (string col in columnasOcultas)
                {
                    if (dgvClientes.Columns.Contains(col))
                        dgvClientes.Columns[col].Visible = false;
                }

                // Estatus
                if (dgvClientes.Columns.Contains("EstatusTexto"))
                {
                    dgvClientes.Columns["EstatusTexto"].HeaderText = "Estatus";
                }

                if (dgvClientes.Columns.Contains("CostoEnvio"))
                {
                    dgvClientes.Columns["CostoEnvio"].HeaderText = "Costo de Envío";
                    dgvClientes.Columns["CostoEnvio"].DefaultCellStyle.Format = "$ #,##0.00";
                }

                if (dgvClientes.Columns.Contains("Nombre"))
                    dgvClientes.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Para la barra y prende todo 
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                progressBar1.MarqueeAnimationSpeed = 0;

                btnNuevo.Enabled = true;
                txtBuscar.Enabled = true;
           
                txtBuscar.Focus(); 
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            LinkCajaV2.Catalogs.Cliente frm = new LinkCajaV2.Catalogs.Cliente();
            frm.ShowDialog();
            await BuscarClientes(txtBuscar.Text.Trim());
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LinkCajaV2.Catalogs.Cliente frm = new LinkCajaV2.Catalogs.Cliente();

            // Pasa el Id para saber a quien editas 
            frm.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            // Le pasamos los textos a las cajas 
            frm.txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.txtCorreo.Text = dgvClientes.CurrentRow.Cells["Correo"].Value.ToString();
            frm.txtTelefono1.Text = dgvClientes.CurrentRow.Cells["Telefono1"].Value.ToString();
            frm.txtTelefono2.Text = dgvClientes.CurrentRow.Cells["Telefono2"].Value.ToString();
            bool estatusViejo = Convert.ToBoolean(dgvClientes.CurrentRow.Cells["Estatus"].Value);
            frm.cmbEstatus.SelectedIndex = estatusViejo ? 0 : 1;

            frm.ShowDialog();
            await BuscarClientes(txtBuscar.Text.Trim());
        }

        private async void button1_Click(object sender, EventArgs e)  //Editar Direccion y Tarifa 
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
            string nombreCliente = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();

            LinkCajaV2.Catalogs.Ubicacion frmMapa = new LinkCajaV2.Catalogs.Ubicacion();

            // Invocar datos viejos en los recuadros
            frmMapa.txtDireccionProporcionada.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value?.ToString() ?? "";
            frmMapa.txtDireccionOficial.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value?.ToString() ?? "";
            frmMapa.txtLatitud.Text = dgvClientes.CurrentRow.Cells["Latitud"].Value?.ToString() ?? "";
            frmMapa.txtLongitud.Text = dgvClientes.CurrentRow.Cells["Longitud"].Value?.ToString() ?? "";

            // Convertir el precio a numero 
            if (decimal.TryParse(dgvClientes.CurrentRow.Cells["CostoEnvio"].Value?.ToString(), out decimal costoViejo))
            {
               
                if (costoViejo >= frmMapa.numCostoEnvio.Minimum && costoViejo <= frmMapa.numCostoEnvio.Maximum)
                    frmMapa.numCostoEnvio.Value = costoViejo;
            }

            // Se hace un update 
            if (frmMapa.ShowDialog() == DialogResult.OK)
            {
                LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();

                bool exito = await app.UpdateUbicacionCliente(
                    idCliente,
                    frmMapa.DireccionSeleccionada,
                    frmMapa.LatitudSeleccionada,
                    frmMapa.LongitudSeleccionada,
                    frmMapa.CostoSeleccionado
                );

                if (exito)
                {
                    MessageBox.Show($"La ubicación y tarifa para {nombreCliente} se actualizaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await BuscarClientes(txtBuscar.Text.Trim());
                }
                else
                {
                    
                    MessageBox.Show("Hubo un error al guardar la ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void FrmCatClientes_Load(object sender, EventArgs e)
        {
            await BuscarClientes("");
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            await BuscarClientes(txtBuscar.Text.Trim());
        }
    }
}

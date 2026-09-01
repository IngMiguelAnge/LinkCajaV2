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
        public int IdSeleccionado { get; set; }
        public string NombreSeleccionado { get; set; }
        public decimal CostoSeleccionado { get; set; }
        public bool EsSeleccionVenta { get; set; } = false;
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
            BtnBuscar.Enabled = false;


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

                dgvClientes.DataSource = listaOrdenable;
           

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
                BtnBuscar.Enabled = true;
                txtBuscar.Focus();
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            Catalogs.Cliente frm = new Catalogs.Cliente();
            frm.ShowDialog();
            await BuscarClientes(txtBuscar.Text.Trim());
        }

   
        private async void FrmCatClientes_Load(object sender, EventArgs e)
        {
            ConfigurarGridView();
            await BuscarClientes("");
        }

        public void ConfigurarGridView()
        {
            dgvClientes.DataSource = null;
            dgvClientes.Columns.Clear();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ReadOnly = true;

            dgvClientes.DataSource = null;
            dgvClientes.Columns.Clear();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ReadOnly = true;

            // COLUMNAS OCULTAS
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Correo", DataPropertyName = "Correo", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Telefono1", DataPropertyName = "Telefono1", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Telefono2", DataPropertyName = "Telefono2", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Direccion", DataPropertyName = "Direccion", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Latitud", DataPropertyName = "Latitud", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Longitud", DataPropertyName = "Longitud", Visible = false });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estatus", DataPropertyName = "Estatus", Visible = false });

            // COLUMNAS VISIBLES DE TEXTO
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "CostoEnvio", HeaderText = "Costo de Envío", DataPropertyName = "CostoEnvio", DefaultCellStyle = new DataGridViewCellStyle { Format = "$ #,##0.00" } });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "EstatusTexto", HeaderText = "Estatus", DataPropertyName = "EstatusTexto" });

            // Botones

            if (EsSeleccionVenta)
            {
                // Boton para venta 
                DataGridViewButtonColumn btnSelect = new DataGridViewButtonColumn();
                btnSelect.Name = "btnSeleccionar";
                btnSelect.HeaderText = "Acción";
                btnSelect.Text = "Seleccionar";
                btnSelect.UseColumnTextForButtonValue = true;
                btnSelect.FlatStyle = FlatStyle.Flat;
                btnSelect.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
                btnSelect.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
                dgvClientes.Columns.Add(btnSelect);
            }
            else
            {
                // Botones para FRMCATALOGO 
                DataGridViewButtonColumn btnEstatus = new DataGridViewButtonColumn();
                btnEstatus.Name = "btnEstatus";
                btnEstatus.HeaderText = "Acción";
                btnEstatus.Text = "Estatus";
                btnEstatus.UseColumnTextForButtonValue = true;
                btnEstatus.FlatStyle = FlatStyle.Flat;
                btnEstatus.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
                btnEstatus.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
                btnEstatus.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 242, 245);
                btnEstatus.DefaultCellStyle.SelectionForeColor = Color.FromArgb(1, 110, 203);
                dgvClientes.Columns.Add(btnEstatus);

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Acción";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                btnEditar.FlatStyle = FlatStyle.Flat;
                btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
                btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
                btnEditar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 242, 245);
                btnEditar.DefaultCellStyle.SelectionForeColor = Color.FromArgb(1, 110, 203);
                dgvClientes.Columns.Add(btnEditar);

                DataGridViewButtonColumn btnUbi = new DataGridViewButtonColumn();
                btnUbi.Name = "btnUbicacion";
                btnUbi.HeaderText = "Logística";
                btnUbi.Text = "Ubicación/Tarifa";
                btnUbi.UseColumnTextForButtonValue = true;
                btnUbi.FlatStyle = FlatStyle.Flat;
                btnUbi.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
                btnUbi.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
                btnUbi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 242, 245);
                btnUbi.DefaultCellStyle.SelectionForeColor = Color.FromArgb(1, 110, 203);
                dgvClientes.Columns.Add(btnUbi);
            }
        }
        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
           
            var celdaId = dgvClientes.Rows[e.RowIndex].Cells["Id"].Value;
            if (celdaId == null) return;

            int idCliente = Convert.ToInt32(celdaId);
            LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();

            switch (dgvClientes.Columns[e.ColumnIndex].Name)
            {
                //Este de aca es para el de Venta 
                case "btnSeleccionar":
                    // Datos de la fila seleccionada
                    IdSeleccionado = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);
                    NombreSeleccionado = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    CostoSeleccionado = Convert.ToDecimal(dgvClientes.Rows[e.RowIndex].Cells["CostoEnvio"].Value);

                    // mando señal y cierro 
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;


                case "btnEstatus":
                    bool statusCambiado = await app.UpdateStatusCliente(idCliente);

                    if (statusCambiado)
                    {
                        MessageBox.Show("El estatus del cliente se ha actualizado correctamente.", "Estatus Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await BuscarClientes(txtBuscar.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estatus en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "btnEditar":
                    Cliente frmEdit = new Cliente();
                    frmEdit.IdCliente = idCliente;
                    

                    // Pasar los datos actuales de la fila seleccionada al formulario
                    frmEdit.txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString();
                    frmEdit.txtCorreo.Text = dgvClientes.Rows[e.RowIndex].Cells["Correo"].Value?.ToString();
                    frmEdit.txtTelefono1.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono1"].Value?.ToString();
                    frmEdit.txtTelefono2.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono2"].Value?.ToString();
                    frmEdit.EstatusActual = Convert.ToBoolean(dgvClientes.Rows[e.RowIndex].Cells["Estatus"].Value);



                    frmEdit.ShowDialog();
                    await BuscarClientes(txtBuscar.Text.Trim());
                    break;


                case "btnUbicacion":
                    Ubicacion frmMapa = new Ubicacion();

                    // Pasar datos viejos a los recuadros
                    frmMapa.txtDireccionProporcionada.Text = dgvClientes.Rows[e.RowIndex].Cells["Direccion"].Value?.ToString() ?? "";
                    frmMapa.txtDireccionOficial.Text = dgvClientes.Rows[e.RowIndex].Cells["Direccion"].Value?.ToString() ?? "";
                    frmMapa.txtLatitud.Text = dgvClientes.Rows[e.RowIndex].Cells["Latitud"].Value?.ToString() ?? "";
                    frmMapa.txtLongitud.Text = dgvClientes.Rows[e.RowIndex].Cells["Longitud"].Value?.ToString() ?? "";

                    if (decimal.TryParse(dgvClientes.Rows[e.RowIndex].Cells["CostoEnvio"].Value?.ToString(), out decimal costoViejo))
                    {
                        if (costoViejo >= frmMapa.numCostoEnvio.Minimum && costoViejo <= frmMapa.numCostoEnvio.Maximum)
                            frmMapa.numCostoEnvio.Value = costoViejo;
                    }

                    if (frmMapa.ShowDialog() == DialogResult.OK)
                    {
        
                        bool exito = await app.UpdateUbicacionCliente(
                            idCliente,
                            frmMapa.DireccionSeleccionada,
                            frmMapa.LatitudSeleccionada,
                            frmMapa.LongitudSeleccionada,
                            frmMapa.CostoSeleccionado
                        );

                        if (exito)
                        {
                            MessageBox.Show("La ubicación y tarifa se actualizaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await BuscarClientes(txtBuscar.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al guardar la ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarClientes(txtBuscar.Text.Trim());
        }

    }
}

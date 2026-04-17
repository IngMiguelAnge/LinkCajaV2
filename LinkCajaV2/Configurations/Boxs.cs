using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Boxs : Form
    {
        int CantidadCajas = 0;
        public Boxs()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            int list = obj.GetBoxsActives().Result.Count();
            if (list >= CantidadCajas)
            {
                MessageBox.Show("Has alcanzado el limite de cajas permitidas por tu licencia. Contacta al soporte para adquirir más cajas.", "Limite de cajas alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Box b = new Box();
            b.ShowDialog();
            BuscarBoxs();
        }

        private void Boxs_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            KeysModel ListKeys = obj.GetKeysActive().Result;
            if (ListKeys == null)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            EncrypDesencryp objEncryp = new EncrypDesencryp();
            string Key = objEncryp.Desencriptar(ListKeys.Key);
            string[] partes = Key.Split(new string[] { "Box", "box" }, StringSplitOptions.None);

            try
            {
                CantidadCajas = int.Parse(partes[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
           
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
            BuscarBoxs();
        }
        public async void BuscarBoxs()
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnBuscar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
            BtnNuevo.Enabled = false;
            dgvCajas.DataSource = null;
            dgvCajas.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => obj.GetBoxs(txtNombre.Text));
                dgvCajas.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron cajas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                BtnNuevo.Enabled = true;
            }
        }
        private void AgregarBotones()
        {
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvCajas.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambio Estado";
            btnCambiar.UseColumnTextForButtonValue = true;
            dgvCajas.Columns.Add(btnCambiar);
        }

        private void dgvCajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int Id =(int)dgvCajas.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvCajas.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Box m = new Box();
                    m.Id = Convert.ToInt32(Id);
                    m.ShowDialog();
                    BuscarBoxs();
                    break;
                case "btnCambiar":
                    string Estatus =(string)dgvCajas.Rows[e.RowIndex].Cells["Estatus"].Value;
                    AppRepository obj = new AppRepository();
                    if (Estatus != "Activo")
                    {
                        int list = obj.GetBoxsActives().Result.Count();
                        if (list >= CantidadCajas)
                        {
                            MessageBox.Show("Has alcanzado el limite de cajas permitidas por tu licencia. Contacta al soporte para adquirir más cajas.", "Limite de cajas alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    var resultado = obj.UpdateStatusBox(Id).Result;
                    if(resultado)
                    {
                        MessageBox.Show("Cambio de estado exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    BuscarBoxs();
                    break;
            }
        }
    }
}

using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Configurations
{
    public partial class CashFund : System.Windows.Forms.Form
    {
        public CashFund()
        {
            InitializeComponent();
        }

        private void CashFund_Load(object sender, EventArgs e)
        {
        }
        private void AgregarBotones()
        {
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Ver";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvFondoCaja.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnRetiros = new DataGridViewButtonColumn();
            btnRetiros.Name = "btnRetiros";
            btnRetiros.HeaderText = "Acción";
            btnRetiros.Text = "Retiros";
            btnRetiros.UseColumnTextForButtonValue = true;
            btnRetiros.FlatStyle = FlatStyle.Flat;
            btnRetiros.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnRetiros.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvFondoCaja.Columns.Add(btnRetiros);
            DataGridViewButtonColumn btnIngresos = new DataGridViewButtonColumn();
            btnIngresos.Name = "btnIngresos";
            btnIngresos.HeaderText = "Acción";
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseColumnTextForButtonValue = true;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnIngresos.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvFondoCaja.Columns.Add(btnIngresos);
        }
        private async void Buscar() {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnBuscar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
            btnNuevo.Enabled = false;
            dgvFondoCaja.DataSource = null;
            dgvFondoCaja.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => obj.GetCashFund(dtDesde.Value, dtHasta.Value));
                dgvFondoCaja.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (dgvFondoCaja.Columns["IdBox"] != null)
                {
                    dgvFondoCaja.Columns["IdBox"].Visible = false;
                }
                if (dgvFondoCaja.Columns["Id"] != null)
                {
                    dgvFondoCaja.Columns["Id"].Visible = false;
                }
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron cortes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                progressBar1.MarqueeAnimationSpeed = 0;
                btnBuscar.Enabled = true;
                btnNuevo.Enabled = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
         Buscar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Fund fund = new Fund();
            fund.ShowDialog();
            Buscar();
        }
        private void dgvFondoCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int Id = (int)dgvFondoCaja.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvFondoCaja.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Fund fund = new Fund();
                    fund.Id = Id;
                    fund.IdBox = (int)dgvFondoCaja.Rows[e.RowIndex].Cells["IdBox"].Value;
                    fund.ShowDialog();
                    Buscar();
                    break;
                case "btnRetiros":
                    RetirementConcept r = new RetirementConcept();
                    r.IdCashfund = Id;
                    r.Closse = true;
                    r.Retire = true;
                    r.Show();
                    break;
                case "btnIngresos":
                    RetirementConcept ing = new RetirementConcept();
                    ing.IdCashfund = Id;
                    ing.Closse = true;
                    ing.Retire = false;
                    ing.Show();
                    break;
            }
        }

    }
}

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

namespace LinkCajaV2.Items
{
    public partial class Fund : System.Windows.Forms.Form
    {
        public int Id { get; set; }
        public int IdBox { get; set; }
        private decimal totalGeneral = 0;
        private decimal devoluciones = 0;
        private decimal totalFinal = 0;
        private decimal TotalReal = 0;
        public Fund()
        {
            InitializeComponent();
            foreach (Control c in nudInicio.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.TextChanged += (s, e) =>
                    {
                        int pos = tb.SelectionStart;
                        Calcular();
                        tb.SelectionStart = pos;
                    };
                    break;
                }
            }

            // Buscamos y enlazamos el texto de NudRetiro
            foreach (Control c in NudRetiro.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.TextChanged += (s, e) =>
                    {
                        int pos = tb.SelectionStart;
                        Calcular();
                        tb.SelectionStart = pos;
                    };
                    break;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((int)CBCajas.SelectedValue <= 0)
            {
                MessageBox.Show("Se requiere una caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtFechaApertura.Value >= dtFechaCierre.Value)
            {
                MessageBox.Show("La fecha de apertura no puede ser mayor o igual a la fecha de cierre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TotalReal < 0)
            {
                MessageBox.Show("El fondo de caja no puede quedar en negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Guardar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Fund_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();

            var ListBox = obj.GetBoxsActives().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListBox.Insert(0, new ListBoxModel { Id = 0, Nombre = "Seleccione", Estatus = "Inactivo" });
            CBCajas.Items.Clear();
            CBCajas.DisplayMember = "Nombre";
            CBCajas.ValueMember = "Id";
            CBCajas.DataSource = ListBox;
            CBCajas.SelectedIndex = 0;
            btnCerrar.Visible = false;
            btnGuardar.Visible = true;
            if (Id != 0)
            {
                if (ListBox.Where(x => x.Id == IdBox).FirstOrDefault() == null)
                {
                    MessageBox.Show("Caja no activa.", "Caja no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                CBCajas.SelectedValue = IdBox;
                CBCajas.Enabled = false;
                var result = obj.GetCashFundbyId(Id).Result;
                dtFechaApertura.Value = result.CheckIn;
                dtFechaCierre.Value = result.CheckOut;
                nudInicio.Value = result.CashIn;
                NudRetiro.Value = result.CashOut;
                lblFondoQueda.Text = "Fondo que se queda: " + result.CashFinish.ToString("C2");
                if (result.StatusOpen == true)
                {
                    btnGuardar.Visible = true;
                    btnCerrar.Visible = true;
                }
                else {
                    btnGuardar.Visible = false;
                    btnCerrar.Visible = false;
                }
                //BuscarTickets();
            }
        }

        private void CBCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCajas.SelectedIndex == 0)
            {
                nudInicio.Value = 0m;
                NudRetiro.Value = 0m;
                lblVenta.Text = "Venta total: $0.00";
                lblTotalDevolucion.Text = "Devolucion Total: $0.00";
                lblSaldoTotal.Text = "Saldo Teorico en Caja: $0.00";
                lblFondoQueda.Text = "Fondo que se queda: $0.00";
                return;
            }
            AppRepository obj = new AppRepository();
            if(Id == 0)
            {
                var result = obj.GetCashFundbyIdBox((int)CBCajas.SelectedValue).Result;
                if (result != null && result.Id != 0)
                {
                    if (result.StatusOpen == true)
                    {
                        MessageBox.Show("La caja tiene un corte de abierto pendiente del " + result.CheckIn.ToString(), "Caja no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnGuardar.Visible = false;
                        btnCerrar.Visible = false;
                        return;
                    }
                    else
                    {                        
                            btnGuardar.Visible = true;
                            dtFechaApertura.MinDate = result.CheckOut.AddMinutes(1);
                            dtFechaCierre.MinDate = result.CheckOut.AddMinutes(1);
                            dtFechaApertura.Value = result.CheckIn.AddDays(1);
                            dtFechaCierre.Value = result.CheckOut.AddDays(1);
                            nudInicio.Value = result.CashFinish;
                            NudRetiro.Value = 0m;
                    }
                }
            }
            BuscarTickets();
        }

        public void Calcular()
        {
            string txtInicio = nudInicio.Text.Trim();
            string txtRetiro = NudRetiro.Text.Trim();

            decimal.TryParse(txtInicio, out decimal vInicio);
            decimal.TryParse(txtRetiro, out decimal vRetiro);

            decimal totalfinalreal = totalFinal + vInicio;
            TotalReal = totalfinalreal - vRetiro;
            lblVenta.Text = $"Venta Total: {totalGeneral:C2}";
            lblTotalDevolucion.Text = $"Devolucion Total: {devoluciones:C2}";
            lblSaldoTotal.Text = $"Saldo Teorico en Caja: {totalfinalreal:C2}";
            lblFondoQueda.Text = $"Fondo que se queda: {TotalReal:C2}";
        }
        public async void BuscarTickets()
        {
            try
            {
                AppRepository obj = new AppRepository();
                var Tickets = await obj.GetTicketsbyDates((int)CBCajas.SelectedValue, dtFechaApertura.Value, dtFechaCierre.Value);
                var listaFinal = Tickets?.ToList() ?? new List<ListTicketModel>();
                totalGeneral = listaFinal.Sum(item => item.Total);
                devoluciones = listaFinal.Sum(item => item.TotalReturn);
                totalFinal = listaFinal.Sum(item => item.TotalEnd);
                Calcular();
            }
            catch (Exception ex)
            {
                totalGeneral = 0m;
                devoluciones = 0m;
                totalFinal = 0m;
                TotalReal = 0m;
                lblVenta.Text = "Venta total: $0.00";
                lblTotalDevolucion.Text = "Devolucion Total: $0.00";
                lblSaldoTotal.Text = "Saldo Teorico en Caja: $0.00";
                lblFondoQueda.Text = "Fondo que se queda: $0.00";
            }
        }
        private void dtFechaApertura_ValueChanged(object sender, EventArgs e)
        {
            BuscarTickets();
        }

        private void dtFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            BuscarTickets();
        }

        public void Guardar(bool Cerrar)
        {
            AppRepository obj = new AppRepository();
            CashFundModel cash = new CashFundModel();
            cash.Id = Id;
            cash.IdBox = (int)CBCajas.SelectedValue;
            cash.CheckIn = dtFechaApertura.Value;
            cash.CheckOut = dtFechaCierre.Value;
            cash.CashIn = nudInicio.Value;
            cash.CashOut = NudRetiro.Value;
            cash.CashFinish = TotalReal;
            var result = obj.SaveCashFund(cash).Result;
            if (result)
            {
                if (Cerrar == true)
                {
                    var result2 = obj.UpdateStatusCashFund(Id).Result;
                    if (result2)
                    {
                        MessageBox.Show("Corte cerrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error al cerrar el corte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Corte guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Error al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if ((int)CBCajas.SelectedValue <= 0)
            {
                MessageBox.Show("Se requiere una caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtFechaApertura.Value >= dtFechaCierre.Value)
            {
                MessageBox.Show("La fecha de apertura no puede ser menor a la fecha de cierre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TotalReal < 0)
            {
                MessageBox.Show("El fondo de caja no puede quedar en negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultado = MessageBox.Show("Esta por cerrar el corte, si continua no podra modificarlo ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            Guardar(true);
        }

        private void NudRetiro_KeyUp(object sender, KeyEventArgs e)
        {
            DomainUpDown dud = sender as DomainUpDown;
            if (dud == null) return;

            // Buscamos el TextBox interno de forma segura
            TextBox tb = null;
            foreach (Control c in dud.Controls)
            {
                if (c is TextBox)
                {
                    tb = (TextBox)c;
                    break;
                }
            }

            if (tb != null)
            {
                int cursorPosition = tb.SelectionStart;
                Calcular();
                tb.SelectionStart = cursorPosition;
            }
            else
            {
                Calcular();
            }
        }

        private void nudInicio_KeyUp(object sender, KeyEventArgs e)
        {
            DomainUpDown dud = sender as DomainUpDown;
            if (dud == null) return;

            // Buscamos el TextBox interno de forma segura
            TextBox tb = null;
            foreach (Control c in dud.Controls)
            {
                if (c is TextBox)
                {
                    tb = (TextBox)c;
                    break;
                }
            }

            if (tb != null)
            {
                int cursorPosition = tb.SelectionStart;
                Calcular();
                tb.SelectionStart = cursorPosition;
            }
            else
            {
                Calcular();
            }
        }
    }
}

using LinkCajaV2.Catalogs;
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
        private decimal totalGeneralTarjeta = 0;
        private decimal totalGeneral = 0;
        private decimal devoluciones = 0;
        private decimal devolucionesTarjeta = 0;
        private decimal totalFinal = 0;
        private decimal totalFinalTarjeta = 0;
        private decimal TotalCaja = 0;
        private decimal totalfinalreal = 0;
        private bool Primeracarga = false;
        private decimal InicioSaldo = 0;
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
            BtnAbrir.Visible = false;
            BtnAgregar.Visible = false;
            BtnAgregar2.Visible = false;
            dtFechaApertura.Enabled = false;
            if (Id != 0)
            {
                Primeracarga = true;
                if (ListBox.Where(x => x.Id == IdBox).FirstOrDefault() == null)
                {
                    MessageBox.Show("Caja no activa.", "Caja no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                btnCerrar.Visible = true;
                BtnAgregar.Visible = true;
                BtnAgregar2.Visible = true;
                CBCajas.SelectedValue = IdBox;
                CBCajas.Enabled = false;
                var result = obj.GetCashFundbyId(Id).Result;
                dtFechaApertura.Value = result.CheckIn;
                nudInicio.Value = result.CashIn;
                InicioSaldo = result.CashIn;
                NudRetiro.Value = result.CashOut;
                lblFondoQueda.Text = "Fondo que se queda: " + result.CashFinish.ToString("C2");
                if (result.StatusOpen == true)
                {
                    dtFechaCierre.Value = DateTime.Now;
                }
                else
                {
                    dtFechaCierre.Value = result.CheckOut;
                    btnCerrar.Visible = false;
                    BtnAgregar.Visible = false;
                    BtnAgregar2.Visible = false;
                }
                Primeracarga = false;
                BuscarTickets();
            }
            else
            {
                dtFechaCierre.Value = dtFechaApertura.Value.AddSeconds(1);
                BtnAbrir.Visible = true;
                dtFechaApertura.Enabled = true;
                dtFechaApertura.Enabled = true;
            }
        }
        public void Reiniciar()
        {
            totalGeneral = 0m;
            totalGeneralTarjeta = 0m;
            devoluciones = 0m;
            devolucionesTarjeta = 0m;
            totalFinal = 0m;
            totalFinalTarjeta = 0m;
            lblVenta.Text = "Venta total en efectivo: $0.00";
            lblVentaContarjeta.Text = "Venta total con tarjeta: $0.00";
            lblTotalDevolucion.Text = "Devolución total en efectivo: $0.00";
            lbTotallDevolucionTarjeta.Text = "Devolución total en tarjeta: $0.00";
            lblSaldoTotalTarjeta.Text = "Saldo en tarjeta: $0.00";
            Calcular();
        }
        private void CBCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCajas.SelectedIndex == 0)
            {
                nudInicio.Value = 0m;
                NudRetiro.Value = 0m;
                Reiniciar();
                return;
            }
            AppRepository obj = new AppRepository();
            if (Id == 0)
            {
                var result = obj.GetCashFundbyIdBox((int)CBCajas.SelectedValue).Result;
                if (result != null && result.Id != 0)
                {
                    if (result.StatusOpen == true)
                    {
                        MessageBox.Show("La caja tiene un corte de abierto pendiente del " + result.CheckIn.ToString(), "Caja no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnCerrar.Visible = false;
                        BtnAbrir.Visible = false;
                        BtnAgregar.Visible = false;
                        BtnAgregar2.Visible = false;
                        return;
                    }
                    else
                    {
                        BtnAbrir.Visible = true;
                        btnCerrar.Visible = false;
                        BtnAgregar.Visible = false;
                        BtnAgregar2.Visible = false;
                        dtFechaApertura.MinDate = result.CheckOut.AddSeconds(1);
                        dtFechaCierre.MinDate = result.CheckOut.AddSeconds(2);
                        dtFechaApertura.Value = DateTime.Now;
                        dtFechaCierre.Value = DateTime.Now.AddSeconds(1);
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

            totalfinalreal = totalFinal + vInicio;
            TotalCaja = totalfinalreal - vRetiro;
            lblSaldoEfectivoCaja.Text = $"Saldo en efectivo en caja: {totalfinalreal:C2}";
            lblFondoQueda.Text = $"Fondo que se queda: {TotalCaja:C2}";
        }
        public async void BuscarTickets()
        {
            try
            {
                if (Primeracarga == true)
                {
                    return;
                }
                AppRepository obj = new AppRepository();
                var Tickets = await obj.GetCashDropbyIdBox((int)CBCajas.SelectedValue, dtFechaApertura.Value, dtFechaCierre.Value, false);
                totalGeneral = Tickets.Where(x => x.Concepto == "Ventas en efectivo").Sum(y => y.Monto);
                totalGeneralTarjeta = Tickets.Where(x => x.Concepto == "Ventas con tarjeta").Sum(y => y.Monto);
                devoluciones = Tickets.Where(x => x.Concepto == "Devoluciones en efectivo").Sum(y => y.Monto);
                devolucionesTarjeta = Tickets.Where(x => x.Concepto == "Devoluciones en tarjeta").Sum(y => y.Monto);
                totalFinal = Tickets.Where(x => x.Concepto == "Venta total en efectivo").Sum(y => y.Monto);
                totalFinalTarjeta = Tickets.Where(x => x.Concepto == "Venta total en tarjeta").Sum(y => y.Monto);
                lblVenta.Text = "Venta total en efectivo: $" + totalGeneral.ToString();
                lblVentaContarjeta.Text = "Venta total con tarjeta: $" + totalGeneralTarjeta.ToString();
                lblTotalDevolucion.Text = "Devolución total en efectivo: $" + devoluciones.ToString();
                lbTotallDevolucionTarjeta.Text = "Devolución total en tarjeta: $" + devolucionesTarjeta.ToString();
                lblSaldoTotalTarjeta.Text = "Saldo en tarjeta: $" + totalFinalTarjeta.ToString();
                Calcular();
            }
            catch (Exception ex)
            {
                Reiniciar();
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
            cash.CashFinish = TotalCaja;
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
            if (TotalCaja < 0)
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
            this.Close();
        }

        private void NudRetiro_KeyUp(object sender, KeyEventArgs e)
        {
            //DomainUpDown dud = sender as DomainUpDown;
            //if (dud == null) return;

            //// Buscamos el TextBox interno de forma segura
            //TextBox tb = null;
            //foreach (Control c in dud.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        tb = (TextBox)c;
            //        break;
            //    }
            //}

            //if (tb != null)
            //{
            //    int cursorPosition = tb.SelectionStart;
            //    Calcular();
            //    tb.SelectionStart = cursorPosition;
            //}
            //else
            //{
            //    Calcular();
            //}
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

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if ((int)CBCajas.SelectedValue <= 0)
            {
                MessageBox.Show("Se requiere una caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtFechaApertura.Value > dtFechaCierre.Value)
            {
                MessageBox.Show("La fecha de apertura no puede ser mayor a la fecha de cierre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Guardar(false);
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RetirementConcept retiros = new RetirementConcept();
            retiros.FechaMinima = dtFechaApertura.Value;
            retiros.IdCashfund = Id;
            retiros.TotalMax = totalfinalreal;
            retiros.Retire = true;
            retiros.ShowDialog();
            if (retiros.sicambio)
            {
                NudRetiro.Value = retiros.TotalGeneral;
                Calcular();
                Guardar(false);
            }
        }

        private void BtnAgregar2_Click(object sender, EventArgs e)
        {
            RetirementConcept retiros = new RetirementConcept();
            retiros.FechaMinima = dtFechaApertura.Value;
            retiros.IdCashfund = Id;
            retiros.TotalMax = nudInicio.Value;
            retiros.Retire = false;
            retiros.ShowDialog();
            if (retiros.sicambio)
            {
                nudInicio.Value = InicioSaldo + retiros.TotalGeneral;
                Calcular();
                Guardar(false);
            }
        }

    }
}

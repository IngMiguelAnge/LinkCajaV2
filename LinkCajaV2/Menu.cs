using LinkCajaV2.Catalogs;
using LinkCajaV2.Configuraciones;
using LinkCajaV2.Configurations;
using LinkCajaV2.Items;
using LinkCajaV2.Reports;
using LinkCajaV2.Sales;
using System;
using System.Windows.Forms;

namespace LinkCajaV2
{
    public partial class Menu : Form
    {
        public int IdUsuario { get; set; }
        public int IdTypeUser { get; set; }
        public string NameUser { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido al sistema " + NameUser;
        }
        private void btnPanelVentas_Click(object sender, EventArgs e)
        {
            Venta s = new Venta();
            s.IdUsuario = IdUsuario;
            s.NameUser = NameUser;
            s.Show();
        }
        private void btnPanelArticulos_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.IsVenta = false;
            a.IdUsuario = IdUsuario;
            a.NameUser = NameUser;
            a.Show();
        }

        private void btnPanelEmpresa_Click(object sender, EventArgs e)
        {
            Company m = new Company();
            m.Show();
        }

        private void btnPanelCorte_Click(object sender, EventArgs e)
        {
            CashDrop c = new CashDrop();
            c.Show();
        }

        private void btnVentaMostrador_Click(object sender, EventArgs e)
        {
            Venta s = new Venta();
            s.IdUsuario = IdUsuario;
            s.NameUser = NameUser;
            s.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            t.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Suppliers m = new Suppliers();
            m.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
        }

        private void btnArticules_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.IsVenta = false;
            a.IdUsuario = IdUsuario;
            a.NameUser = NameUser;
            a.Show();
        }

        private void btnCorteCaja_Click(object sender, EventArgs e)
        {
            CashDrop c = new CashDrop();
            c.Show();
        }

        private void btnImpresiones_Click(object sender, EventArgs e)
        {
            Impressions s = new Impressions();
            s.Show();
        }

        private void btnConfigCajas_Click(object sender, EventArgs e)
        {
            Boxs b = new Boxs();
            b.Show();
        }

        private void btnMiEmpresa_Click(object sender, EventArgs e)
        {
            Company m = new Company();
            m.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            Licenses l = new Licenses();
            l.Show();
        }

        private void BtnPanelSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

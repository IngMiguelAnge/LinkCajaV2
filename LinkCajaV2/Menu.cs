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
            s.IdTypeUser = IdTypeUser;
            s.Show();
            this.Hide();
        }
        private void btnPanelArticulos_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.IsVenta = false;
            a.IdUsuario = IdUsuario;
            a.NameUser = NameUser;
            a.IdTypeUser = IdTypeUser;
            a.Show();
            this.Hide();
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
            s.IdTypeUser = IdTypeUser;
            s.Show();
            this.Hide();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            t.IdUsuario = IdUsuario;
            t.NameUser = NameUser;
            t.IdTypeUser = IdTypeUser;
            t.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.IdUsuario = IdUsuario;
            u.NameUser = NameUser;
            u.IdTypeUser = IdTypeUser;
            u.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Suppliers m = new Suppliers();
            m.IdUsuario= IdUsuario;
            m.NameUser= NameUser;
            m.IdTypeUser= IdTypeUser;
            m.Show();
            this.Hide();
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
            a.IdTypeUser = IdTypeUser;
            a.Show();
            this.Hide();
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
            b.IdUsuario = IdUsuario;
            b.NameUser = NameUser;
            b.IdTypeUser = IdTypeUser;
            b.Show();
            this.Hide();
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

        private void btnPanelMenu_Click(object sender, EventArgs e)
        {

        }

        private void flowContenedorCentral_Paint(object sender, PaintEventArgs e)
        {
            if(IdTypeUser == 2)//Vendedor
            {             
                //Menu principal
                panelCatalogos.Visible = false;
                panelConfiguraciones.Visible = false;
                panelOperacionesCaja.Visible = false;
                //Menu lateral
                btnPanelEmpresa.Visible = false;
                btnPanelCorte.Visible = false;             
            }
            if (IdTypeUser == 3)//Almacenista
            {
                //Menu principal
                panelVentas.Visible = false;
                panelConfiguraciones.Visible = false;
                panelOperacionesCaja.Visible = false;
                btnUsuarios.Visible = false;
                //Menu lateral
                btnPanelEmpresa.Visible = false;
                btnPanelCorte.Visible = false;
                btnPanelVentas.Visible = false;
            }
        }
    }
}

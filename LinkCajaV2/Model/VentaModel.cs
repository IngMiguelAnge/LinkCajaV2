using System.ComponentModel;

namespace LinkCajaV2.Model
{
    public class VentaModel
    {
        public BindingList<ArticlesSalesModel> Articles { get; set; }
        public decimal Copias { get; set; }
        public CompanyModel Company { get; set; }
        public bool Imprimir { get; set; }
        public decimal Recibido { get; set; }
        public int IdTicket { get; set; }
        public string Cliente { get; set; }
        public string BoxName { get; set; }
        public decimal Total { get; set; }
        public string Title { get; set; }
    }
}

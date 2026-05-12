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
    }
}

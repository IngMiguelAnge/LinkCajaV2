using System;

namespace LinkCajaV2.Model
{
    public class ListArticlesModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Articulo { get; set; }
        public decimal Existencias { get; set; }
        public string Presentacion { get; set; }
        public decimal Precio { get; set; }
    }
}
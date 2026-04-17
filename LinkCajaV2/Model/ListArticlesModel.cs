using System;

namespace LinkCajaV2.Model
{
    public class ListArticlesModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Articulo { get; set; }
        public string Existencias { get; set; }
        public decimal Precio { get; set; }
        public string PorCada { get; set; }
        public string Estatus { get; set; }
    }
}
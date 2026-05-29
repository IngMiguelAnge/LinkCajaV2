namespace LinkCajaV2.Model
{
    public class ListArticlesActivesModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Stock { get; set; }
        public decimal Precio { get; set; }
        public string PorCada { get; set; }
        public string EsMedicina { get; set; }
        public string Categoria { get; set; }
    }
}

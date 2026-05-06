namespace LinkCajaV2.Model
{
    public class StockModel
    {
        public int Id { get; set; } //Como estan en el mismo id este es el id article
        public decimal Stock { get; set; }
        public int IdPresentation { get; set; }
        public string Presentation { get; set; }
        public decimal Price { get; set; }
        public decimal SuggestedStock { get; set; }
        public decimal Margen { get; set; }
    }
}

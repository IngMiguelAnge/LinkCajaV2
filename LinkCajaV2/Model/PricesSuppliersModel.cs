namespace LinkCajaV2.Model
{
    public class PricesSuppliersModel
    {
        public int Id { get; set; }
        public int IdSupplier { get; set; }
        public int IdArticle { get; set; }
        public decimal PriceUnit { get; set; }
        public int IdPresentation { get; set; }
        public bool Status { get; set; }
    }
}

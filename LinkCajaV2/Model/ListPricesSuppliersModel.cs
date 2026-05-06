namespace LinkCajaV2.Model
{
    public class ListPricesSuppliersModel
    {
        public int Id { get; set; }
        public int IdSupplier { get; set; }
        public string Name { get; set; }
        public decimal PriceUnit { get; set; }
        public int IdPresentation { get; set; }
    }
}

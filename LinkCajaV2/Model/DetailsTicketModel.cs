namespace LinkCajaV2.Model
{
    public class DetailsTicketModel
    {
        public int Id { get; set; }
        public int IdTicket { get; set; }
        public int IdArticle { get; set; }
        public int IdPresentation { get; set; }
        public decimal StockSold { get; set; }
        public decimal PriceSold { get; set; }
        public decimal TotalSold { get; set; }
    }
}

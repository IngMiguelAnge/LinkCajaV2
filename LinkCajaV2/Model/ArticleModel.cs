namespace LinkCajaV2.Model
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Code { get; set; }
        public decimal Stock { get; set; }
        public int IdPresentation { get; set; }
        public string Presentation { get; set; }
        public decimal Price { get; set; }
        public decimal SuggestedStock { get; set; }
        public bool Status { get; set; }
    }
}

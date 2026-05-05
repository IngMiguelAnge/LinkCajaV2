namespace LinkCajaV2.Model
{
    public class ItemsRecipeModel
    {
        public int IdArticle { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public string Presentation { get; set; }
        public decimal Price { get; set; }
        public int Decimals { get; set; }
        public byte[] Image { get; set; }
        // Variable interna para guardar lo que viene de la base de datos
        private decimal? _totalSql;

        public decimal Total
        {
            get
            {
                   return (Decimals > 0)
                    ? (Stock * 1000) * Price
                    : Stock * Price;
            }
            set
            {
                _totalSql = value;
            }
        }
    }
}

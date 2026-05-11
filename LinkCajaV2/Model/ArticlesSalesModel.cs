using System;

namespace LinkCajaV2.Model
{
    public class ArticlesSalesModel
    {
        public int IdArticle { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public string Presentation { get; set; }
        public decimal Price { get; set; }
        public decimal Total => Math.Round(
         Decimals > 0 ? (Stock * 1000) * Price : Stock * Price,
         2,
         MidpointRounding.AwayFromZero
     );
        public int Decimals { get; set; }
        public byte[] Image { get; set; }
    }
}

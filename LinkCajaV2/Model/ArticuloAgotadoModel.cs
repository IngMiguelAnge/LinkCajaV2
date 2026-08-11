namespace LinkCajaV2.Model
{
    public class ArticuloAgotadoModel
    {
        public string Code { get; set; }           // Código de barras
        public string Description { get; set; }    // Descripción del artículo
        public string Category { get; set; }       // Categoría 
        public decimal StockMin { get; set; }      // Existencias mínimas
        public decimal Stock { get; set; }         // Existencias actuales
    }
}
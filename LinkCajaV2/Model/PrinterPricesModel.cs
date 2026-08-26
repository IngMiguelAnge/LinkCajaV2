namespace LinkCajaV2.Model
{
    public class PrinterPricesModel
    {
        public string Codigo { get; set; }
        public string Articulo { get; set; }  
        public string Categoria { get; set; }
        public string ClaveSAT { get; set; }
        public decimal Precio { get; set; }
        public string Stock { get; set; }
        public string StockMinimo { get; set; }
    }
}

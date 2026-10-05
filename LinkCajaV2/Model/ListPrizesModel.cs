namespace LinkCajaV2.Model
{
    public class ListPrizesModel
    {
        public int Id { get; set; }
        public int IdArticle {  get; set; }
        public string Nombre {  get; set; }
        public string Cantidad { get; set; }
        public string Estatus {  get; set; }
        public decimal QuantityPerSpin { get; set; }
        public string Presentation { get; set; }
        public string CantidadPorGiro
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Presentation))
                    return QuantityPerSpin.ToString("N3");

                if (Presentation.ToLower().Contains("kg") ||
                    Presentation.ToLower().Contains("gr"))
                {
                    return QuantityPerSpin.ToString("N3") + " " + Presentation;
                }

                if (QuantityPerSpin % 1 == 0)
                {
                    return ((int)QuantityPerSpin).ToString()
                           + " "
                           + Presentation;
                }

                return QuantityPerSpin.ToString("N3")
                       + " "
                       + Presentation;
            }
        }

    }
}

using System;

namespace LinkCajaV2.Model
{
    public class CashDropModel
    {
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public string Articulo {  get; set; }
        public DateTime Fecha { get; set; }
        public string VerConcepto { get; set; }
        public string Presentation { get; set; }
        public string MontoConPresentacion
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Presentation))
                    return Monto.ToString("N3");
                if (Presentation.ToLower().Contains("kg") ||
                    Presentation.ToLower().Contains("gr"))
                {
                    return Monto.ToString("N3") + " " + Presentation;
                }
                if (Monto % 1 == 0)
                {
                    return ((int)Monto).ToString() + " " + Presentation;
                }
                return Monto.ToString("N3")+ " " + Presentation;
            }
        }

    }
}

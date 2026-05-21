
using System;
using System.Collections.Generic;

namespace LinkCajaV2.Model
{
    public class BillingDetails
    {
        public string IdTicket { get; set; }
        public string FormPayment { get; set; } //Forma de pago
        public string Total { get; set; }//Total por toda la venta
        public string PaymentMethod { get; set; } //Metodo de pago
        public string IssuingLocation { get; set; } //Lugar de expedición
        public DateTime DateCreated { get; set; } //Fecha de creación
        public Sender Sender { get; set; } //Emisor
        public List<Concepts> Concepts { get; set; } //Conceptos
    }
    public class Sender
    {
        public string RFC { get; set; }
        public string Name { get; set; }
        public string TaxRegime { get; set; } //Régimen fiscal
    }
    public class Concepts
    {
        public string CodeSAT { get; set; }//Clave SAT
        public string CodeProdServ { get; set; }//Clave producto o servicio
        public string Stock { get; set; }//Cantidad
        public string UnitSAT { get; set; }//Clave unidad SAT
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } //Fecha de creación
        public DateTime LastModific { get; set; } //Fecha de modificacion
        public decimal UnitValue { get; set; }//Valor unitario
        public decimal Import { get; set; }//Importe
        public string ObjetImp { get; set; }//Objeto de impuesto
        public Taxs Tax { get; set; }//Impuestos
    }
    public class Taxs
    {
        public decimal Base { get; set; }
        public string Tax { get; set; }//Impuesto
        public string TypeFactor { get; set; }//Tipo de factor
        public string Rate { get; set; }//Tasa o cuota
        public decimal Import { get; set; }//Importe
    }
}

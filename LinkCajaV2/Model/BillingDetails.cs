
using System;
using System.Collections.Generic;

namespace LinkCajaV2.Model
{
    public class BillingDetails
    {
        public string pos_ticket_id { get; set; }
        public string serie { get; set; } //Serie del comprobante
        public string folio { get; set; }
        public string form_payment { get; set; } //Forma de pago
        public string total { get; set; }//Total por toda la venta
        public string payment_method { get; set; } //Metodo de pago
        public string currency { get; set; } //Moneda
        public decimal? exchange_rate { get; set; }
        public string exportacion { get; set; }
        public string payment_conditions { get; set; }
        public string issuing_location { get; set; } //Lugar de expedición
        public string sold_at { get; set; } //Fecha de creación
        //public Sender Sender { get; set; } //Emisor
        public List<conceptsfacture> concepts { get; set; } //Conceptos
    }
    public class conceptsfacture
    {
        public string clave_prod_serv { get; set; }//Clave SAT
        public string no_identificacion { get; set; }//Clave producto o servicio
        public decimal quantity { get; set; }//Cantidad
        public string clave_unidad { get; set; }//Clave unidad SAT
        public string unit { get; set; }//Unidad de medida
        public string description { get; set; }
        public decimal unit_value { get; set; }//Valor unitario
        public decimal amount { get; set; }//Importe
        public decimal? discount { get; set; }//Descuento
        public string object_tax { get; set; }//Objeto de impuesto
        public List<taxes> taxes { get; set; }//Impuestos
    }
    public class taxes
    {
        public string tax_type { get; set; }
        public decimal @base { get; set; }
        public string tax { get; set; }//Impuesto
        public string type_factor { get; set; }//Tipo de factor
        public string rate { get; set; }//Tasa o cuota
        public decimal amount { get; set; }//Importe
    }
}

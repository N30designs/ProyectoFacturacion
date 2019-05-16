using System;
using System.ComponentModel.DataAnnotations;


namespace facturacion.Model
{
    class Pago
    {
        [Key,MaxLength(30) ]
        public int PagoID { get; set; }

        public DateTime FechaPago { get; set; }


        public virtual TipoPago TipoPago { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Factura Factura { get; set; }

    }
}

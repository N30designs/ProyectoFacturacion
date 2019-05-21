using System;
using System.ComponentModel.DataAnnotations;


namespace facturacion.Model
{
    /// <summary>
    /// Modelo utilizado para gestionar los pagos realizados.
    /// </summary>
    public class Pago
    {
        [Key]
        public int PagoID { get; set; }

        public DateTime FechaPago { get; set; }


        public virtual TipoPago TipoPago { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Factura Factura { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de crear las facturas de los pedidos, se relacionará con empresa, cliente, pago e impuestos.
    /// </summary>
   public class Factura
    {
        [Key]
        public int FacturaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
        
        [Required]
        public Decimal Importe { get; set; }

       
        public int Descuento_Factura { get; set; }

        [Required]
        public decimal ImporteBruto { get; set; }

        public decimal ImporteRetencion { get; set; }

        [Required]
        public decimal Total { get; set; }

        public string Nota { get; set; }

        [Required]
        public DateTime Creacion { get; set; }
        
      
        public DateTime Modificacion { get; set; }
                          

        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Pago> Pago { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Impuesto> Impuestos { get; set; }

    }
}

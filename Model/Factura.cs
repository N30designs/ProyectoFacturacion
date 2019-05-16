using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Factura
    {
        [Key, MaxLength(30)]
        public int FacturaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
        
        [Required, Range(0,999999.99)]
        public Decimal Importe { get; set; }

        [MaxLength(2)]
        public int Descuento_Factura { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal ImporteBruto { get; set; }

        [Range(0, 999999.99)]
        public decimal ImporteRetencion { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal Total { get; set; }

        public string Nota { get; set; }

        [Required]
        public DateTime Creacion { get; set; }
        
        [Timestamp]
        public DateTime Modificacion { get; set; }
                          

        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Pago> Pago { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Impuesto> Impuestos { get; set; }

    }
}

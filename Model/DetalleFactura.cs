using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class DetalleFactura
    {
        [Key, MaxLength(30)]
        public int DetalleFacturaID { get; set; }

        [Required, MaxLength(100)]
        public string Concepto { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal Importe { get; set; }

        [MaxLength(2)]
        public int Descuento { get; set; }

        [Required, Range(0,999999.99)]
        public decimal ImporteBruto { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal ImporteImpuesto { get; set; }

        [MaxLength(2)]
        public int PorcentajeImpuestoAsociado { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal ImporteImpuestoAsociado{ get; set; }

        [Required, Range(0, 999999.99)]
        public decimal Total { get; set; }

        [MaxLength(50)]
        public string Lote { get; set; }

        [MaxLength(100)]
        public string Serie { get; set; }

        [Range(0,99999.999)]
        public decimal Peso { get; set; }

        public DateTime Fecha_Fabricacion { get; set; }




        public virtual Factura Factura { get; set; }
        public virtual Impuesto Impuesto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo que crea cada línea de factura con todos sus detalles, el modelo factura dependerá de él.
    /// </summary>
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaID { get; set; }

        [Required, MaxLength(100)]
        public string Concepto { get; set; }

        [Required]
        public decimal Importe { get; set; }

        
        public int Descuento { get; set; }

        [Required]
        public decimal ImporteBruto { get; set; }

        [Required]
        public decimal ImporteImpuesto { get; set; }

        
        public int PorcentajeImpuestoAsociado { get; set; }

        [Required]
        public decimal ImporteImpuestoAsociado{ get; set; }

        [Required]
        public decimal Total { get; set; }

        [MaxLength(50)]
        public string Lote { get; set; }

        [MaxLength(100)]
        public string Serie { get; set; }

        
        public decimal Peso { get; set; }

        public DateTime Fecha_Fabricacion { get; set; }




        public virtual Factura Factura { get; set; }
        public virtual Impuesto Impuesto { get; set; }
    }
}

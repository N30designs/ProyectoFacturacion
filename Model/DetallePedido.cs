using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace facturacion.Model
{
    /// <summary>
    /// Modelo que crea cada línea de pedido, el modelo pedido dependerá de él.
    /// </summary>
    public class DetallePedido
    {

        [Key]
        public int DetallePedidoID { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Importe { get; set; }

        
        public int ArticuloDescuento { get; set; }

        
        public int LineaDescuento { get; set; }

        
        public Decimal ImporteBruto { get; set; }

        [MaxLength(100)]
        public string Lote { get; set; }

        [MaxLength(100)]
        public string Serie { get; set; }

        [Required]
        public float Peso { get; set; }

        public DateTime FechaFabricacion { get; set; }

        [Required]
        public int ImpuestoPorcentaje { get; set; }

        [Required]
        public decimal ImpuestoImporte { get; set; }

        public int ImpuestoAsociadoPorcentaje { get; set; }

        
        public decimal ImpuestoAsociadoImporte { get; set; }

        [Required]
        public decimal LineaTotal { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }

        public virtual Impuesto Impuesto_ID { get; set; }
        
    }
}

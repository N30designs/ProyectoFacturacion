using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace facturacion.Model
{
    class DetallePedido
    {

        [Key, MaxLength(30)]
        public int DetallePedidoID { get; set; }

        [Required, MaxLength(4)]
        public int Cantidad { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal Importe { get; set; }

        [MaxLength(2)]
        public int ArticuloDescuento { get; set; }

        [MaxLength(2)]
        public int LineaDescuento { get; set; }

        [Range(0, 99999.99)]
        public Decimal ImporteBruto { get; set; }

        [MaxLength(100)]
        public string Lote { get; set; }

        [MaxLength(100)]
        public string Serie { get; set; }

        [Required, Range(0, 999999.99)]
        public float Peso { get; set; }

        public DateTime FechaFabricacion { get; set; }

        [Required, MaxLength(2)]
        public int ImpuestoPorcentaje { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal ImpuestoImporte { get; set; }

        [MaxLength(2)]
        public int ImpuestoAsociadoPorcentaje { get; set; }

        [Range(0, 999999.99)]
        public decimal ImpuestoAsociadoImporte { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal LineaTotal { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }

        public virtual Impuesto Impuesto_ID { get; set; }
        
    }
}

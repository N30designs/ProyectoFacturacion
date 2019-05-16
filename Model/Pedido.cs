using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Pedido
    {
        [Key, MaxLength(30)]
        public int PedidoID { get; set; }

        [Required]
        public DateTime PedidoFecha { get; set; }

        [Required, Range(0,999999.99)]
        public decimal Importe { get; set; }

        [MaxLength(2)]
        public int PedidoDescuento { get; set; }

        [Range(0, 999999.99)]
        public Decimal DescuentosDetalle { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal ImporteBruto { get; set; }

        [Range(0, 999999.99)]
        public decimal ImporteTransporte { get; set; }

        public DateTime FechaSalida { get; set; }

        [Required, Range(0, 999999.99)]
        public decimal Total { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }



        [Required]
        public virtual Cliente Cliente { get; set; }

        public virtual Direccion DireccionEnvio { get; set; }

        public virtual Transportista Transportista { get; set; }

        public virtual Empleado Vendedor { get; set; }

        public virtual Empleado Preparador { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}

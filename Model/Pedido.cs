using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo destinado a gestionar los distintos pedidos, se asocia a los modelos Cliente, Dirección,
    /// Transportista, Empleado y pagos.
    /// </summary>
    public class Pedido
    {
        [Key]
        public int PedidoID { get; set; }

        [Required]
        public DateTime PedidoFecha { get; set; }

       
        public decimal Importe { get; set; }

        
        public int PedidoDescuento { get; set; }

        
        public Decimal DescuentosDetalle { get; set; }

        [Required]
        public decimal ImporteBruto { get; set; }

        
        public decimal ImporteTransporte { get; set; }

        public DateTime FechaSalida { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        
        public DateTime Modificacion { get; set; }



        
        public virtual Cliente Cliente { get; set; }

        public virtual Direccion DireccionEnvio { get; set; }

        public virtual Transportista Transportista { get; set; }

        public virtual Empleado Vendedor { get; set; }

        public virtual Empleado Preparador { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}

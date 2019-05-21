using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de gestionar los distintos productos, está relacionado
    /// con los modelos Proveedor e Impuesto.
    /// </summary>
    public class Producto
    {
        [Key]
        public int Producto_ID { get; set; }

        [Required, MaxLength(250)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Referencia { get; set; }

        [MaxLength(100)]
        public string  Lote { get; set; }

        [MaxLength(100)]
        public string Serie { get; set; }

        public DateTime FechaFabricacion { get; set; }

       
        public float Peso { get; set; }
        
        
        public decimal PrecioCompra { get; set; }

        
        public decimal PrecioVenta { get; set; }

       
        public int Margen { get; set; }

        [MaxLength(1000)]
        public string Descripcion { get; set; }


        
        public int Articulo_Descuento { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        
        public int EAN13 { get; set; }


        public virtual Proveedor Proveedor { get; set; }

        public IEnumerable<Impuesto> Impuesto{ get; set; }


    }
}

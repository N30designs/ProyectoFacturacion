using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Producto
    {
        [Key, MaxLength(30)]
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

        [Range(0,99999.99)]
        public float Peso { get; set; }
        
        [Range(0,999999.99)]
        public decimal PrecioCompra { get; set; }

        [Range(0, 999999.99)]
        public decimal PrecioVenta { get; set; }

        [MaxLength(2)]
        public int Margen { get; set; }

        [MaxLength(1000)]
        public string Descripcion { get; set; }


        [MaxLength(2)]
        public int Articulo_Descuento { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        [MaxLength(13)]
        public int EAN13 { get; set; }


        public virtual Proveedor Proveedor { get; set; }

        public IEnumerable<Impuesto> Impuesto{ get; set; }


    }
}

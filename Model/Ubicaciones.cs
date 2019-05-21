using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de las ubicaciones de los distintos productos
    /// contiene una relación de muchos a muchos con productos, puesto
    /// que pueden estar ubicados en mas de un lugar.
    /// </summary>
    class Ubicaciones
    {
        [Key]
        public int UBICACION_ID { get; set; }

        [MaxLength(50)]
        public string Referencia{ get; set; }
        [MaxLength(50)]
        public string Almacen { get; set; }
               
        public int Pasillo { get; set; }
                
        public int Leja { get; set; }

        [Required]
        public string Ubicacion { get; set; }

    }

}

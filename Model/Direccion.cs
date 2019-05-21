using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
   /// <summary>
   /// Crea el enumerado que contiene los tipos de vía. 
   /// </summary>   
   public  enum TipoDireccion
    {
        Calle = 1,
        Avenida = 2,
        Plaza = 3,
        Camino = 4,
        Parque = 5,
        Bulevar= 6,
        Carril = 7,
        Paseo = 8 ,
        Cañada = 9,
        Ronda = 10,
        Puente = 11,
        Travesía = 12,
        Sendero = 13
    };

    /// <summary>
    /// Modelo que crea las direcciones de pedido, las direcciones de empresa o cliente no están asociadas a él.
    /// </summary>
    public class Direccion
    {
        [Key]
        public int Direcccion_ID { get; set; }

        [Required]
        public TipoDireccion Tipo { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int Numero { get; set; }

       
        public int Bloque { get; set; }

        
        public int Portal { get; set; }

       
        public int Escalera { get; set; }

        public int Planta { get; set; }

        
        public int Piso { get; set; }

        [MaxLength(10)]
        public string Puerta { get; set; }

        [Required]
        public string Telefono { get; set; }

        
        public string Telefono2 { get; set; }

        
        public string Fax { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        
        public DateTime Modificacion { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Poblacion Poblacion { get; set; }
        

    }
}

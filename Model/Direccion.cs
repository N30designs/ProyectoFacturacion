using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{

    enum tipoDireccion {Calle, Avenida, Plaza, Camino, Paque, Bulevar, Carril, Paseo, Cañada, Ronda, Puente, Travesía, Sendero};

    class Direccion
    {
        [Key, MaxLength(30)]
        public int Direcccion_ID { get; set; }

        [Required]
        public tipoDireccion Tipo { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(4)]
        public int Numero { get; set; }

        [MaxLength(2)]
        public int Bloque { get; set; }

        [MaxLength(2)]
        public int Portal { get; set; }

        [MaxLength(2)]
        public int Escalera { get; set; }

        [MaxLength(2)]
        public int Planta { get; set; }

        [MaxLength(2)]
        public int Piso { get; set; }

        [MaxLength(10)]
        public string Puerta { get; set; }

        [Required, MaxLength(9)]
        public string Telefono { get; set; }

        [MaxLength(9)]
        public string Telefono2 { get; set; }

        [MaxLength(9)]
        public string Fax { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }

        public virtual Cliente ID_Cliente { get; set; }

        public virtual Poblacion Poblacion { get; set; }
        

    }
}

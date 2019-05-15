
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{

    enum tipoPoblacion {Aldea, Pueblo, Ciudad, Provincia}


    class Poblacion
    {
        [Key, MaxLength(30)]
        public int Poblacion_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public tipoPoblacion Tipo { get; set; }

        [Required, MaxLength(5)]
        public string  Cpostal { get; set; }

        [MaxLength(30)]
        public int Padre { get; set; }
    }
}

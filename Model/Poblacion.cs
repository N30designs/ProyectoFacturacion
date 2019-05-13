using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    enum tipoPoblacion {poblacion, municipio}

    class Poblacion
    {
        [Key, MaxLength(30)]
        public int ID_Poblacion { get; set; }

        [Required, MaxLength(150)]
        public string Nombre { get; set; }

        [Required]
        public tipoPoblacion Tipo { get; set; }

        [Required, MaxLength(5)]
        public int CPostal { get; set; }
        public virtual Poblacion Padre { get; set; }
    }
}

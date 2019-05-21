
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Enum, encargado de le gestión de los distintos tipos de Núcleos Urbanos
    /// </summary>
   public enum tipoPoblacion {
        Aldea = 1,
        Pueblo = 2,
        Ciudad = 3,
        Provincia = 4
    };

    /// <summary>
    /// Modelo encargado de gestionar las distintas poblaciones y provincias.
    /// El atributo Padre define la provincia de una población.
    /// </summary>
    public class Poblacion
    {
        [Key]
        public int Poblacion_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public tipoPoblacion Tipo { get; set; }

        [Required]
        public string  Cpostal { get; set; }
                
        public int Padre { get; set; }
    }
}

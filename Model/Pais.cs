using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de gestionar los distintos paises, se encuentra asociado al modelo Moneda
    /// </summary>
   public class Pais
    {

        [Key]
        public int Pais_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public virtual Moneda Moneda { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Pais
    {

        [Key, MaxLength(30)]
        public int Pais_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public virtual Moneda Moneda { get; set; }

    }
}

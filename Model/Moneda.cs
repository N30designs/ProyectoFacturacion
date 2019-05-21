using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Clase utilizada para definir la moneda (y su conversion) a usar
    /// </summary>
    public class Moneda
    {
        [Key]
        public int Moneda_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public string Diminutivo { get; set; }

        [Required]
        public decimal valor { get; set; }

        public DateTime Fecha_Conversion { get; set; }
               

    }
}

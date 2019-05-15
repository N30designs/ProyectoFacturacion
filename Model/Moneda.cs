using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Moneda
    {
        [Key, MaxLength(30)]
        public int Moneda_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(10)]
        public string Diminutivo { get; set; }

        [Required, Range(0,1.999999)]
        public decimal valor { get; set; }

        public DateTime Fecha_Conversion { get; set; }
               

    }
}

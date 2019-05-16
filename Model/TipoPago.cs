using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    class TipoPago
    {
        [Key, MaxLength(30)]
        public int TipoPagoID { get; set; }

        [Required, MaxLength (50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Numero1 { get; set; }

        [MaxLength(30)]
        public string Numero2 { get; set; }

        [MaxLength(30)]
        public string Numero3 { get; set; }

        public DateTime Caducidad { get; set; }

        public DateTime Emision { get; set; }

    }
}

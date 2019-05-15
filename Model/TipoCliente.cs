using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class TipoCliente
    {
        [Key, MaxLength(30)]
        public int Tipo_Cliente_ID { get; set; }

        [Required, MaxLength(100)]
        public string Denominacion { get; set; }


    }
}

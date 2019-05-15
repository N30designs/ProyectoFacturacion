using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Proveedor
    {

        [Key, MaxLength(30)]
        public int Proveedor_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }


    }
}

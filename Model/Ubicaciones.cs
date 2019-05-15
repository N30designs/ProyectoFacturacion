using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Ubicaciones
    {
        [Key, MaxLength(30)]
        public int UBICACION_ID { get; set; }

        [MaxLength(50)]
        public string Referencia{ get; set; }
        [MaxLength(50)]
        public string Almacen { get; set; }

        [MaxLength(3)]
        public int Pasillo { get; set; }

        [MaxLength(3)]
        public int Leja { get; set; }
        [Required, MaxLength(50)]
        public int Ubicacion { get; set; }

    }

}

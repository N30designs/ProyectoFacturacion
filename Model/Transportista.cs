using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    class Transportista
    {
        [Key, MaxLength(30)]
        public int TransportistaID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, Range(0,999999.99)]
        public decimal PrecioUnidad { get; set; }

        public DateTime HorarioRecogida { get; set; }

        [Required, MaxLength(100)]
        public string Direccion { get; set; }

        [Required, MaxLength(4)]
        public int Numero { get; set; }

        [MaxLength(2)]
        public int Bloque { get; set; }

        [MaxLength(2)]
        public int Escalera { get; set; }

        [MaxLength(2)]
        public int Portal { get; set; }

        [MaxLength(2)]
        public int Planta { get; set; }

        [MaxLength(2)]
        public int Piso { get; set; }

        [MaxLength(10)]
        public int Puerta { get; set; }

        [MaxLength(100)]
        public string Comercial { get; set; }

        [MaxLength(100)]
        public string Repartidor { get; set; }

        [MaxLength(9), Phone]
        public string TelefonoComercial { get; set; }
        [MaxLength(9), Phone]
        public string TelefonoRepartidor { get; set; }

        [Required, MaxLength(9), Phone]
        public string Telefono1 { get; set; }

        [MaxLength(9), Phone]
        public string Telefono2 { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        [Required]
        public virtual Poblacion Poblacion { get; set; }
    }
}

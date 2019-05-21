using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo que gestiona los diferentes transportistas
    /// </summary>
    public class Transportista
    {
        [Key]
        public int TransportistaID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public decimal PrecioUnidad { get; set; }

        public DateTime HorarioRecogida { get; set; }

        [Required, MaxLength(100)]
        public string Direccion { get; set; }

        [Required]
        public int Numero { get; set; }

        public int Bloque { get; set; }

        
        public int Escalera { get; set; }

        
        public int Portal { get; set; }

        public int Planta { get; set; }

        public int Piso { get; set; }

        public int Puerta { get; set; }

        [MaxLength(100)]
        public string Comercial { get; set; }

        [MaxLength(100)]
        public string Repartidor { get; set; }

        [Phone]
        public string TelefonoComercial { get; set; }
        [Phone]
        public string TelefonoRepartidor { get; set; }

        [Required, Phone]
        public string Telefono1 { get; set; }

        [Phone]
        public string Telefono2 { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        [Required]
        public virtual Poblacion Poblacion { get; set; }
    }
}

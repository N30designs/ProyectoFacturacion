using System;
using System.ComponentModel.DataAnnotations;


namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de la gestión de los distintos tipos de pago
    /// </summary>
    public class TipoPago
    {
        [Key]
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

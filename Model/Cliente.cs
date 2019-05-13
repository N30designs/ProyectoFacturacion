using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace facturacion.Model
{
    class Cliente
    {
        [Key, MaxLength(30)]
        public int ClienteID { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Apellidos{ get; set; }

        [Index(IsUnique=true), Required, MaxLength(10)]
        public string CIF { get; set; }

        [Required, MaxLength(9)]
        public string Telefono1 { get; set; }

        [MaxLength(9)]
        public string Telefono2 { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(9)]
        public int Fax { get; set; }

        [MaxLength(100)]
        public string Web { get; set; }

        [MaxLength(100)]
        public string NombreFiscal { get; set; }

        [MaxLength(100)]
        public string Contacto { get; set; }

        [MaxLength(2)]
        public int Descuento { get; set; }

        [MaxLength(3)]
        public int DiasPago { get; set; }

        [MaxLength(24)]
        public string Iban { get; set; }

        [MaxLength(11)]
        public string Bic { get; set; }

        [MaxLength(2)]
        public int RecargoEquivalencia { get; set; }

        [MaxLength(2)]
        public int Irpf { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }


    }
}

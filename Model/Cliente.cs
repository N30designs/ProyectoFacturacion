using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace facturacion.Model
{
    class Cliente
    {
        [Key, MaxLength(30)]
        public int Cliente_ID { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Apellidos{ get; set; }

        [Index(IsUnique=true), Required, MaxLength(10)]
        public string CIF { get; set; }

        [MaxLength(100)]
        public string NombreFiscal { get; set; }

        [Required, MaxLength(100)]
        public string Domicilio { get; set; }

        [Required, MaxLength(4)]
        public int Numero { get; set; }

        [MaxLength(2)]
        public int Bloque { get; set; }

        [MaxLength(2)]
        public int Portal { get; set; }

        [MaxLength(2)]
        public int Escalera { get; set; }

        [MaxLength(2)]
        public int Planta { get; set; }

        [MaxLength(2)]
        public int Piso { get; set; }

        [MaxLength(10)]
        public string Puerta { get; set; }
                          
        [Required, MaxLength(9), Phone]
        public string Telefono1 { get; set; }

        [MaxLength(9), Phone]
        public string Telefono2 { get; set; }

        [MaxLength(200), EmailAddress]
        public string Email { get; set; }

        [MaxLength(9), Phone]
        public int Fax { get; set; }

        [MaxLength(100)]
        public string Web { get; set; }

        

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
        public int Irpf { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }


        public virtual TipoCliente TipoCliente{ get; set; }

        public virtual Poblacion Poblacion_ID { get; set; }

    }
}

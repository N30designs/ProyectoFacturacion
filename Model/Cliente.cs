using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo que crea el objeto cliente con todos sus atributos
    /// </summary>
    public class Cliente
    {
       
        [Key]
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

        
        public int Numero { get; set; }

        
        public int Bloque { get; set; }

        
        public int Portal { get; set; }

        
        public int Escalera { get; set; }

        
        public int Planta { get; set; }

        
        public int Piso { get; set; }

        
        public string Puerta { get; set; }
                          
        [Required, Phone]
        public string Telefono1 { get; set; }

        [Phone]
        public string Telefono2 { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Fax { get; set; }

        [MaxLength(100)]
        public string Web { get; set; }

        

        [MaxLength(100)]
        public string Contacto { get; set; }

        
        public int Descuento { get; set; }

       
        public int DiasPago { get; set; }

        [MaxLength(24)]
        public string Iban { get; set; }

        [MaxLength(11)]
        public string Bic { get; set; }

        
        public int Irpf { get; set; }

        [MaxLength(1000)]
        public string Observaciones { get; set; }

        
        public DateTime Creacion { get; set; }

        
        public DateTime Modificacion { get; set; }


        public virtual TipoCliente TipoCliente{ get; set; }

        public virtual Poblacion Poblacion { get; set; }

    }
}

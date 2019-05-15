using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace facturacion.Model
{
    class Empresa
    {
        [Key, MaxLength(30)]
        public int ID_EMPRESA { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Ncomercial { get; set; }

        [Index(IsUnique = true), Required, MaxLength(10)]
        public string cif { get; set; }

        [MaxLength(4)]
        public int Inscripcion { get; set; }

        [MaxLength(4)]
        public int Tomo { get; set; }

        [MaxLength(4)]
        public int Folio { get; set; }

        [MaxLength(50)]
        public string Registro { get; set; }


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

        [Required, MaxLength(2)]
        public int Planta{ get; set; }
        
        [MaxLength(10)]
        public string Puerta { get; set; }
                          
        [MaxLength(9), Phone]
        public int Fax { get; set; }

        [Required, MaxLength(100)]
        public string Administrador { get; set; }

        [Required, MaxLength(9), Phone]
        public string Telefono { get; set; }

        [MaxLength(9), Phone]
        public string Telefono2 { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        [Required]
        public bool RegimenEquivalencia { get; set; }

        [MaxLength(100)]
        public string Web { get; set; }

        [MaxLength(100), EmailAddress]
        public string Email { get; set; }

        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }


        public virtual Poblacion Poblacion{ get; set; }

    }
}

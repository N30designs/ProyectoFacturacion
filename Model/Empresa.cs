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

        [Required, MaxLength(2)]
        public int Inscripcion { get; set; }

        [Required, MaxLength(2)]
        public int Tomo { get; set; }

        [Required, MaxLength(2)]
        public int Folio { get; set; }

        [Required, MaxLength(50)]
        public string Registro { get; set; }

        [MaxLength(9)]
        public int Fax { get; set; }

        [Required, MaxLength(100)]
        public string Administrador { get; set; }

        [Required, MaxLength(9)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Telefono2 { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        [Required]
        public bool RegimenEquivalencia { get; set; }

        [MaxLength(100)]
        public string Web { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }


        public virtual Direccion ID_Direccion { get; set; }


    }
}

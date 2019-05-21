using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo que contiene la información de las distintas empresas disponibles.
    /// Los encabezados de documentos harán referencia a ellas.
    /// </summary>
    public class Empresa
    {
        [Key]
        public int ID_EMPRESA { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Ncomercial { get; set; }

        [Index(IsUnique = true), Required, MaxLength(10)]
        public string cif { get; set; }

        
        public int Inscripcion { get; set; }

       
        public int Tomo { get; set; }

        
        public int Folio { get; set; }

        [MaxLength(50)]
        public string Registro { get; set; }


        [Required, MaxLength(100)]
        public string Domicilio { get; set; }

        [Required]
        public int Numero { get; set; }

       
        public int Bloque { get; set; }

       
        public int Portal { get; set; }

        
        public int Escalera { get; set; }

        [Required]
        public int Planta{ get; set; }
        
        [MaxLength(10)]
        public string Puerta { get; set; }
                          
        [Phone]
        public int Fax { get; set; }

        [Required, MaxLength(100)]
        public string Administrador { get; set; }

        [Required, Phone]
        public string Telefono { get; set; }

        [Phone]
        public string Telefono2 { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        
        public bool RegimenEquivalencia { get; set; }

        [MaxLength(100)]
        public string Web { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime Creacion { get; set; }

        
        public DateTime Modificacion { get; set; }


        public virtual Poblacion Poblacion{ get; set; }

    }
}

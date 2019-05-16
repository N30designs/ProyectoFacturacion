using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    enum TipoEmpleado {Vendedor, Reponedor, Soporte}


    class Empleado
    {

        [Key, MaxLength(30)]
        public int EmpeleadoID { get; set; }

        public TipoEmpleado TipoEmpleado { get; set; }
        
        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string Apellido1 { get; set; }

        [Required, MaxLength(50)]
        public string Apellido2 { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required, MaxLength(9)]
        public string Nif { get; set; }

        [MaxLength(200), EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(9), Phone]
        public string Telefono1 { get; set; }

        [MaxLength(9), Phone]
        public string Telefono2 { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }
        [MaxLength(4)]
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
        public string Puerta { get; set; }

       [MaxLength(9), Phone]
        public string Fax { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        [Timestamp]
        public DateTime Modificacion { get; set; }

        
        public DateTime FechaAlta { get; set; }

        public DateTime FechaBaja { get; set; }

        public int BIC { get; set; }

        public decimal Salario { get; set; }

        public string Observaciones { get; set; }

        public virtual Poblacion Poblacion { get; set; }



    }
}

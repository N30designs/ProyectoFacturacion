using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    /// <summary>
    /// Enumerado que contiene los distintos puestos que puede desarrollar el empleado. 
    /// </summary>
    public enum TipoEmpleado {
        Vendedor = 1,
        Reponedor =2,
        Soporte =3
    };

    /// <summary>
    /// Modelo que crea los objetos que representan a los empleados. Serán utilizados 
    /// cada vez que sea necesario hacer referencia a algún empleado. 
    /// </summary>
    public class Empleado
    {

        [Key]
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

        [EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Telefono1 { get; set; }

        [Phone]
        public string Telefono2 { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        
        public int Numero { get; set; }

        
        public int Bloque { get; set; }

        
        public int Escalera { get; set; }

       
        public int Portal { get; set; }

       
        public int Planta { get; set; }

       
        public int Piso { get; set; }

        
        public string Puerta { get; set; }

       [Phone]
        public string Fax { get; set; }

        [Required]
        public DateTime Creacion { get; set; }

        
        public DateTime Modificacion { get; set; }

        
        public DateTime FechaAlta { get; set; }

        public DateTime FechaBaja { get; set; }

        public int BIC { get; set; }

        public decimal Salario { get; set; }

        public string Observaciones { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }


        public virtual Poblacion Poblacion { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    enum TipoEmpleado {Vendedor, Reponedor, Soporte}


    class Empleado
    {
        public int EmpeleadoID { get; set; }

        public TipoEmpleado TipoEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Nif { get; set; }

        public string Email { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Direccion { get; set; }

        public int Numero { get; set; }

        public int Bloque { get; set; }

        public int Escalera { get; set; }

        public int Portal { get; set; }

        public int Planta { get; set; }

        public int Piso { get; set; }

        public string Puerta { get; set; }

       
        public string Fax { get; set; }

        public DateTime Creacion { get; set; }

        public DateTime Modificacion { get; set; }


        public DateTime FechaAlta { get; set; }

        public DateTime FechaBaja { get; set; }

        public int BIC { get; set; }

        public decimal Salario { get; set; }

        public string Observaciones { get; set; }

        public virtual Poblacion Poblacion { get; set; }



    }
}

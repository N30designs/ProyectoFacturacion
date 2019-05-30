using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using facturacion.Data;
using facturacion.Model;

namespace facturacion.Business
{
    public class Empleados : lEmpleados
    {
        /// <summary>
        /// Realiza una busqueda en la tabla empleados a traves de un sólo string.
        /// </summary>
        /// <param name="cadena">Valor a buscar en la tabla empleados.</param>
        /// <returns>Colección de empleados que coinciden en alguno de sus parametros con la cadena, proporcionada.</returns>
        public ICollection<Empleado> BuscarEmpleado(string cadena)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Devuelve un sólo empleado a partir del id del mismo.
        /// </summary>
        /// <param name="id">Valor int que corresponde al atributo EmpeladoID del empleado.</param>
        /// <returns>Objeto de tipo Empleado que representa al poseedor del ID insertado.</returns>
        public Empleado GetEmpleado(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Devuelve un sólo empleado a partir del id del mismo.
        /// </summary>
        /// <param name="usuario">Usuario que corresponde al empleado que deseamos obetener.</param>
        /// <returns>Objeto de tipo Empleado que representa al poseedor del USUARIO insertado.</returns>
        public Empleado GetEmpleado(string usuario)
        {
            using (FacturacionContext context = new FacturacionContext())
            {
                Empleado empleado = context.Empleados.Where(e => e.Usuario == usuario).First();
                return empleado;
            }
        }


        /// <summary>
        /// Confirma la existencia de un usuario y contraseña de un empleado. 
        /// </summary>
        /// <param name="usuario">Cadena que representa el campo Usuario del empleado.</param>
        /// <param name="password">Cadena que representa el campo Password del empleado</param>
        /// <returns>Devolverá True si encuentra el valor en la base de datos, False en caso de no encontrarlo.</returns>
        public bool LoginCorrecto(string usuario, string password)
        {
            using(FacturacionContext context = new FacturacionContext())
            {
                var empleados = context.Empleados.Where(e => e.Usuario == usuario && e.Password == password);

                if (empleados.Count() >= 1)
                    return true;
                else
                    return false;
            }
        }
    }
}

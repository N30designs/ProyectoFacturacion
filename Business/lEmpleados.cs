using facturacion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Business
{
    /// <summary>
    /// Interfaz relativa a todos los métodos que utilizarán el modelo Empleados
    /// </summary>
    interface lEmpleados
    {
        /// <summary>
        /// Devuelve un sólo empleado a partir del id del mismo.
        /// </summary>
        /// <param name="id">Valor int que corresponde al atributo EmpeladoID del empleado.</param>
        /// <returns>Objeto de tipo Empleado que representa al poseedor del ID insertado.</returns>
        Empleado GetEmpleado(int id);


        /// <summary>
        /// Devuelve un sólo empleado a partir del id del mismo.
        /// </summary>
        /// <param name="usuario">Usuario que corresponde al empleado que deseamos obetener.</param>
        /// <returns>Objeto de tipo Empleado que representa al poseedor del USUARIO insertado.</returns>
        Empleado GetEmpleado(string usuario);


        /// <summary>
        /// Realiza una busqueda en la tabla empleados a traves de un sólo string.
        /// </summary>
        /// <param name="cadena">Valor a buscar en la tabla empleados.</param>
        /// <returns>Colección de empleados que coinciden en alguno de sus parametros con la cadena, proporcionada.</returns>
        ICollection<Empleado> BuscarEmpleado(string cadena);
                

        /// <summary>
        /// Confirma la existencia de un usuario y contraseña de un empleado. 
        /// </summary>
        /// <param name="usuario">Cadena que representa el campo Usuario del empleado.</param>
        /// <param name="password">Cadena que representa el campo Password del empleado</param>
        /// <returns>Devolverá True si encuentra el valor en la base de datos, False en caso de no encontrarlo.</returns>
        bool LoginCorrecto(string usuario, string password);

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Classes
{
    /// <summary>
    /// Clase encargada de guardar y mostrar los eventos de la aplicación.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Método que recibirá dos cadenas de texto que definiran el componente y el mensaje, y se encargará de 
        /// mostrarlo en consola y archivarlo tanto en un fichero como en el log del sistema.
        /// </summary>
        /// <param name="componente">Lugar donde ha ocurrido el evento.</param>
        /// <param name="gravedad">Indica la gravedad de la situación en un rango de 0 a 9</param>
        /// <param name="mensaje">Mensaje que se archivará en el log.</param>
        public void Log(string componente, int gravedad , string mensaje)
        {
            Console.WriteLine($"Componente: {componente}, Gravedad: {gravedad}, Hora del evento: {DateTime.Now} \n Mensaje: {mensaje}");
        }

    }
}

using System;
using System.Diagnostics;
using System.IO;


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
            string msg = $"Componente: {componente}, Gravedad: {gravedad}, Hora del evento: {DateTime.Now} \n Mensaje: {mensaje}";
            string msgtxt = $"{DateTime.Now};{gravedad};{mensaje}";
            string log = "log";
            var rutalog = @"log.txt";


            /*Es posible personalizar la fuente de los logs creando una propia con con un código similar al siguiente, pero requiere
             * permisos de administrador en la ejecución que derivan en diversos problemas. Todo ello es evitable si durante la instalación
             * de la aplicación registramos estas fuentes.
             * ----------------------------------------------------------
             * try
             *  {
             *      if (!EventLog.SourceExists(VariablesGlobales.nombrePrograma))
             *      {
             *          EventLog.CreateEventSource(VariablesGlobales.nombrePrograma, log);
             *          EventLog.WriteEntry(VariablesGlobales.nombrePrograma, String.Format($"Creado nuevo Origen de eventos, {VariablesGlobales.nombrePrograma}, {log}"), EventLogEntryType.Information);
             *      }
             *  }
             *  catch (System.Security.SecurityException ex)
             *  {
             *      throw new Exception("Se requiere una elevación de privilegios para poder crear un nuevo tipo de evento en el sistema.");
             *  }
             * ----------------------------------------------------------------
             */

            //Mostramos por consola
            Console.WriteLine(msg);

            //Creamos un fichero de log
            if (File.Exists(rutalog))
            {
                using (StreamWriter sw = new StreamWriter(rutalog, true))
                {
                    sw.WriteLine(msgtxt);
                }

                Console.WriteLine("He añadido filas");
            }
            else
            {
                File.WriteAllText(rutalog, msgtxt);
                Console.WriteLine("He añadido fichero");
            }

            //Crea entrada en el registro del sistema (Leer mas arriba para mas detalles) 
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";

                if (gravedad <= 5)
                    eventLog.WriteEntry(msg, EventLogEntryType.Information);
                else if (gravedad > 5 && gravedad <= 7)
                    eventLog.WriteEntry(msg, EventLogEntryType.Warning);
                else if (gravedad >= 8)
                    eventLog.WriteEntry(msg, EventLogEntryType.Error);

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Data
{
    /// <summary>
    /// Clase encargada de formatear el log de salida del sistema.
    /// </summary>
    public class OneLineLog : DatabaseLogFormatter
    {
        /// <summary>
        /// Constructor de la clase, recibe un dbcontext 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="writeAction"></param>
        public OneLineLog(DbContext context, Action<string> writeAction)
        : base(context, writeAction)
        {            
        }

        /// <summary>
        /// Modifica el formato en el que se genera el log del comando antes de ser ejecutado.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command"></param>
        /// <param name="interceptionContext"></param>
        public override void LogCommand<TResult>(
            DbCommand command, DbCommandInterceptionContext<TResult> interceptionContext)
        {
            Write(string.Format(
                "Ha ejecutado el comando: '{0}'{1}",
                Context.GetType().Name,
                command.CommandText.Replace(Environment.NewLine, ""),
                Environment.NewLine));
        }


        /// <summary>
        /// Modifica la salida del comando tras su ejecución. 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command"></param>
        /// <param name="interceptionContext"></param>
        public override void LogResult<TResult>(
            DbCommand command, DbCommandInterceptionContext<TResult> interceptionContext)
        {
        }

    }
}

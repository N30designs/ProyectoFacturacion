using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Classes
{
    /// <summary>
    /// Clase encargada del log del sistema haciendo uso del framework NLOG
    /// </summary>
    public class Log
    {
        
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Log()
        {       
        }

        /// <summary>
        /// Configura el log del sistema y devuelve un objeto de tipo Logger.
        /// </summary>
        /// <returns>Devuelve un objeto logger ya configurado, listo para usar.</returns>
        public static Logger NuevoLog()
        {
            LoggingConfiguration config = new LoggingConfiguration();

            //Crea el destino consola
            var consoletarget = new ColoredConsoleTarget("Consola")
            {
                Layout = @"${date:format=HH\:mm\:ss} ${level} ${message} ${exception}"
            };

            //Crea el destino log
            var archivoLog = new FileTarget("ArchivoLog")
            {
                FileName = "logs/${shortdate}-LogFile.csv",
                ArchiveNumbering = NLog.Targets.ArchiveNumberingMode.DateAndSequence,
                ArchiveEvery = NLog.Targets.FileArchivePeriod.Day,
                Layout = @"${shortdate};${date:format=HH\:mm\:ss};${pad:padding=5:inner=${level:uppercase=true}};${exception}${message}"
            };

            //Crea el destino event log
            var eventos = new EventLogTarget
            {
                Name = "eventLog",
                Layout = @"${date:format=HH\:mm\:ss};${pad:padding=5:inner=${level:uppercase=true}};${exception}${message}",
                MachineName = ".",
                Source = "MyAPP",
                Log = "Application"
            };

            //Crea el destino en SQL SERVER
            var sql = new DatabaseTarget
            {
                Name = "sql",
                DBProvider = "System.Data.SqlClient",
                //ConnectionStringName = "CSFacturacion", //Otra opción de conexión. No puede convivir con el resto. 
                //ConnectionString = "server=localhost\\SQLEXPRESS;Database=Logs;user id=sa;password=1234", //Si habilito este paramétro no es necesario DBHost, DBUserName, DBPassword, DBDatabase and DBProvider
                DBHost = "localhost\\SQLEXPRESS",
                DBDatabase = "Logs",
                DBUserName = "SA",
                DBPassword = "1234",//EVIDENTEMENTE EN UN ENTORNO REAL NO USARIA UNA CONTRASEÑA ASÍ
                KeepConnection = false,
                CommandType = System.Data.CommandType.Text,
                CommandText = "INSERT INTO LOGS (ID, HOST, FECHA, TIPO, MENSAJE, LOGGER, EXCEPCION) " +
                                "VALUES (NEXT VALUE FOR LOGS_ID, @HOST, @FECHA, @TIPO, @MENSAJE, @LOGGER, @EXCEPCION)",
                Parameters =
                {
                   new DatabaseParameterInfo("@HOST", "${machinename}"),
                   new DatabaseParameterInfo("@FECHA", "${date}"),
                   new DatabaseParameterInfo("@TIPO", "${level}"),
                   new DatabaseParameterInfo("@MENSAJE", "${message}"),
                   new DatabaseParameterInfo("@LOGGER", "${logger}"),
                   new DatabaseParameterInfo("@EXCEPCION", "${exception:tostring}")
                }
            };

            config.AddTarget(consoletarget);
            config.AddTarget(archivoLog);
            config.AddTarget(eventos);
            //config.AddTarget(sql);

            config.AddRuleForAllLevels(consoletarget);
            config.AddRuleForAllLevels(archivoLog);
            config.AddRuleForAllLevels(eventos); // Quizás habría que limitar la escritura a niveles > INFO. 
            //config.AddRuleForAllLevels(sql);


            LogManager.Configuration = config;
            Logger logger = LogManager.GetLogger("Log");
            return logger;
        }

    }
}

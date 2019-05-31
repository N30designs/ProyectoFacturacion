using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using facturacion.Classes;



namespace facturacion.Classes
{
    /// <summary>
    /// Crea la conexión con la base de datos, pudiendo decidir si deseamos una base de datos local o remota.
    /// </summary>
    public class ConexionDB 
    {
        
        /// <summary>
        /// Este método genera una conexión a la base de datos, el tipo de conexión dependerá de los
        /// valores que encuentre en el registro de Windows. En caso de no encontrar nada, generará
        /// una base de datos local. 
        /// </summary>
        /// <returns>ConnectionString para EF con la base de datos a crear (o utilizar) </returns>
        public static string Conexion()
        {
            var log = Log.NuevoLog();

            string resultado;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ProyectoFactuacion\Preferencias");
            
            if ((key == null) || (key.GetValue("DBServer") == null) || (key.GetValue("DBDatabase") == null))
            {
                log.Fatal("Uno o mas valores de la base de datos se encuentra incompleto, y no se ha establecido una conexión local.");

                System.Windows.Forms.MessageBox.Show("No se ha especificado ningún valor de conexión a la base de datos," +
                                                     "ni se ha indcado que se trate de una base de datos local.\n" +
                                                     "Por favor revise su configuración y vuelva a intentarlo.",
                                                     "Error de configuración", 
                                                     System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                resultado = null;

            }
            else if (key.GetValue("DBLocal").Equals(1))
            {

                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                sb.DataSource = "(LocalDb)\\MSSQLLocalDB";
                sb.InitialCatalog = VariablesGlobales.nombrePrograma.Trim();
                sb.MultipleActiveResultSets = true;
                sb.IntegratedSecurity = true;
                sb.ApplicationName = VariablesGlobales.nombrePrograma.Trim();   

                resultado = sb.ConnectionString;
                //resultado = "Data Source = (LocalDB)\\MSSQLLocalDB; Integrated Security = True; Connect Timeout = 30";

            }
            else
            {
                resultado = null;
            }

            return resultado;
            //SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            //sb.DataSource = "(LocalDb)\\MSSQLLocalDB";
            //sb.InitialCatalog = VariablesGlobales.nombrePrograma.Trim();
            //sb.MultipleActiveResultSets = true;
            //sb.IntegratedSecurity = true;
            //sb.ApplicationName = VariablesGlobales.nombrePrograma;

            //EntityConnectionStringBuilder eb = new EntityConnectionStringBuilder();
            //eb.Provider = "System.Data.SqlClient";
            ////eb.Metadata = $"res://*/{VariablesGlobales.nombrePrograma.Trim()}.csdl|" +
            ////                $"res://*/{VariablesGlobales.nombrePrograma.Trim()}.ssdl|" +
            ////                $"res://*/{VariablesGlobales.nombrePrograma.Trim()}.msl";
            //eb.ProviderConnectionString = sb.ToString();


            //return eb.ConnectionString;

            //return "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=aspnet-MvcMovie;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\Movies.mdf";
        }
    }
}

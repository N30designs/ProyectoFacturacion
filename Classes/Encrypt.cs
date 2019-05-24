using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Classes
{
    /// <summary>
    /// Clase encargada encriptar y desencriptar información sensible.
    /// </summary>
    public class Encrypt
    {
        /// <summary>
        /// Encripta un valor a base64. Atención no es un protocolo seguro, tan sólo utilizar
        /// para ofuscar información a un usuario.
        /// </summary>
        /// <param name="Cadena">Cadena de texto que deseamos encriptar.</param>
        /// <returns>Cadena de texto transformada en formato Base64</returns>
        public static string EncriptaBase64(string Cadena)
        {
            Cadena = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Cadena));
            return Cadena;
        }

        /// <summary>
        /// Desecripta un valor desde base64
        /// </summary>
        /// <param name="Cadena">Cadena de texto en formato base64 que deseamos desencriptar.</param>
        /// <returns>Cadena de texto en formato UTF8.</returns>
        public static string DesencriptaBase64(string Cadena)
        {
            Cadena = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Cadena));
            return Cadena;
        }
    }
}

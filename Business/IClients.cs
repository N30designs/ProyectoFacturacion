using facturacion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Business
{   

    public interface IClients
    {
        /// <summary>
        /// Añadimos un cliente dado su nombre y NIF
        /// </summary>
        /// <param name="name">Nombre del cliente</param>
        /// <param name="fiscalId">NIF del cliente</param>
        /// <returns></returns>
        Cliente AddClient(String name, String fiscalId);
        /// <summary>
        /// Buscamos un cliente dado un texto, buscará en los campos de nombre y NIF y si uno coincide devolvera el primer cliente que coincida
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Cliente FindClient(String text);

        
    }
}

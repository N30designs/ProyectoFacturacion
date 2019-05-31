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
        /*
         *Ejemplo que creó Rubén.
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
        Cliente FindClient(String text);*/

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Crea un nuevo cliente, a partir de un objeto cliente que contendrá la información que necesitemos del mismo.
        /// Será obligatorio indicar al menos Nombre, Apellidos, CIF, Direccion y Telefono1.
        /// </summary>      
        
        void NuevoCliente(Cliente cliente);

        /// <summary>
        /// Nos devuelve una coleción de objetos con todos los clientes disponibles.
        /// </summary>
        /// <returns>Devuelve un objeto ICollection con todos los clientes disponibles.</returns>
        ICollection<Cliente> ListarClientes();

        /// <summary>
        /// Nos permite buscar un cliente concreto dado un string. Por convención utilizaremos los campos Nombre, Apellido1
        /// Apellido2, NombreFiscal y CIF para realizar la búsqueda. 
        /// </summary>
        /// <param name="busqueda">Cadena que indicará que corresponderá con el valor a buscar.</param>
        void Buscarclientes(string busqueda);

        TipoCliente TipoClienteID(int id);

        ICollection<TipoCliente> Tipos();



    }
}

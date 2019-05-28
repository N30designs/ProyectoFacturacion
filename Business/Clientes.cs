using facturacion.Model;
using facturacion.Data;
using System;
using System.Linq;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using facturacion.Classes;

namespace facturacion.Business
{
    public class Clientes : IClients
    {

        public Clientes()
        {

        }
                
        public void Buscarclientes(string busqueda)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Devuelve una colección de clientes con todos los clientes que existen en la base de datos.
        /// </summary>
        /// <returns>ICollection con todos los objetos Cliente de la base de datos.</returns>
        public ICollection<Cliente> ListarClientes()
        {
            using (FacturacionContext context = new FacturacionContext())
            {
                var logger = new Logger();
                context.Database.Log = l => logger.Log("Listar Clientes", 0, l.ToString());
                var clientes = context.Clientes.ToList();
                return clientes;
            }
        }

        /*public static ICollection getTipos()
        {
            FacturacionContext contextClientes = new FacturacionContext();
            ICollection tipos;
            if(contextClientes.Tipoclientes != null)
            {
                tipos = contextClientes.Tipoclientes.ToList();
                contextClientes.Dispose();
                return tipos;
            }
            else
            {
                contextClientes.Dispose();
                return null;
            }
            
        }*/
        /*
        public static TipoCliente GetTipoCliente(int id)
        {
            FacturacionContext contextTiposClientes = new FacturacionContext();
            TipoCliente tipo = contextTiposClientes.Tipoclientes.Where(tc => tc.Tipo_Cliente_ID == id).FirstOrDefault();
            return tipo;

        }*/

        public void NuevoCliente(Cliente cliente)
        {
            using (FacturacionContext context = new FacturacionContext())
            {
                var logger = new Logger();
                context.Database.Log = l => logger.Log("Nuevo Cliente", 0, l.ToString());
                try
                {
                    cliente.Creacion = DateTime.Now;
                    cliente.Modificacion = DateTime.Now;
                    
                    context.Clientes.Add(cliente);
                    
                    context.SaveChangesAsync().Wait();                    
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                    
                }
            }
        }

        public ICollection<TipoCliente> Tipos()
        {
            using (FacturacionContext context = new FacturacionContext())
            {
                var resultado = context.Tipoclientes.ToList();
                return resultado;
            }
        }
    }
}

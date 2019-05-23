using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using facturacion.Model;
using facturacion.Data;
using System.Data.Entity.Validation;
using System.Collections;

namespace facturacion.Business
{
    class Poblaciones : IPoblaciones
    {
        /// <summary>
        /// Añade una nueva población. 
        /// </summary>
        /// <param name="Name">Nombre de la población</param>
        /// <param name="Type">Tipo de población basada en el Enum tipoPoblacion</param>
        /// <param name="ZipCode">Valor de código postal de la población</param>
        /// <param name="parent">Padre de la pobliación (no obligatorio)</param>
        public void AddPoblacion(string Name, tipoPoblacion Type, string ZipCode, int? parent)
        {
            using (FacturacionContext context = new FacturacionContext())
            {
                try
                {
                    var p = context.Poblaciones.Create();
                    p.Nombre = Name;
                    p.Tipo = Type;
                    p.Cpostal = ZipCode;

                    if (parent.HasValue)
                        p.Padre = parent;

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

        /// <summary>
        /// Devuelve todas las poblaciones.
        /// </summary>
        /// <returns>Duevuelve una colección de Poblacion.</returns>
        public ICollection<Poblacion> All()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Devolverá una o mas poblaciones según los parámetros de búsqueda. Por convención
        /// utilizaremos los campos Nombre y Cpostal para la búsqueda. 
        /// </summary>
        /// <param name="search">Cadena que filtrará los volores de búsqueda.</param>
        /// <returns></returns>
        public ICollection<Poblacion> Find(string search)
        {
            using (FacturacionContext context = new FacturacionContext())
            {
                ICollection<Poblacion> resultado = context.Poblaciones.
                                                Where(p => (p.Nombre == search) ||
                                                            (p.Cpostal == search)).
                                                            ToList();
                return resultado;
            }
        }
        
    }
}

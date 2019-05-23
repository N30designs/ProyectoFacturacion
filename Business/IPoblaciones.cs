using facturacion.Model;
using System.Collections.Generic;

namespace facturacion.Business
{
    interface IPoblaciones
    {
        /// <summary>
        /// Añade una nueva población. 
        /// </summary>
        /// <param name="Name">Nombre de la población</param>
        /// <param name="Type">Tipo de población basada en el Enum tipoPoblacion</param>
        /// <param name="ZipCode">Valor de código postal de la población</param>
        /// <param name="parent">Padre de la pobliación (no obligatorio)</param>
        void AddPoblacion(string Name, tipoPoblacion Type, string ZipCode, int? parent);

        /// <summary>
        /// Devolverá una o mas poblaciones según los parámetros de búsqueda. Por convención
        /// utilizaremos los campos Nombre y Cpostal para la búsqueda. 
        /// </summary>
        /// <param name="search">Cadena que filtrará los volores de búsqueda.</param>
        /// <returns></returns>
        ICollection<Poblacion> Find(string search);

        /// <summary>
        /// Devuelve todas las poblaciones.
        /// </summary>
        /// <returns>Duevuelve una colección de Poblacion.</returns>
        ICollection<Poblacion> All();


    }
}

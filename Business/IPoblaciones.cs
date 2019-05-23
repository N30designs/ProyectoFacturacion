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
        ICollection<Poblacion> Buscar(string search);

        /// <summary>
        /// Devolverá una única población, la búsqueda se realizará mediante el id de la misma.
        /// </summary>
        /// <param name="id">Valor int que corresponde a una única población.</param>
        /// <returns></returns>
        Poblacion BuscarID(int id);


        /// <summary>
        /// Devuelve todas las poblaciones.
        /// </summary>
        /// <returns>Duevuelve una colección de Poblacion.</returns>
        ICollection<Poblacion> All();


        /// <summary>
        /// Devolverá una colección de Provincias.
        /// </summary>
        /// <returns>ICollection que contiene todas los objetos Población que su tipo sea Provincia.</returns>
        ICollection<Poblacion> Provincias();

        /// <summary>
        /// Devuelve una única población, correspondiente a la provincia de la población.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Número(int) que corresponde a la provincia (padre), de la población introducida.
        ///         Si la población no cuenta con un padre se devolverá un valor -1</returns>
        int ProvinciaOfPoblacion(int id);

        // <summary>
        /// Devuelve el tipo de una población.
        /// </summary>
        /// <param name="id">Id correspondiente a la población de la que deseamos obtener el valor.</param>
        /// <returns></returns>
        tipoPoblacion TipoPoblacion(int id);


    }
}

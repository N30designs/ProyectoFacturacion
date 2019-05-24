using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using facturacion.Model;


namespace facturacion.Data
{
    /// <summary>
    /// Clase utilizada para insertar los datos iniciales en la base de datos.
    /// </summary>
    class FacturacionInitializer : CreateDatabaseIfNotExists<FacturacionContext>
    {
        /// <summary>
        /// Método que se encargará de añadir los datos iniciales a nuestra base de datos, sólo
        /// serán insertados los valores en la creación de la base de datos en caso de que no exista. 
        /// </summary>
        /// <param name="context">DBContext En nuestro caso sólo contamos con FacturaciónContext.</param>
        protected override void Seed(FacturacionContext context)
        {
            //Añade las provincias
            var poblaciones = new List<Poblacion>
            {
                new Poblacion{Nombre="A Coruña", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Álava", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Albacete", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Alicante", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Almería", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Asturias", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Badajoz", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Baleares", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Barcelona", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Burgos", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Cáceres", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Cádiz", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Cantabria", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Castellón", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Ciudad Real", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Córdoba", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Cuenca", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Girona", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Granada", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Guadalajara", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Gipuzkoa", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Jaén", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="La Rioja", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Las Palmas", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="León", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Lérida", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Lugo", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Madrid", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Málaga", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Murcia", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Navarra", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Ourense", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Palencia", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Pontevedra", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Salamanca", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Segovia", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Sevilla", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Soria", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Tarragona", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Santa Cruz de Tenerife", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Teruel", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Toledo", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Valencia", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Valladolid", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Vizcaya", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Zamora", Tipo=tipoPoblacion.Provincia},
                new Poblacion{Nombre="Zaragoza", Tipo=tipoPoblacion.Provincia}
            };

            poblaciones.ForEach(p => context.Poblaciones.Add(p));
            context.SaveChanges();

            var tiposCliente = new List<TipoCliente>
            {
                new TipoCliente{Denominacion="Particular"},
                new TipoCliente{Denominacion="Pequeña Empresa"},
                new TipoCliente{Denominacion="Mediana Empresa"},
                new TipoCliente{Denominacion="Gran Empresa"},
                new TipoCliente{Denominacion="Autónomo"}
            };

            tiposCliente.ForEach(tc => context.Tipoclientes.Add(tc));
            context.SaveChanges();
            
            

            base.Seed(context);
        }

    }
}

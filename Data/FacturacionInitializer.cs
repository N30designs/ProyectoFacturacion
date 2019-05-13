using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using facturacion.Model;


namespace facturacion.Data
{
    class FacturacionInitializer : DropCreateDatabaseIfModelChanges<FacturacionContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(FacturacionContext context)
        {
            
            var clientes = new List<Cliente>
            {
                new Cliente{ClienteID =1, Nombre="Adrián", Apellidos="Arabit Ferre"},
                new Cliente{ClienteID =2, Nombre="Juan", Apellidos="Hernandez Juarez"},
                new Cliente{ClienteID =3, Nombre="Paco", Apellidos="Plasencia Garrido"},
                new Cliente{ClienteID =4, Nombre="Gerardo", Apellidos="Ramón Elias"},
                new Cliente{ClienteID =5, Nombre="Susana", Apellidos="Román Marcos"},
                new Cliente{ClienteID =6, Nombre="María Antonia", Apellidos="Marquez Rodríguez"},
                new Cliente{ClienteID =7, Nombre="Mérida", Apellidos="Del Pozo León"},
                new Cliente{ClienteID =8, Nombre="Rodrígo", Apellidos="Martinez Sancho"}

            };

            clientes.ForEach(c => context.Cliente.Add(c));
            context.SaveChanges();

            var direcciones = new List<Direccion>{
                new Direccion{DireccionId= 1, Nombre="Calle Río Segura, 90", ID_Cliente=clientes.First(c => c.ClienteID == 1)},
                new Direccion{DireccionId= 2, Nombre="Calle Zaragoza, 39  3ºE", ID_Cliente=clientes.Where(c => c.ClienteID == 2).Single()},
                new Direccion{DireccionId= 3, Nombre="Paseo Juan de Borbón, 94 4ºC", ID_Cliente=clientes.Where(c => c.ClienteID == 3).Single()},
                new Direccion{DireccionId= 4, Nombre="Avda. Carlos I, 1 Bajo", ID_Cliente=clientes.Where(c => c.ClienteID == 4).Single()},
                new Direccion{DireccionId= 5, Nombre="Calle Menendez Pelayo, 11", ID_Cliente=clientes.Where(c => c.ClienteID == 5).Single()},
                new Direccion{DireccionId= 6, Nombre="Avda. de la libertad, 152", ID_Cliente=clientes.Where(c => c.ClienteID == 6).Single()},
                new Direccion{DireccionId= 7, Nombre="Plaza Mayor, 35, ESC 2 9ºB", ID_Cliente=clientes.Where(c => c.ClienteID == 7).Single()}
            };

            direcciones.ForEach(d => context.Direccion.Add(d));

            base.Seed(context);
        }

    }
}

using facturacion.Model;
using facturacion.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace facturacion.Business
{
    class Clientes
    {        
        
        public static void nuevoCliente(Cliente cliente)
        {
            FacturacionContext context = new FacturacionContext();

            cliente.Creacion = DateTime.Now;

            context.Clientes.Add(cliente); 
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

        public static TipoCliente getTipoCliente(int id)
        {
            FacturacionContext contextTiposClientes = new FacturacionContext();
            TipoCliente tipo = contextTiposClientes.Tipoclientes.Where(tc => tc.Tipo_Cliente_ID == id).FirstOrDefault();
            return tipo;

        }
        

    }
}

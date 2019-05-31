using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using facturacion.Model;

namespace facturacion.Business
{
    public class ClientesBDRemota : IClients
    {
        public void Buscarclientes(string busqueda)
        {
            throw new NotImplementedException();
        }

        public ICollection<Cliente> ListarClientes()
        {
            throw new NotImplementedException();
        }

        public void NuevoCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public TipoCliente TipoClienteID(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TipoCliente> Tipos()
        {
            throw new NotImplementedException();
        }
    }
}

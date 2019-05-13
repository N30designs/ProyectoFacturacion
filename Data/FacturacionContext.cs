using facturacion.Model;
using System.Data.Entity;
using System.Linq;

namespace facturacion.Data
{
    class FacturacionContext : DbContext
    {
        public FacturacionContext() : base("Prueba2")
        {
            //Database.SetInitializer(new FacturacionContext());
            
        }

       

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }

    }
}

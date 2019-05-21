using facturacion.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace facturacion.Data
{
    class FacturacionContext : DbContext
    {
        
        public virtual DbSet<Albaran> Albaranes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas{ get; set; }
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }
        public virtual DbSet<Direccion> Direcciones { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<EstadoPedido> EstadoPedidos { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Impuesto> Impuestos { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Poblacion> Poblaciones { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<TipoCliente> Tipoclientes { get; set; }
        public virtual DbSet<TipoPago> TipoPagos { get; set; }
        public virtual DbSet<Transportista> Transportistas{ get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }

        public FacturacionContext() : base("Facturacion")
        {
            //Database.SetInitializer(new FacturacionContext());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Cliente>().Map(m =>
            {
                m.Properties<Cliente>(p => new { p.Bloque, p.Portal });
                
            });
            }
        }
    }
}

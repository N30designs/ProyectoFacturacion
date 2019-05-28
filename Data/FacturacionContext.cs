using facturacion.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using facturacion.Classes;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Pluralization;

namespace facturacion.Data
{
    /// <summary>
    /// Clase encargada de crear la base de datos.
    /// </summary>
    class FacturacionContext : DbContext
    {
        public FacturacionContext() : base()
        {

        }

        public FacturacionContext(string conection) : base(conection)
        {

        }

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

       
        /// <summary>
        /// Modifica parámetros al crear la base de datos.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                        
        }

        /// <summary>
        /// Clase interna que modificará diversos parámetros de la base de datos.
        /// </summary>
        public class configuracion : DbConfiguration
        {
            /// <summary>
            /// Constructor de la clase interna.
            /// </summary>
            public configuracion()
            {
                SetDatabaseLogFormatter(
                    (context, writeAction) => new OneLineLog(context, writeAction));

                SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb"));
                SetDatabaseInitializer(new FacturacionInitializer());
            }
        }
    }
}

namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albarans",
                c => new
                    {
                        Albaran_ID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        TipoRecargo = c.Int(nullable: false),
                        TipoRetencion = c.Int(nullable: false),
                        ImporteIva = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImporteBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImporteRecargo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cliente_Cliente_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Albaran_ID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Cliente_ID)
                .Index(t => t.Cliente_Cliente_ID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Cliente_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                        Apellidos = c.String(maxLength: 100),
                        CIF = c.String(nullable: false, maxLength: 10),
                        NombreFiscal = c.String(maxLength: 100),
                        Domicilio = c.String(nullable: false, maxLength: 100),
                        Numero = c.Int(nullable: false),
                        Bloque = c.Int(nullable: false),
                        Portal = c.Int(nullable: false),
                        Escalera = c.Int(nullable: false),
                        Planta = c.Int(nullable: false),
                        Piso = c.Int(nullable: false),
                        Puerta = c.String(),
                        Telefono1 = c.String(nullable: false),
                        Telefono2 = c.String(),
                        Email = c.String(),
                        Fax = c.String(),
                        Web = c.String(maxLength: 100),
                        Contacto = c.String(maxLength: 100),
                        Descuento = c.Int(nullable: false),
                        DiasPago = c.Int(nullable: false),
                        Iban = c.String(maxLength: 24),
                        Bic = c.String(maxLength: 11),
                        Irpf = c.Int(nullable: false),
                        Observaciones = c.String(maxLength: 1000),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                        Poblacion_Poblacion_ID = c.Int(),
                        TipoCliente_Tipo_Cliente_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Cliente_ID)
                .ForeignKey("dbo.Poblacions", t => t.Poblacion_Poblacion_ID)
                .ForeignKey("dbo.TipoClientes", t => t.TipoCliente_Tipo_Cliente_ID)
                .Index(t => t.CIF, unique: true)
                .Index(t => t.Poblacion_Poblacion_ID)
                .Index(t => t.TipoCliente_Tipo_Cliente_ID);
            
            CreateTable(
                "dbo.Poblacions",
                c => new
                    {
                        Poblacion_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Tipo = c.Int(nullable: false),
                        Cpostal = c.String(nullable: false),
                        Padre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Poblacion_ID);
            
            CreateTable(
                "dbo.TipoClientes",
                c => new
                    {
                        Tipo_Cliente_ID = c.Int(nullable: false, identity: true),
                        Denominacion = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Tipo_Cliente_ID);
            
            CreateTable(
                "dbo.DetalleFacturas",
                c => new
                    {
                        DetalleFacturaID = c.Int(nullable: false, identity: true),
                        Concepto = c.String(nullable: false, maxLength: 100),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Int(nullable: false),
                        ImporteBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImporteImpuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PorcentajeImpuestoAsociado = c.Int(nullable: false),
                        ImporteImpuestoAsociado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lote = c.String(maxLength: 50),
                        Serie = c.String(maxLength: 100),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha_Fabricacion = c.DateTime(nullable: false),
                        Factura_FacturaId = c.Int(),
                        Impuesto_Impuesto_ID = c.Int(),
                    })
                .PrimaryKey(t => t.DetalleFacturaID)
                .ForeignKey("dbo.Facturas", t => t.Factura_FacturaId)
                .ForeignKey("dbo.Impuestoes", t => t.Impuesto_Impuesto_ID)
                .Index(t => t.Factura_FacturaId)
                .Index(t => t.Impuesto_Impuesto_ID);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento_Factura = c.Int(nullable: false),
                        ImporteBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImporteRetencion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nota = c.String(),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                        Cliente_Cliente_ID = c.Int(),
                        Empresa_ID_EMPRESA = c.Int(),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Cliente_ID)
                .ForeignKey("dbo.Empresas", t => t.Empresa_ID_EMPRESA)
                .Index(t => t.Cliente_Cliente_ID)
                .Index(t => t.Empresa_ID_EMPRESA);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        ID_EMPRESA = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Ncomercial = c.String(nullable: false, maxLength: 100),
                        cif = c.String(nullable: false, maxLength: 10),
                        Inscripcion = c.Int(nullable: false),
                        Tomo = c.Int(nullable: false),
                        Folio = c.Int(nullable: false),
                        Registro = c.String(maxLength: 50),
                        Domicilio = c.String(nullable: false, maxLength: 100),
                        Numero = c.Int(nullable: false),
                        Bloque = c.Int(nullable: false),
                        Portal = c.Int(nullable: false),
                        Escalera = c.Int(nullable: false),
                        Planta = c.Int(nullable: false),
                        Puerta = c.String(maxLength: 10),
                        Fax = c.Int(nullable: false),
                        Administrador = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false),
                        Telefono2 = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                        RegimenEquivalencia = c.Boolean(nullable: false),
                        Web = c.String(maxLength: 100),
                        Email = c.String(),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                        Poblacion_Poblacion_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID_EMPRESA)
                .ForeignKey("dbo.Poblacions", t => t.Poblacion_Poblacion_ID)
                .Index(t => t.cif, unique: true)
                .Index(t => t.Poblacion_Poblacion_ID);
            
            CreateTable(
                "dbo.Impuestoes",
                c => new
                    {
                        Impuesto_ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        ImpuestoPorcentaje = c.Int(nullable: false),
                        Impuesto_Asociado_Porcentaje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Impuesto_ID);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Pais_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Moneda_Moneda_ID = c.Int(nullable: false),
                        Impuesto_Impuesto_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Pais_ID)
                .ForeignKey("dbo.Monedas", t => t.Moneda_Moneda_ID, cascadeDelete: true)
                .ForeignKey("dbo.Impuestoes", t => t.Impuesto_Impuesto_ID)
                .Index(t => t.Moneda_Moneda_ID)
                .Index(t => t.Impuesto_Impuesto_ID);
            
            CreateTable(
                "dbo.Monedas",
                c => new
                    {
                        Moneda_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Diminutivo = c.String(nullable: false),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha_Conversion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Moneda_ID);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        PedidoFecha = c.DateTime(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PedidoDescuento = c.Int(nullable: false),
                        DescuentosDetalle = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImporteBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImporteTransporte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaSalida = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                        Cliente_Cliente_ID = c.Int(),
                        DireccionEnvio_Direcccion_ID = c.Int(),
                        Preparador_EmpeleadoID = c.Int(),
                        Transportista_TransportistaID = c.Int(),
                        Vendedor_EmpeleadoID = c.Int(),
                        Impuesto_Impuesto_ID = c.Int(),
                        DetallePedido_DetallePedidoID = c.Int(),
                    })
                .PrimaryKey(t => t.PedidoID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Cliente_ID)
                .ForeignKey("dbo.Direccions", t => t.DireccionEnvio_Direcccion_ID)
                .ForeignKey("dbo.Empleadoes", t => t.Preparador_EmpeleadoID)
                .ForeignKey("dbo.Transportistas", t => t.Transportista_TransportistaID)
                .ForeignKey("dbo.Empleadoes", t => t.Vendedor_EmpeleadoID)
                .ForeignKey("dbo.Impuestoes", t => t.Impuesto_Impuesto_ID)
                .ForeignKey("dbo.DetallePedidoes", t => t.DetallePedido_DetallePedidoID)
                .Index(t => t.Cliente_Cliente_ID)
                .Index(t => t.DireccionEnvio_Direcccion_ID)
                .Index(t => t.Preparador_EmpeleadoID)
                .Index(t => t.Transportista_TransportistaID)
                .Index(t => t.Vendedor_EmpeleadoID)
                .Index(t => t.Impuesto_Impuesto_ID)
                .Index(t => t.DetallePedido_DetallePedidoID);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        Direcccion_ID = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Numero = c.Int(nullable: false),
                        Bloque = c.Int(nullable: false),
                        Portal = c.Int(nullable: false),
                        Escalera = c.Int(nullable: false),
                        Planta = c.Int(nullable: false),
                        Piso = c.Int(nullable: false),
                        Puerta = c.String(maxLength: 10),
                        Telefono = c.String(nullable: false),
                        Telefono2 = c.String(),
                        Fax = c.String(),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                        Cliente_Cliente_ID = c.Int(),
                        Poblacion_Poblacion_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Direcccion_ID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Cliente_ID)
                .ForeignKey("dbo.Poblacions", t => t.Poblacion_Poblacion_ID)
                .Index(t => t.Cliente_Cliente_ID)
                .Index(t => t.Poblacion_Poblacion_ID);
            
            CreateTable(
                "dbo.Pagoes",
                c => new
                    {
                        PagoID = c.Int(nullable: false, identity: true),
                        FechaPago = c.DateTime(nullable: false),
                        Factura_FacturaId = c.Int(),
                        Pedido_PedidoID = c.Int(),
                        TipoPago_TipoPagoID = c.Int(),
                    })
                .PrimaryKey(t => t.PagoID)
                .ForeignKey("dbo.Facturas", t => t.Factura_FacturaId)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_PedidoID)
                .ForeignKey("dbo.TipoPagoes", t => t.TipoPago_TipoPagoID)
                .Index(t => t.Factura_FacturaId)
                .Index(t => t.Pedido_PedidoID)
                .Index(t => t.TipoPago_TipoPagoID);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Numero1 = c.String(maxLength: 50),
                        Numero2 = c.String(maxLength: 30),
                        Numero3 = c.String(maxLength: 30),
                        Caducidad = c.DateTime(nullable: false),
                        Emision = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPagoID);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpeleadoID = c.Int(nullable: false, identity: true),
                        TipoEmpleado = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido1 = c.String(nullable: false, maxLength: 50),
                        Apellido2 = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Nif = c.String(nullable: false, maxLength: 9),
                        Email = c.String(),
                        Telefono1 = c.String(nullable: false),
                        Telefono2 = c.String(),
                        Direccion = c.String(maxLength: 100),
                        Numero = c.Int(nullable: false),
                        Bloque = c.Int(nullable: false),
                        Escalera = c.Int(nullable: false),
                        Portal = c.Int(nullable: false),
                        Planta = c.Int(nullable: false),
                        Piso = c.Int(nullable: false),
                        Puerta = c.String(),
                        Fax = c.String(),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaBaja = c.DateTime(nullable: false),
                        BIC = c.Int(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observaciones = c.String(),
                        Poblacion_Poblacion_ID = c.Int(),
                    })
                .PrimaryKey(t => t.EmpeleadoID)
                .ForeignKey("dbo.Poblacions", t => t.Poblacion_Poblacion_ID)
                .Index(t => t.Poblacion_Poblacion_ID);
            
            CreateTable(
                "dbo.Transportistas",
                c => new
                    {
                        TransportistaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        PrecioUnidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HorarioRecogida = c.DateTime(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Numero = c.Int(nullable: false),
                        Bloque = c.Int(nullable: false),
                        Escalera = c.Int(nullable: false),
                        Portal = c.Int(nullable: false),
                        Planta = c.Int(nullable: false),
                        Piso = c.Int(nullable: false),
                        Puerta = c.Int(nullable: false),
                        Comercial = c.String(maxLength: 100),
                        Repartidor = c.String(maxLength: 100),
                        TelefonoComercial = c.String(),
                        TelefonoRepartidor = c.String(),
                        Telefono1 = c.String(nullable: false),
                        Telefono2 = c.String(),
                        Observaciones = c.String(maxLength: 1000),
                        Poblacion_Poblacion_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransportistaID)
                .ForeignKey("dbo.Poblacions", t => t.Poblacion_Poblacion_ID, cascadeDelete: true)
                .Index(t => t.Poblacion_Poblacion_ID);
            
            CreateTable(
                "dbo.DetallePedidoes",
                c => new
                    {
                        DetallePedidoID = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArticuloDescuento = c.Int(nullable: false),
                        LineaDescuento = c.Int(nullable: false),
                        ImporteBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lote = c.String(maxLength: 100),
                        Serie = c.String(maxLength: 100),
                        Peso = c.Single(nullable: false),
                        FechaFabricacion = c.DateTime(nullable: false),
                        ImpuestoPorcentaje = c.Int(nullable: false),
                        ImpuestoImporte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImpuestoAsociadoPorcentaje = c.Int(nullable: false),
                        ImpuestoAsociadoImporte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineaTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Impuesto_ID_Impuesto_ID = c.Int(),
                        Producto_Producto_ID = c.Int(),
                    })
                .PrimaryKey(t => t.DetallePedidoID)
                .ForeignKey("dbo.Impuestoes", t => t.Impuesto_ID_Impuesto_ID)
                .ForeignKey("dbo.Productoes", t => t.Producto_Producto_ID)
                .Index(t => t.Impuesto_ID_Impuesto_ID)
                .Index(t => t.Producto_Producto_ID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Producto_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 250),
                        Referencia = c.String(maxLength: 50),
                        Lote = c.String(maxLength: 100),
                        Serie = c.String(maxLength: 100),
                        FechaFabricacion = c.DateTime(nullable: false),
                        Peso = c.Single(nullable: false),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Margen = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 1000),
                        Articulo_Descuento = c.Int(nullable: false),
                        Observaciones = c.String(maxLength: 1000),
                        EAN13 = c.Int(nullable: false),
                        Proveedor_Proveedor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Producto_ID)
                .ForeignKey("dbo.Proveedors", t => t.Proveedor_Proveedor_ID)
                .Index(t => t.Proveedor_Proveedor_ID);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        Proveedor_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Proveedor_ID);
            
            CreateTable(
                "dbo.EstadoPedidoes",
                c => new
                    {
                        EstadoPedidoID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.EstadoPedidoID);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        SerieID = c.Int(nullable: false, identity: true),
                        Valor = c.Int(nullable: false),
                        Serie = c.String(nullable: false, maxLength: 10),
                        Empresa_ID_EMPRESA = c.Int(),
                    })
                .PrimaryKey(t => t.SerieID)
                .ForeignKey("dbo.Empresas", t => t.Empresa_ID_EMPRESA)
                .Index(t => t.Empresa_ID_EMPRESA);
            
            CreateTable(
                "dbo.Ubicaciones",
                c => new
                    {
                        UBICACION_ID = c.Int(nullable: false, identity: true),
                        Referencia = c.String(maxLength: 50),
                        Almacen = c.String(maxLength: 50),
                        Pasillo = c.Int(nullable: false),
                        Leja = c.Int(nullable: false),
                        Ubicacion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UBICACION_ID);
            
            CreateTable(
                "dbo.ImpuestoFacturas",
                c => new
                    {
                        Impuesto_Impuesto_ID = c.Int(nullable: false),
                        Factura_FacturaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Impuesto_Impuesto_ID, t.Factura_FacturaId })
                .ForeignKey("dbo.Impuestoes", t => t.Impuesto_Impuesto_ID, cascadeDelete: true)
                .ForeignKey("dbo.Facturas", t => t.Factura_FacturaId, cascadeDelete: true)
                .Index(t => t.Impuesto_Impuesto_ID)
                .Index(t => t.Factura_FacturaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "Empresa_ID_EMPRESA", "dbo.Empresas");
            DropForeignKey("dbo.DetallePedidoes", "Producto_Producto_ID", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "Proveedor_Proveedor_ID", "dbo.Proveedors");
            DropForeignKey("dbo.Pedidoes", "DetallePedido_DetallePedidoID", "dbo.DetallePedidoes");
            DropForeignKey("dbo.DetallePedidoes", "Impuesto_ID_Impuesto_ID", "dbo.Impuestoes");
            DropForeignKey("dbo.DetalleFacturas", "Impuesto_Impuesto_ID", "dbo.Impuestoes");
            DropForeignKey("dbo.DetalleFacturas", "Factura_FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.Pedidoes", "Impuesto_Impuesto_ID", "dbo.Impuestoes");
            DropForeignKey("dbo.Pedidoes", "Vendedor_EmpeleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.Pedidoes", "Transportista_TransportistaID", "dbo.Transportistas");
            DropForeignKey("dbo.Transportistas", "Poblacion_Poblacion_ID", "dbo.Poblacions");
            DropForeignKey("dbo.Pedidoes", "Preparador_EmpeleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.Empleadoes", "Poblacion_Poblacion_ID", "dbo.Poblacions");
            DropForeignKey("dbo.Pagoes", "TipoPago_TipoPagoID", "dbo.TipoPagoes");
            DropForeignKey("dbo.Pagoes", "Pedido_PedidoID", "dbo.Pedidoes");
            DropForeignKey("dbo.Pagoes", "Factura_FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.Pedidoes", "DireccionEnvio_Direcccion_ID", "dbo.Direccions");
            DropForeignKey("dbo.Direccions", "Poblacion_Poblacion_ID", "dbo.Poblacions");
            DropForeignKey("dbo.Direccions", "Cliente_Cliente_ID", "dbo.Clientes");
            DropForeignKey("dbo.Pedidoes", "Cliente_Cliente_ID", "dbo.Clientes");
            DropForeignKey("dbo.Pais", "Impuesto_Impuesto_ID", "dbo.Impuestoes");
            DropForeignKey("dbo.Pais", "Moneda_Moneda_ID", "dbo.Monedas");
            DropForeignKey("dbo.ImpuestoFacturas", "Factura_FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.ImpuestoFacturas", "Impuesto_Impuesto_ID", "dbo.Impuestoes");
            DropForeignKey("dbo.Facturas", "Empresa_ID_EMPRESA", "dbo.Empresas");
            DropForeignKey("dbo.Empresas", "Poblacion_Poblacion_ID", "dbo.Poblacions");
            DropForeignKey("dbo.Facturas", "Cliente_Cliente_ID", "dbo.Clientes");
            DropForeignKey("dbo.Albarans", "Cliente_Cliente_ID", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "TipoCliente_Tipo_Cliente_ID", "dbo.TipoClientes");
            DropForeignKey("dbo.Clientes", "Poblacion_Poblacion_ID", "dbo.Poblacions");
            DropIndex("dbo.ImpuestoFacturas", new[] { "Factura_FacturaId" });
            DropIndex("dbo.ImpuestoFacturas", new[] { "Impuesto_Impuesto_ID" });
            DropIndex("dbo.Series", new[] { "Empresa_ID_EMPRESA" });
            DropIndex("dbo.Productoes", new[] { "Proveedor_Proveedor_ID" });
            DropIndex("dbo.DetallePedidoes", new[] { "Producto_Producto_ID" });
            DropIndex("dbo.DetallePedidoes", new[] { "Impuesto_ID_Impuesto_ID" });
            DropIndex("dbo.Transportistas", new[] { "Poblacion_Poblacion_ID" });
            DropIndex("dbo.Empleadoes", new[] { "Poblacion_Poblacion_ID" });
            DropIndex("dbo.Pagoes", new[] { "TipoPago_TipoPagoID" });
            DropIndex("dbo.Pagoes", new[] { "Pedido_PedidoID" });
            DropIndex("dbo.Pagoes", new[] { "Factura_FacturaId" });
            DropIndex("dbo.Direccions", new[] { "Poblacion_Poblacion_ID" });
            DropIndex("dbo.Direccions", new[] { "Cliente_Cliente_ID" });
            DropIndex("dbo.Pedidoes", new[] { "DetallePedido_DetallePedidoID" });
            DropIndex("dbo.Pedidoes", new[] { "Impuesto_Impuesto_ID" });
            DropIndex("dbo.Pedidoes", new[] { "Vendedor_EmpeleadoID" });
            DropIndex("dbo.Pedidoes", new[] { "Transportista_TransportistaID" });
            DropIndex("dbo.Pedidoes", new[] { "Preparador_EmpeleadoID" });
            DropIndex("dbo.Pedidoes", new[] { "DireccionEnvio_Direcccion_ID" });
            DropIndex("dbo.Pedidoes", new[] { "Cliente_Cliente_ID" });
            DropIndex("dbo.Pais", new[] { "Impuesto_Impuesto_ID" });
            DropIndex("dbo.Pais", new[] { "Moneda_Moneda_ID" });
            DropIndex("dbo.Empresas", new[] { "Poblacion_Poblacion_ID" });
            DropIndex("dbo.Empresas", new[] { "cif" });
            DropIndex("dbo.Facturas", new[] { "Empresa_ID_EMPRESA" });
            DropIndex("dbo.Facturas", new[] { "Cliente_Cliente_ID" });
            DropIndex("dbo.DetalleFacturas", new[] { "Impuesto_Impuesto_ID" });
            DropIndex("dbo.DetalleFacturas", new[] { "Factura_FacturaId" });
            DropIndex("dbo.Clientes", new[] { "TipoCliente_Tipo_Cliente_ID" });
            DropIndex("dbo.Clientes", new[] { "Poblacion_Poblacion_ID" });
            DropIndex("dbo.Clientes", new[] { "CIF" });
            DropIndex("dbo.Albarans", new[] { "Cliente_Cliente_ID" });
            DropTable("dbo.ImpuestoFacturas");
            DropTable("dbo.Ubicaciones");
            DropTable("dbo.Series");
            DropTable("dbo.EstadoPedidoes");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Productoes");
            DropTable("dbo.DetallePedidoes");
            DropTable("dbo.Transportistas");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.Pagoes");
            DropTable("dbo.Direccions");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Monedas");
            DropTable("dbo.Pais");
            DropTable("dbo.Impuestoes");
            DropTable("dbo.Empresas");
            DropTable("dbo.Facturas");
            DropTable("dbo.DetalleFacturas");
            DropTable("dbo.TipoClientes");
            DropTable("dbo.Poblacions");
            DropTable("dbo.Clientes");
            DropTable("dbo.Albarans");
        }
    }
}

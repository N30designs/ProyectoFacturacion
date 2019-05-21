namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bloqueOpcional : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Albarans", newName: "Albaran");
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            RenameTable(name: "dbo.Poblacions", newName: "Poblacion");
            RenameTable(name: "dbo.TipoClientes", newName: "TipoCliente");
            RenameTable(name: "dbo.DetalleFacturas", newName: "DetalleFactura");
            RenameTable(name: "dbo.Facturas", newName: "Factura");
            RenameTable(name: "dbo.Empresas", newName: "Empresa");
            RenameTable(name: "dbo.Impuestoes", newName: "Impuesto");
            RenameTable(name: "dbo.Monedas", newName: "Moneda");
            RenameTable(name: "dbo.Pedidoes", newName: "Pedido");
            RenameTable(name: "dbo.Direccions", newName: "Direccion");
            RenameTable(name: "dbo.Pagoes", newName: "Pago");
            RenameTable(name: "dbo.TipoPagoes", newName: "TipoPago");
            RenameTable(name: "dbo.Empleadoes", newName: "Empleado");
            RenameTable(name: "dbo.Transportistas", newName: "Transportista");
            RenameTable(name: "dbo.DetallePedidoes", newName: "DetallePedido");
            RenameTable(name: "dbo.Productoes", newName: "Producto");
            RenameTable(name: "dbo.Proveedors", newName: "Proveedor");
            RenameTable(name: "dbo.EstadoPedidoes", newName: "EstadoPedido");
            RenameTable(name: "dbo.ImpuestoFacturas", newName: "ImpuestoFactura");
            AlterColumn("dbo.Cliente", "Bloque", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Bloque", c => c.Int(nullable: false));
            RenameTable(name: "dbo.ImpuestoFactura", newName: "ImpuestoFacturas");
            RenameTable(name: "dbo.EstadoPedido", newName: "EstadoPedidoes");
            RenameTable(name: "dbo.Proveedor", newName: "Proveedors");
            RenameTable(name: "dbo.Producto", newName: "Productoes");
            RenameTable(name: "dbo.DetallePedido", newName: "DetallePedidoes");
            RenameTable(name: "dbo.Transportista", newName: "Transportistas");
            RenameTable(name: "dbo.Empleado", newName: "Empleadoes");
            RenameTable(name: "dbo.TipoPago", newName: "TipoPagoes");
            RenameTable(name: "dbo.Pago", newName: "Pagoes");
            RenameTable(name: "dbo.Direccion", newName: "Direccions");
            RenameTable(name: "dbo.Pedido", newName: "Pedidoes");
            RenameTable(name: "dbo.Moneda", newName: "Monedas");
            RenameTable(name: "dbo.Impuesto", newName: "Impuestoes");
            RenameTable(name: "dbo.Empresa", newName: "Empresas");
            RenameTable(name: "dbo.Factura", newName: "Facturas");
            RenameTable(name: "dbo.DetalleFactura", newName: "DetalleFacturas");
            RenameTable(name: "dbo.TipoCliente", newName: "TipoClientes");
            RenameTable(name: "dbo.Poblacion", newName: "Poblacions");
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
            RenameTable(name: "dbo.Albaran", newName: "Albarans");
        }
    }
}

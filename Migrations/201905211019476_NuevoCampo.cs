namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoCampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "CampoAeliminar", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "CampoAeliminar");
        }
    }
}

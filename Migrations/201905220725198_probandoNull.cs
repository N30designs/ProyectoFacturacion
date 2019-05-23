namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class probandoNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Portal", c => c.Int());
            AlterColumn("dbo.Cliente", "Escalera", c => c.Int());
            AlterColumn("dbo.Cliente", "Planta", c => c.Int());
            AlterColumn("dbo.Cliente", "Piso", c => c.Int());
            DropColumn("dbo.Cliente", "CampoAeliminar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "CampoAeliminar", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "Piso", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "Planta", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "Escalera", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "Portal", c => c.Int(nullable: false));
        }
    }
}

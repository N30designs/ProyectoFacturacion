namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pruebaCambioCliente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cliente", "Poblacion_Poblacion_ID", "dbo.Poblacion");
            DropIndex("dbo.Cliente", new[] { "Poblacion_Poblacion_ID" });
            RenameColumn(table: "dbo.Cliente", name: "Poblacion_Poblacion_ID", newName: "Poblacion_ID");
            AlterColumn("dbo.Cliente", "Poblacion_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cliente", "Poblacion_ID");
            AddForeignKey("dbo.Cliente", "Poblacion_ID", "dbo.Poblacion", "Poblacion_ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "Poblacion_ID", "dbo.Poblacion");
            DropIndex("dbo.Cliente", new[] { "Poblacion_ID" });
            AlterColumn("dbo.Cliente", "Poblacion_ID", c => c.Int());
            RenameColumn(table: "dbo.Cliente", name: "Poblacion_ID", newName: "Poblacion_Poblacion_ID");
            CreateIndex("dbo.Cliente", "Poblacion_Poblacion_ID");
            AddForeignKey("dbo.Cliente", "Poblacion_Poblacion_ID", "dbo.Poblacion", "Poblacion_ID");
        }
    }
}

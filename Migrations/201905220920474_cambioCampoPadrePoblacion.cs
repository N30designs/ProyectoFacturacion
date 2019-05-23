namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioCampoPadrePoblacion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Poblacion", "Padre", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Poblacion", "Padre", c => c.Int(nullable: false));
        }
    }
}

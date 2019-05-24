namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postalNoObligatorio : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Poblacion", "Cpostal", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Poblacion", "Cpostal", c => c.String(nullable: false));
        }
    }
}

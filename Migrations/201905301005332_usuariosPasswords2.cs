namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuariosPasswords2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleado", "Numero", c => c.Int());
            AlterColumn("dbo.Empleado", "Bloque", c => c.Int());
            AlterColumn("dbo.Empleado", "Escalera", c => c.Int());
            AlterColumn("dbo.Empleado", "Portal", c => c.Int());
            AlterColumn("dbo.Empleado", "Planta", c => c.Int());
            AlterColumn("dbo.Empleado", "Piso", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleado", "Piso", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleado", "Planta", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleado", "Portal", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleado", "Escalera", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleado", "Bloque", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleado", "Numero", c => c.Int(nullable: false));
        }
    }
}

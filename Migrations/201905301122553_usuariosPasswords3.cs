namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuariosPasswords3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleado", "FechaAlta", c => c.DateTime());
            AlterColumn("dbo.Empleado", "FechaBaja", c => c.DateTime());
            AlterColumn("dbo.Empleado", "BIC", c => c.Int());
            AlterColumn("dbo.Empleado", "Salario", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Empleado", "Usuario", c => c.String(nullable: false, maxLength: 100, unicode: false));
            CreateIndex("dbo.Empleado", "Usuario", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Empleado", new[] { "Usuario" });
            AlterColumn("dbo.Empleado", "Usuario", c => c.String());
            AlterColumn("dbo.Empleado", "Salario", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Empleado", "BIC", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleado", "FechaBaja", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Empleado", "FechaAlta", c => c.DateTime(nullable: false));
        }
    }
}

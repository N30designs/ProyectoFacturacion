namespace facturacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuariosPasswords : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleado", "Usuario", c => c.String());
            AddColumn("dbo.Empleado", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleado", "Password");
            DropColumn("dbo.Empleado", "Usuario");
        }
    }
}

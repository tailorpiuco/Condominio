namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v112 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Nome", c => c.String(maxLength: 100, unicode: false, storeType: "nvarchar"));
            AddColumn("dbo.Usuarios", "DataRegistro", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "DataRegistro");
            DropColumn("dbo.Usuarios", "Nome");
        }
    }
}

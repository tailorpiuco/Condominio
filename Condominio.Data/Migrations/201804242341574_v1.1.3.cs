namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v113 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Moradores", "Nome", c => c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Moradores", "Telefone", c => c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Moradores", "CPF", c => c.String(nullable: false, maxLength: 11, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Moradores", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Moradores", "Email", c => c.String(maxLength: 50, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Moradores", "CPF", c => c.String(maxLength: 11, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Moradores", "Telefone", c => c.String(maxLength: 20, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Moradores", "Nome", c => c.String(maxLength: 100, unicode: false, storeType: "nvarchar"));
        }
    }
}

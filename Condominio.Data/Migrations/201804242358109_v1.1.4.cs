namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v114 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Moradores", "CPF", c => c.String(nullable: false, maxLength: 14, unicode: false, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Moradores", "CPF", c => c.String(nullable: false, maxLength: 11, unicode: false, storeType: "nvarchar"));
        }
    }
}

namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v101 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.moradores", "Responsavel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.moradores", "Responsavel");
        }
    }
}

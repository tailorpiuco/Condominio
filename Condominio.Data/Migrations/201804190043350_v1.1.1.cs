namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v111 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apartamentos", "ResponsavelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Apartamentos", "ResponsavelId");
            AddForeignKey("dbo.Apartamentos", "ResponsavelId", "dbo.Moradores", "Id", cascadeDelete: true);
            DropColumn("dbo.Moradores", "Responsavel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Moradores", "Responsavel", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Apartamentos", "ResponsavelId", "dbo.Moradores");
            DropIndex("dbo.Apartamentos", new[] { "ResponsavelId" });
            DropColumn("dbo.Apartamentos", "ResponsavelId");
        }
    }
}

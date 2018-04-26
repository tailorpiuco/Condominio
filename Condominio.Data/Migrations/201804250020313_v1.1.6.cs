namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v116 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Moradores", "ApartamentoId", c => c.Int());
            CreateIndex("dbo.Moradores", "ApartamentoId");
            AddForeignKey("dbo.Moradores", "ApartamentoId", "dbo.Apartamentos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Moradores", "ApartamentoId", "dbo.Apartamentos");
            DropIndex("dbo.Moradores", new[] { "ApartamentoId" });
            DropColumn("dbo.Moradores", "ApartamentoId");
        }
    }
}

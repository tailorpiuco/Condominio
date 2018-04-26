namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v115 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Moradores", "ApartamentoId", "Apartamentos");
            DropIndex("Moradores", new[] { "ApartamentoId" });
            AddColumn("Moradores", "Apartamento_Id", c => c.Int());
            CreateIndex("Moradores", "Apartamento_Id");
            AddForeignKey("Moradores", "Apartamento_Id", "Apartamentos", "Id");
            DropColumn("Moradores", "ApartamentoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Moradores", "ApartamentoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Moradores", "Apartamento_Id", "dbo.Apartamentos");
            DropIndex("dbo.Moradores", new[] { "Apartamento_Id" });
            DropColumn("dbo.Moradores", "Apartamento_Id");
            CreateIndex("dbo.Moradores", "ApartamentoId");
            AddForeignKey("dbo.Moradores", "ApartamentoId", "dbo.Apartamentos", "Id");
        }
    }
}

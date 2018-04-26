namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v110 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apartamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Bloco = c.String(maxLength: 5, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Moradores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        DataNascimento = c.DateTime(nullable: false, precision: 0),
                        Telefone = c.String(maxLength: 20, unicode: false, storeType: "nvarchar"),
                        CPF = c.String(maxLength: 11, unicode: false, storeType: "nvarchar"),
                        Email = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Responsavel = c.Boolean(nullable: false),
                        ApartamentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartamentos", t => t.ApartamentoId)
                .Index(t => t.ApartamentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Moradores", "ApartamentoId", "dbo.Apartamentos");
            DropIndex("dbo.Moradores", new[] { "ApartamentoId" });
            DropTable("dbo.Moradores");
            DropTable("dbo.Apartamentos");
        }
    }
}

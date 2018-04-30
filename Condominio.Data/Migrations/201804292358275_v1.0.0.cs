namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v100 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.apartamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Bloco = c.String(maxLength: 5, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.moradores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        DataNascimento = c.DateTime(nullable: false, precision: 0),
                        Telefone = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        CPF = c.String(nullable: false, maxLength: 14, unicode: false, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        ApartamentoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.apartamentos", t => t.ApartamentoId)
                .Index(t => t.ApartamentoId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Senha = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Nome = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        DataRegistro = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.moradores", "ApartamentoId", "dbo.apartamentos");
            DropIndex("dbo.moradores", new[] { "ApartamentoId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.moradores");
            DropTable("dbo.apartamentos");
        }
    }
}

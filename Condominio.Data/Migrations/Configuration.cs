namespace Condominio.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CondominioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(CondominioContext context)
        {
            context.Usuarios.AddOrUpdate(
                new Models.Usuario
                {
                    Id = 1,
                    Login = "teste@teste.com.br",
                    Senha = "teste123",
                    DataRegistro = DateTime.Now,
                    Nome = "Administrador"
                });

            context.SaveChanges();
        }
    }
}

using Condominio.Data.Configurations;
using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Data
{
    public class CondominioContext : DbContext
    {
        public CondominioContext() : base("condominio")
        {
            Database.SetInitializer<CondominioContext>(null);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Morador> Moradores { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ApartamentoConfiguration());
            modelBuilder.Configurations.Add(new MoradorConfiguration());
        }
    }
}

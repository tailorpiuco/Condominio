using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Data
{
    public class CondominioContext : DbContext
    {
        public CondominioContext() : base("Condominio")
        {
            Database.SetInitializer<CondominioContext>(null);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Morador> Moradores { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Morador>()
            //    .HasRequired<Apartamento>(m => m.Apartamento)
            //    .WithMany(m => m.Moradores)
            //    .WillCascadeOnDelete(false);                                            
        }
    }
}

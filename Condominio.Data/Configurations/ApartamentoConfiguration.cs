using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Data.Configurations
{
    public class ApartamentoConfiguration : EntityTypeConfiguration<Apartamento>
    {
        public ApartamentoConfiguration()
        {
            this.Property(p => p.Bloco)
                .HasMaxLength(5)
                .IsOptional();

            this.Property(p => p.Numero)
                .IsRequired();

            this.HasRequired(p => p.Moradores)
                .WithOptional();                        
        }
    }
}

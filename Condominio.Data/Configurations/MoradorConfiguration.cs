using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Data.Configurations
{
    public class MoradorConfiguration : EntityTypeConfiguration<Morador>
    {
        public MoradorConfiguration()
        {
            this.Property(p => p.CPF)
                .HasMaxLength(14)
                .IsRequired();

            this.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();

            this.Property(p => p.Telefone)
                .HasMaxLength(20)
                .IsRequired();

            this.Property(p => p.Email)
                .HasMaxLength(100)
                .IsRequired();

            this.HasOptional(p => p.Apartamento)
                .WithMany(p => p.Moradores)
                .HasForeignKey(p => p.ApartamentoId);
        }
    }
}

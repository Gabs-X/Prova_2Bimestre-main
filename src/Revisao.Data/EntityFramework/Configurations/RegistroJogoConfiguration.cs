using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.EntityFramework.Configurations
{
    public class RegistroJogoConfiguration : IEntityTypeConfiguration<RegistroJogo>
    {
        public void Configure(EntityTypeBuilder<RegistroJogo> builder)
        {
            builder.ToTable("TB_JOGO");
            builder.HasKey(a => a.jogo_id);

            builder
                .Property(a => a.jogo_id)
                .UseIdentityColumn()
                .HasColumnName("ID_JOGO")
                .HasColumnType("int");

            builder
                .Property(a => a.primeiroNumero)
                .HasColumnName("PRIMEIRO_NUMERO")
                .HasColumnType("int");

            builder
                .Property(a => a.segundoNumero)
                .HasColumnName("SEGUNDO_NUMERO")
                .HasColumnType("int");

            builder
                .Property(a => a.terceiroNumero)
                .HasColumnName("TERCEIRO_NUMERO")
                .HasColumnType("int");

            builder
                .Property(a => a.quartoNumero)
                .HasColumnName("QUARTO_NUMERO")
                .HasColumnType("int");

            builder
                .Property(a => a.quintoNumero)
                .HasColumnName("QUINTO_NUMERO")
                .HasColumnType("int");

            builder
                .Property(a => a.sextoNumero)
                .HasColumnName("SEXTO_NUMERO")
                .HasColumnType("int");

        }
    }
}

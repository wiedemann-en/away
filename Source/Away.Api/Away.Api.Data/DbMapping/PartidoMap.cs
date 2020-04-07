using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class PartidoMap : IEntityTypeConfiguration<PartidoModel>
    {
        public void Configure(EntityTypeBuilder<PartidoModel> builder)
        {
            builder.ToTable("Partido", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdPartido");

            builder.Property(p => p.IdPais)
                .IsRequired();

            builder.Property(p => p.IdProvincia)
                .IsRequired();

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Activo)
                .IsRequired();

            //References
            builder
                .HasOne<ProvinciaModel>(a => a.Provincia)
                .WithMany(b => b.Partidos)
                .HasForeignKey(a => a.IdProvincia);

            builder
                .HasMany<LocalidadModel>(a => a.Localidades)
                .WithOne(b => b.Partido)
                .HasForeignKey(b => b.IdPartido)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

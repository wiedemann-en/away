using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ProvinciaMap : IEntityTypeConfiguration<ProvinciaModel>
    {
        public void Configure(EntityTypeBuilder<ProvinciaModel> builder)
        {
            builder.ToTable("Provincia", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdProvincia");

            builder.Property(p => p.IdPais)
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
                .HasOne<PaisModel>(a => a.Pais)
                .WithMany(b => b.Provincias)
                .HasForeignKey(a => a.IdPais);

            builder
                .HasMany<PartidoModel>(a => a.Partidos)
                .WithOne(b => b.Provincia)
                .HasForeignKey(b => b.IdProvincia)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

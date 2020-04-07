using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class LocalidadMap : IEntityTypeConfiguration<LocalidadModel>
    {
        public void Configure(EntityTypeBuilder<LocalidadModel> builder)
        {
            builder.ToTable("Localidad", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdLocalidad");

            builder.Property(p => p.IdPais)
                .IsRequired();

            builder.Property(p => p.IdProvincia)
                .IsRequired();

            builder.Property(p => p.IdPartido)
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
                .HasOne<PartidoModel>(a => a.Partido)
                .WithMany(b => b.Localidades)
                .HasForeignKey(a => a.IdPartido);

            builder
                .HasMany<EnteDomicilioModel>(a => a.Domicilios)
                .WithOne(b => b.Localidad)
                .HasForeignKey(b => b.IdLocalidad)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

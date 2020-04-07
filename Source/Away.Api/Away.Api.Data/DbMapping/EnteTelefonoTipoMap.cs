using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class EnteTelefonoTipoMap : IEntityTypeConfiguration<EnteTelefonoTipoModel>
    {
        public void Configure(EntityTypeBuilder<EnteTelefonoTipoModel> builder)
        {
            builder.ToTable("EnteTelefonoTipo", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdTipo");

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
                .HasMany<EnteTelefonoModel>(a => a.Telefonos)
                .WithOne(b => b.Tipo)
                .HasForeignKey(b => b.IdTipo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

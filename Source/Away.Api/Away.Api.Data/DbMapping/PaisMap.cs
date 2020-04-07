using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class PaisMap : IEntityTypeConfiguration<PaisModel>
    {
        public void Configure(EntityTypeBuilder<PaisModel> builder)
        {
            builder.ToTable("Pais", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdPais");

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
                .HasMany<ProvinciaModel>(a => a.Provincias)
                .WithOne(b => b.Pais)
                .HasForeignKey(b => b.IdPais)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

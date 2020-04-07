using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class AlicuotaIvaMap : IEntityTypeConfiguration<AlicuotaIvaModel>
    {
        public void Configure(EntityTypeBuilder<AlicuotaIvaModel> builder)
        {
            builder.ToTable("AlicuotaIva", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdAlicuotaIva");

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
                .HasMany<ArticuloModel>(a => a.Articulos)
                .WithOne(b => b.AlicuotaIva)
                .HasForeignKey(b => b.IdAlicuotaIva)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ArticuloModel>(a => a.ArticulosDiferencial)
                .WithOne(b => b.AlicuotaIvaDiferencial)
                .HasForeignKey(b => b.IdAlicuotaIvaDiferencial);
        }
    }
}

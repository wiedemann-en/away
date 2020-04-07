using Away.Api.Data.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ArticuloUnidadMedidaMap : IEntityTypeConfiguration<ArticuloUnidadMedidaModel>
    {
        public void Configure(EntityTypeBuilder<ArticuloUnidadMedidaModel> builder)
        {
            builder.ToTable("ArticuloUnidadMedida", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdUnidadMedida");

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
                .WithOne(b => b.UnidadMedida)
                .HasForeignKey(b => b.IdUnidadMedida)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

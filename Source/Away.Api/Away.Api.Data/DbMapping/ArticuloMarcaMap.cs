using Away.Api.Data.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ArticuloMarcaMap : IEntityTypeConfiguration<ArticuloMarcaModel>
    {
        public void Configure(EntityTypeBuilder<ArticuloMarcaModel> builder)
        {
            builder.ToTable("ArticuloMarca", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdMarca");

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
                .WithOne(b => b.Marca)
                .HasForeignKey(b => b.IdMarca)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

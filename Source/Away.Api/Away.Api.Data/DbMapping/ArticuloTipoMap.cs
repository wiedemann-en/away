using Away.Api.Data.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ArticuloTipoMap : IEntityTypeConfiguration<ArticuloTipoModel>
    {
        public void Configure(EntityTypeBuilder<ArticuloTipoModel> builder)
        {
            builder.ToTable("ArticuloTipo", "dbo");

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
                .HasMany<ArticuloModel>(a => a.Articulos)
                .WithOne(b => b.Tipo)
                .HasForeignKey(b => b.IdTipo)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ArticuloSubTipoModel>(a => a.SubTipos)
                .WithOne(b => b.Tipo)
                .HasForeignKey(b => b.IdTipo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

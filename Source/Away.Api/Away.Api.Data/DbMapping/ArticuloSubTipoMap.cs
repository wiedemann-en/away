using Away.Api.Data.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ArticuloSubTipoMap : IEntityTypeConfiguration<ArticuloSubTipoModel>
    {
        public void Configure(EntityTypeBuilder<ArticuloSubTipoModel> builder)
        {
            builder.ToTable("ArticuloSubTipo", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdSubTipo");

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
                .HasOne<ArticuloTipoModel>(a => a.Tipo)
                .WithMany(b => b.SubTipos)
                .HasForeignKey(a => a.IdTipo);

            builder
                .HasMany<ArticuloModel>(a => a.Articulos)
                .WithOne(b => b.SubTipo)
                .HasForeignKey(b => b.IdSubTipo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

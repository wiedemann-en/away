using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ArticuloMap : IEntityTypeConfiguration<ArticuloModel>
    {
        public void Configure(EntityTypeBuilder<ArticuloModel> builder)
        {
            builder.ToTable("Articulo", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdArticulo");

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Familia)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.Property(p => p.Grupo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Presentacion)
                .HasMaxLength(50);

            builder.Property(p => p.Color)
                .HasMaxLength(50);

            builder.Property(p => p.ImpuestosInternosFijos)
                .HasColumnType("decimal(18,6)");

            builder.Property(p => p.ImpuestosInternosPorc)
                .HasColumnType("decimal(18,6)");

            builder.Property(p => p.PercepcionIIBB)
                .HasColumnType("decimal(18,6)");

            builder.Property(p => p.Activo)
                .IsRequired();

            //Auditory
            builder.OwnsOne(p => p.Auditoria, audit =>
            {
                audit.Property(p => p.FechaCreacion)
                    .IsRequired()
                    .HasColumnName("AudFechaCreacion");

                audit.Property(p => p.UsuarioCreacion)
                    .IsRequired()
                    .HasColumnName("AudUsuarioCreacion")
                    .HasMaxLength(128);

                audit.Property(p => p.FechaModificacion)
                    .HasColumnName("AudFechaModificacion");

                audit.Property(p => p.UsuarioModificacion)
                    .HasColumnName("AudUsuarioModificacion")
                    .HasMaxLength(128);

                audit.Property(p => p.FechaSincornizacion)
                    .HasColumnName("AudFechaSincornizacion");

                audit.Property(p => p.UsuarioSincronizacion)
                    .HasColumnName("AudUsuarioSincronizacion")
                    .HasMaxLength(128);
            });

            //References
            builder.HasOne(art => art.Compania)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdCompania);
            
            builder.HasOne(art => art.Empresa)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdEmpresa);

            builder.HasOne(art => art.Sucursal)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdSucursal);

            builder.HasOne(art => art.Tipo)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdTipo);

            builder.HasOne(art => art.SubTipo)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdSubTipo);

            builder.HasOne(art => art.Rubro)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdRubro);

            builder.HasOne(art => art.Categoria)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdCategoria);

            builder.HasOne(art => art.Linea)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdLinea);

            builder.HasOne(art => art.Marca)
                .WithMany(p => p.Articulos)
                .HasForeignKey(art => art.IdMarca);

            builder.HasOne(art => art.AlicuotaIva)
                .WithMany(ali => ali.Articulos)
                .HasForeignKey(art => art.IdAlicuotaIva);

            builder.HasOne(art => art.AlicuotaIvaDiferencial)
                .WithMany(ali => ali.ArticulosDiferencial)
                .HasForeignKey(art => art.IdAlicuotaIvaDiferencial);

            builder
                .HasMany<OrdenDetalleModel>(a => a.OrdenesDetalle)
                .WithOne(b => b.Articulo)
                .HasForeignKey(b => b.IdArticulo)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

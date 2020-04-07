using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class OrdenDetalleMap : IEntityTypeConfiguration<OrdenDetalleModel>
    {
        public void Configure(EntityTypeBuilder<OrdenDetalleModel> builder)
        {
            builder.ToTable("OrdenDetalle", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdOrdenDetalle");

            builder.Property(p => p.IdOrdenCabecera)
                .IsRequired();

            builder.Property(p => p.IdArticulo)
                .IsRequired();

            builder.Property(p => p.ArticuloCodigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.ArticuloDescripcion)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.ArticuloPrecio)
                .IsRequired();

            builder.Property(p => p.Cantidad)
                .IsRequired();

            //References
            builder
                .HasOne(ord => ord.OrdenCabecera)
                .WithMany(p => p.Detalles)
                .HasForeignKey(ord => ord.IdOrdenCabecera);

            builder
                .HasOne(ord => ord.Articulo)
                .WithMany(p => p.OrdenesDetalle)
                .HasForeignKey(ord => ord.IdArticulo);
        }
    }
}

using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class OrdenCabeceraMap : IEntityTypeConfiguration<OrdenCabeceraModel>
    {
        public void Configure(EntityTypeBuilder<OrdenCabeceraModel> builder)
        {
            builder.ToTable("OrdenCabecera", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdOrdenCabecera");

            builder.Property(p => p.CodTipoOrden)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.CodEstado)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.NroOC)
                .HasMaxLength(100);

            builder.Property(p => p.NroComprobante)
                .HasMaxLength(100);

            builder.Property(p => p.Ubicacion)
                .HasMaxLength(250);

            builder.Property(p => p.Observaciones)
                .HasMaxLength(1000);

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
            builder
                .HasOne(ord => ord.Compania)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(ord => ord.IdCompania);

            builder
                .HasOne(ord => ord.Empresa)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(ord => ord.IdEmpresa);

            builder
                .HasOne(ord => ord.Sucursal)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(ord => ord.IdSucursal);

            builder
                .HasOne(ord => ord.Cliente)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(ord => ord.IdCliente);

            builder
                .HasOne(ord => ord.Contacto)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(ord => ord.IdContacto);

            builder
                .HasMany<OrdenDetalleModel>(a => a.Detalles)
                .WithOne(b => b.OrdenCabecera)
                .HasForeignKey(b => b.IdOrdenCabecera)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

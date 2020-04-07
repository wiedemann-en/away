using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ProveedorMap : IEntityTypeConfiguration<ProveedorModel>
    {
        public void Configure(EntityTypeBuilder<ProveedorModel> builder)
        {
            builder.ToTable("Proveedor", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever()
                .HasColumnName("IdProveedor");

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
            //builder
            //    .HasOne<EnteModel>(prov => prov.Ente)
            //    .WithOne(p => p.Proveedor)
            //    .HasForeignKey<EnteModel>(prov => prov.Id)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(prov => prov.Compania)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(prov => prov.IdCompania);

            builder
                .HasOne(prov => prov.Empresa)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(prov => prov.IdEmpresa);

            builder
                .HasOne(prov => prov.Sucursal)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(prov => prov.IdSucursal);

            builder
                .HasOne(cli => cli.CondicionIva)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(cli => cli.IdCondicionIva);

            builder
                .HasOne(cli => cli.CondicionPago)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(cli => cli.IdCondicionPago);
        }
    }
}

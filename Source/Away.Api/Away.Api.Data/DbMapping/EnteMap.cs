using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class EnteMap : IEntityTypeConfiguration<EnteModel>
    {
        public void Configure(EntityTypeBuilder<EnteModel> builder)
        {
            builder.ToTable("Ente", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdEnte");

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.ApellidoRazonSocial)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Nombre)
                .HasMaxLength(100);

            builder.Property(p => p.IdTipoDocumento)
                .IsRequired();

            builder.Property(p => p.NroFiscal)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(p => p.TipoEnte)
                .IsRequired()
                .HasMaxLength(32);

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
                .HasOne(cli => cli.TipoDocumento)
                .WithMany(p => p.Entes)
                .HasForeignKey(cli => cli.IdTipoDocumento);

            builder
                .HasMany<EnteDomicilioModel>(a => a.Domicilios)
                .WithOne(b => b.Ente)
                .HasForeignKey(b => b.IdEnte)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany<EnteTelefonoModel>(a => a.Telefonos)
                .WithOne(b => b.Ente)
                .HasForeignKey(b => b.IdEnte)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany<ContactoModel>(a => a.Contactos)
                .WithOne(b => b.EnteRelacion)
                .HasForeignKey(b => b.IdEnteRelacion)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasMany<MovimientoCajaModel>(a => a.Movimientos)
                .WithOne(b => b.Ente)
                .HasForeignKey(b => b.IdEnte)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<ClienteModel>(ente => ente.Cliente)
                .WithOne(cli => cli.Ente)
                .HasForeignKey<ClienteModel>(cli => cli.Id);

            builder
                .HasOne<ProveedorModel>(ente => ente.Proveedor)
                .WithOne(prov => prov.Ente)
                .HasForeignKey<ProveedorModel>(prov => prov.Id);

            builder
                .HasOne<ContactoModel>(ente => ente.Contacto)
                .WithOne(cont => cont.Ente)
                .HasForeignKey<ContactoModel>(cont => cont.Id);
        }
    }
}

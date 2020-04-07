using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.ToTable("Cliente", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever()
                .HasColumnName("IdCliente");

            builder.Property(p => p.NombreFantasia)            
                .HasMaxLength(100);
            
            builder.Property(p => p.Email)
                .HasMaxLength(100);

            builder.Property(p => p.Grupo)
                .HasMaxLength(50);

            builder.Property(p => p.Zona)
                .HasMaxLength(50);

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
            //    .HasOne<EnteModel>(cli => cli.Ente)
            //    .WithOne(p => p.Cliente)
            //    .HasForeignKey<EnteModel>(cli => cli.Id)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cli => cli.Compania)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdCompania);

            builder
                .HasOne(cli => cli.Empresa)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdEmpresa);

            builder
                .HasOne(cli => cli.Sucursal)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdSucursal);

            builder
                .HasOne(cli => cli.Tipo)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdTipo);

            builder
                .HasOne(cli => cli.SubTipo)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdSubTipo);

            builder
                .HasOne(cli => cli.Rubro)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdRubro);

            builder
                .HasOne(cli => cli.Categoria)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdCategoria);

            builder
                .HasOne(cli => cli.CondicionIva)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdCondicionIva);

            builder
                .HasOne(cli => cli.CondicionPago)
                .WithMany(p => p.Clientes)
                .HasForeignKey(cli => cli.IdCondicionPago);

            builder
                .HasMany<OrdenCabeceraModel>(a => a.Ordenes)
                .WithOne(b => b.Cliente)
                .HasForeignKey(b => b.IdCliente)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class CompaniaMap : IEntityTypeConfiguration<CompaniaModel>
    {
        public void Configure(EntityTypeBuilder<CompaniaModel> builder)
        {
            builder.ToTable("Compania", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdCompania");

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Activo)
                .IsRequired();

            //Auditory
            builder.OwnsOne(p => p.Auditoria,
                audit =>
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
                .HasMany<EmpresaModel>(a => a.Empresas)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<SucursalModel>(a => a.Sucursales)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ClienteModel>(a => a.Clientes)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ProveedorModel>(a => a.Proveedores)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ArticuloModel>(a => a.Articulos)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<UsuarioModel>(a => a.Usuarios)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<OrdenCabeceraModel>(a => a.Ordenes)
                .WithOne(b => b.Compania)
                .HasForeignKey(b => b.IdCompania)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

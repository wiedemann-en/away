using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.SystemSecurity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.ToTable("Usuario", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdUsuario");

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(p => p.Usuario)
                .HasMaxLength(128);

            builder.Property(p => p.PasswordHash)
                .IsRequired();

            builder.Property(p => p.PasswordSalt)
                .IsRequired();

            builder.Property(p => p.IdRol)
                .IsRequired();

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
                .HasOne<RolModel>(a => a.Rol)
                .WithMany(b => b.Usuarios)
                .HasForeignKey(a => a.IdRol);

            builder
                .HasOne<CompaniaModel>(a => a.Compania)
                .WithMany(b => b.Usuarios)
                .HasForeignKey(a => a.IdCompania);

            builder
                .HasOne<EmpresaModel>(a => a.Empresa)
                .WithMany(b => b.Usuarios)
                .HasForeignKey(a => a.IdEmpresa);

            builder
                .HasOne<SucursalModel>(a => a.Sucursal)
                .WithMany(b => b.Usuarios)
                .HasForeignKey(a => a.IdSucursal);
        }
    }
}

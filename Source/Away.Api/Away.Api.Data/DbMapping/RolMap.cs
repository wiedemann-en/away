using Away.Api.Data.Entities.SystemSecurity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class RolMap : IEntityTypeConfiguration<RolModel>
    {
        public void Configure(EntityTypeBuilder<RolModel> builder)
        {
            builder.ToTable("Rol", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdRol");

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
                .HasMany<RolRecursoModel>(a => a.Recursos)
                .WithOne(b => b.Rol)
                .HasForeignKey(b => b.IdRol)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany<UsuarioModel>(a => a.Usuarios)
                .WithOne(b => b.Rol)
                .HasForeignKey(b => b.IdRol)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

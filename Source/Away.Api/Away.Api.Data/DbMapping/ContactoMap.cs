using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ContactoMap : IEntityTypeConfiguration<ContactoModel>
    {
        public void Configure(EntityTypeBuilder<ContactoModel> builder)
        {
            builder.ToTable("Contacto", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever()
                .HasColumnName("IdContacto");

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
            //    .HasOne<EnteModel>(cont => cont.Ente)
            //    .WithOne(p => p.Contacto)
            //    .HasForeignKey<EnteModel>(cont => cont.Id);

            builder
                .HasOne<EnteModel>(a => a.EnteRelacion)
                .WithMany(b => b.Contactos)
                .HasForeignKey(a => a.IdEnteRelacion)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<OrdenCabeceraModel>(a => a.Ordenes)
                .WithOne(b => b.Contacto)
                .HasForeignKey(b => b.IdContacto)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

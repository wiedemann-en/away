using Away.Api.Data.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class MovimientoCajaMap : IEntityTypeConfiguration<MovimientoCajaModel>
    {
        public void Configure(EntityTypeBuilder<MovimientoCajaModel> builder)
        {
            builder.ToTable("MovimientoCaja", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdMovimientoCaja");

            builder.Property(p => p.IdEnte)
                .IsRequired();

            builder.Property(p => p.TipoMovimiento)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Importe)
                .HasColumnType("decimal(18,6)")
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
                .HasOne(a => a.Ente)
                .WithMany(b => b.Movimientos)
                .HasForeignKey(a => a.IdEnte);
        }
    }
}

using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class EnteDomicilioMap : IEntityTypeConfiguration<EnteDomicilioModel>
    {
        public void Configure(EntityTypeBuilder<EnteDomicilioModel> builder)
        {
            builder.ToTable("EnteDomicilio", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdDomicilio");

            builder.Property(p => p.IdEnte)
                .IsRequired();

            builder.Property(p => p.IdTipo)
                .IsRequired();

            builder.Property(p => p.IdPais)
                .IsRequired();

            builder.Property(p => p.IdProvincia)
                .IsRequired();

            builder.Property(p => p.IdPartido)
                .IsRequired();

            builder.Property(p => p.IdLocalidad)
                .IsRequired();

            builder.Property(p => p.CodigoPostal)
                .HasMaxLength(12);

            builder.Property(p => p.Calle)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(p => p.Numero)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(p => p.Cuerpo)
                .HasMaxLength(12);

            builder.Property(p => p.Piso)
                .HasMaxLength(12);

            builder.Property(p => p.Departamento)
                .HasMaxLength(12);

            //References
            builder
                .HasOne<EnteModel>(a => a.Ente)
                .WithMany(b => b.Domicilios)
                .HasForeignKey(a => a.IdEnte);

            builder
                .HasOne<EnteDomicilioTipoModel>(a => a.Tipo)
                .WithMany(b => b.Domicilios)
                .HasForeignKey(a => a.IdTipo);

            builder
                .HasOne<LocalidadModel>(a => a.Localidad)
                .WithMany(b => b.Domicilios)
                .HasForeignKey(a => a.IdLocalidad);
        }
    }
}

using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class EnteDocumentoTipoMap : IEntityTypeConfiguration<EnteDocumentoTipoModel>
    {
        public void Configure(EntityTypeBuilder<EnteDocumentoTipoModel> builder)
        {
            builder.ToTable("EnteDocumentoTipo", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdTipo");

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Activo)
                .IsRequired();

            //References
            builder
                .HasMany<EnteModel>(a => a.Entes)
                .WithOne(b => b.TipoDocumento)
                .HasForeignKey(b => b.IdTipoDocumento)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

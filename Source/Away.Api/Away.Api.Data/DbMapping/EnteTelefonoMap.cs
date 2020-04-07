using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class EnteTelefonoMap : IEntityTypeConfiguration<EnteTelefonoModel>
    {
        public void Configure(EntityTypeBuilder<EnteTelefonoModel> builder)
        {
            builder.ToTable("EnteTelefono", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdTelefono");

            builder.Property(p => p.IdEnte)
                .IsRequired();

            builder.Property(p => p.IdTipo)
                .IsRequired();

            builder.Property(p => p.CodigoArea)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(p => p.Numero)
                .IsRequired()
                .HasMaxLength(12);

            //References
            builder
                .HasOne<EnteModel>(a => a.Ente)
                .WithMany(b => b.Telefonos)
                .HasForeignKey(a => a.IdEnte);

            builder
                .HasOne<EnteTelefonoTipoModel>(a => a.Tipo)
                .WithMany(b => b.Telefonos)
                .HasForeignKey(a => a.IdTipo);
        }
    }
}

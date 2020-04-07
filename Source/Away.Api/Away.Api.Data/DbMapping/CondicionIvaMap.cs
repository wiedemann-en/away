using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class CondicionIvaMap : IEntityTypeConfiguration<CondicionIvaModel>
    {
        public void Configure(EntityTypeBuilder<CondicionIvaModel> builder)
        {
            builder.ToTable("CondicionIva", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdCondicionIva");

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
                .HasMany<ClienteModel>(a => a.Clientes)
                .WithOne(b => b.CondicionIva)
                .HasForeignKey(b => b.IdCondicionIva)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ProveedorModel>(a => a.Proveedores)
                .WithOne(b => b.CondicionIva)
                .HasForeignKey(b => b.IdCondicionIva)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

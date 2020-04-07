using Away.Api.Data.Entities.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ClienteTipoMap : IEntityTypeConfiguration<ClienteTipoModel>
    {
        public void Configure(EntityTypeBuilder<ClienteTipoModel> builder)
        {
            builder.ToTable("ClienteTipo", "dbo");

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
                .HasMany<ClienteModel>(a => a.Clientes)
                .WithOne(b => b.Tipo)
                .HasForeignKey(b => b.IdTipo)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<ClienteSubTipoModel>(a => a.SubTipos)
                .WithOne(b => b.Tipo)
                .HasForeignKey(b => b.IdTipo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

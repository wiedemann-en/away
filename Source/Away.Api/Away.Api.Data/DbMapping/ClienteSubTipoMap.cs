using Away.Api.Data.Entities.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ClienteSubTipoMap : IEntityTypeConfiguration<ClienteSubTipoModel>
    {
        public void Configure(EntityTypeBuilder<ClienteSubTipoModel> builder)
        {
            builder.ToTable("ClienteSubTipo", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdSubTipo");

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
                .HasOne<ClienteTipoModel>(a => a.Tipo)
                .WithMany(b => b.SubTipos)
                .HasForeignKey(a => a.IdTipo);

            builder
                .HasMany<ClienteModel>(a => a.Clientes)
                .WithOne(b => b.SubTipo)
                .HasForeignKey(b => b.IdSubTipo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

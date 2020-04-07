using Away.Api.Data.Entities.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class ClienteRubroMap : IEntityTypeConfiguration<ClienteRubroModel>
    {
        public void Configure(EntityTypeBuilder<ClienteRubroModel> builder)
        {
            builder.ToTable("ClienteRubro", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdRubro");

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
                .WithOne(b => b.Rubro)
                .HasForeignKey(b => b.IdRubro)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

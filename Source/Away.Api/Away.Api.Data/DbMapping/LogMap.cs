using Away.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    internal class LogMap : IEntityTypeConfiguration<LogModel>
    {
        public void Configure(EntityTypeBuilder<LogModel> builder)
        {
            builder.ToTable("Logs", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdLog");

            builder.Property(p => p.Tipo)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(1);

            builder.Property(p => p.Origen)
                .IsRequired();

            builder.Property(p => p.Descripcion)
                .IsRequired();

            builder.Property(p => p.FechaCreacion)
                .IsRequired()
                .HasDefaultValueSql("getutcdate()");

            builder.Property(p => p.Detalle)
                .IsUnicode();

            builder.Property(p => p.StackTrace)
                .IsUnicode();

            builder.Property(p => p.Source);

            builder.Property(p => p.TargetSite);
        }
    }
}

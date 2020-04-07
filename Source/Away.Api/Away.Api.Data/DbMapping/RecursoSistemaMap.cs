using Away.Api.Data.Entities.SystemSecurity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class RecursoSistemaMap : IEntityTypeConfiguration<RecursoSistemaModel>
    {
        public void Configure(EntityTypeBuilder<RecursoSistemaModel> builder)
        {
            builder.ToTable("RecursoSistema", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdRecurso");

            builder.Property(p => p.AppState)
                .HasMaxLength(128);

            builder.Property(p => p.ApiName)
                .HasMaxLength(128);

            builder.Property(p => p.Permiso)
                .IsRequired()
                .HasMaxLength(16);

            builder.Property(p => p.Descripcion)
                .HasMaxLength(255);

            builder.Property(p => p.AppStatePadre)
                .HasMaxLength(128);

            builder.Property(p => p.RecursosDependientes)
                .HasMaxLength(128);

            //References
            builder
                .HasMany<RolRecursoModel>(a => a.RolRecursos)
                .WithOne(b => b.Recurso)
                .HasForeignKey(b => b.IdRecurso)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

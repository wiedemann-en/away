using Away.Api.Data.Entities.SystemSecurity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.DbMapping
{
    public class RolRecursoMap : IEntityTypeConfiguration<RolRecursoModel>
    {
        public void Configure(EntityTypeBuilder<RolRecursoModel> builder)
        {
            builder.ToTable("RolRecurso", "dbo");

            builder.HasKey(p => new { p.IdRol, p.IdRecurso });

            builder.Property(p => p.IdRol)
                .ValueGeneratedNever();

            builder.Property(p => p.IdRecurso)
                .ValueGeneratedNever();

            //References
            builder
                .HasOne(a => a.Rol)
                .WithMany(b => b.Recursos)
                .HasForeignKey(a => a.IdRol)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(a => a.Recurso)
                .WithMany(b => b.RolRecursos)
                .HasForeignKey(a => a.IdRecurso)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class ProjectsConfiguracion : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> entity)
        {
            entity.HasKey(e => e.ProjectId)
                    .HasName("PK__Projects__761ABEF0604DF027");

            entity.Property(e => e.DateCretae)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProjectDescription)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ProjectName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Status)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_CatStatus");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Projects_Users");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class ProjectsFilesConfiguration : IEntityTypeConfiguration<ProjectsFiles>
    {
        public void Configure(EntityTypeBuilder<ProjectsFiles> entity)
        {
            entity.HasKey(e => e.FileId)
                     .HasName("PK__Projects__6F0F98BFBE7C95EE");

            entity.Property(e => e.Active).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProjectFileName)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.RouteFile)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Project)
                .WithMany(p => p.ProjectsFiles)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectsFiles_Projects");
        }
    }
}

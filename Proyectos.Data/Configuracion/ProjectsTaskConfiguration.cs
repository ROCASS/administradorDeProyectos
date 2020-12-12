using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class ProjectsTaskConfiguration : IEntityTypeConfiguration<ProjectsTask>
    {
        public void Configure(EntityTypeBuilder<ProjectsTask> entity)
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskDateExpiration).HasColumnType("date");

            entity.Property(e => e.TaskDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Project)
                .WithMany(p => p.ProjectsTask)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectsTask_Projects");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.ProjectsTask)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_ProjectsTask_CatStatus");

            entity.HasOne(d => d.User)
                .WithMany(p => p.ProjectsTask)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectsTask_Users");
        }
    }
}

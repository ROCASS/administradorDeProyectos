using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class ProjectTaskCheckListConfiguracion : IEntityTypeConfiguration<ProjectTaskCheckList>
    {
        public void Configure(EntityTypeBuilder<ProjectTaskCheckList> entity)
        {
            entity.HasKey(e => e.CheckListId)
                   .HasName("PK__ProjectT__5631834105964D8C");

            entity.Property(e => e.Active).HasDefaultValueSql("((0))");

            entity.Property(e => e.CheckListDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CheckListStatus)
                .WithMany(p => p.ProjectTaskCheckList)
                .HasForeignKey(d => d.CheckListStatusId)
                .HasConstraintName("FK_ProjectTaskCheckList_CatStatusCheckList");

            entity.HasOne(d => d.Task)
                .WithMany(p => p.ProjectTaskCheckList)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectTaskCheckList_ProjectsTask");
        }
    }
}

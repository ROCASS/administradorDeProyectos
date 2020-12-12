using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class CatStatusCheckListConfiguracion : IEntityTypeConfiguration<CatStatusCheckList>
    {
        public void Configure(EntityTypeBuilder<CatStatusCheckList> entity)
        {
            entity.HasKey(e => e.CheckListStatusId)
                    .HasName("PK__CatStatu__E5B9BB0256153249");

            entity.Property(e => e.CheckListStatusDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}

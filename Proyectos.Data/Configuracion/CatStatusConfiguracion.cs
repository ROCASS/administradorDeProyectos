using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class CatStatusConfiguracion : IEntityTypeConfiguration<CatStatus>
    {
        public void Configure(EntityTypeBuilder<CatStatus> entity)
        {
            entity.HasKey(e => e.StatusId)
                    .HasName("PK__CatStatu__C8EE2063581B1ADC");

            entity.Property(e => e.StatusDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}

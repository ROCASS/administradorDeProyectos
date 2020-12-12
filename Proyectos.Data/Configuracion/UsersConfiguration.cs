using Microsoft.EntityFrameworkCore;
using Proyectos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectos.Data.Configuracion
{
    class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Users> entity)
        {
            entity.HasKey(e => e.UserId)
                     .HasName("PK__Users__1788CC4C44B31E04");

            entity.Property(e => e.DateCretae)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Estatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.UserEmail)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UserPassword)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);
        }
    }
}

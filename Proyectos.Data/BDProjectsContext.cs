using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Proyectos.Data.Configuracion;
using Proyectos.Models;

namespace Proyectos.Data
{
    public partial class BDProjectsContext : DbContext
    {
        public BDProjectsContext()
        {
        }

        public BDProjectsContext(DbContextOptions<BDProjectsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatStatus> CatStatus { get; set; }
        public virtual DbSet<CatStatusCheckList> CatStatusCheckList { get; set; }
        public virtual DbSet<ProjectTaskCheckList> ProjectTaskCheckList { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<ProjectsFiles> ProjectsFiles { get; set; }
        public virtual DbSet<ProjectsTask> ProjectsTask { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-F2SVF7U\\SQLEXPRESS;Initial Catalog=BDProjects;Persist Security Info=True;User ID=sa;Password=Mariana10");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CatStatusConfiguracion());

            modelBuilder.ApplyConfiguration(new CatStatusCheckListConfiguracion());

            modelBuilder.ApplyConfiguration(new ProjectTaskCheckListConfiguracion());

            modelBuilder.ApplyConfiguration(new ProjectsConfiguracion());

            modelBuilder.ApplyConfiguration(new ProjectsFilesConfiguration());


            modelBuilder.ApplyConfiguration(new ProjectsTaskConfiguration());

            modelBuilder.ApplyConfiguration(new UsersConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

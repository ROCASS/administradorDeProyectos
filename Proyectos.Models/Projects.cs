using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public class Projects
    {
        public Projects()
        {
            ProjectsFiles = new HashSet<ProjectsFiles>();
            ProjectsTask = new HashSet<ProjectsTask>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int StatusId { get; set; }
        public DateTime DateCretae { get; set; }
        public int? UserProfile { get; set; }
        public int? UserId { get; set; }

        public virtual CatStatus Status { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ProjectsFiles> ProjectsFiles { get; set; }
        public virtual ICollection<ProjectsTask> ProjectsTask { get; set; }
    }
}

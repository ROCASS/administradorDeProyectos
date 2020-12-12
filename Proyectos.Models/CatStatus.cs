using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public class CatStatus
    {
        public CatStatus()
        {
            Projects = new HashSet<Projects>();
            ProjectsTask = new HashSet<ProjectsTask>();
        }

        public int StatusId { get; set; }
        public string StatusDescription { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<ProjectsTask> ProjectsTask { get; set; }
    }
}

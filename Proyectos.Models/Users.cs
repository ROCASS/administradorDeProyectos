using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public partial class Users
    {
        public Users()
        {
            Projects = new HashSet<Projects>();
            ProjectsTask = new HashSet<ProjectsTask>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int? Estatus { get; set; }
        public DateTime DateCretae { get; set; }
        public int? UserProfile { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<ProjectsTask> ProjectsTask { get; set; }
    }
}

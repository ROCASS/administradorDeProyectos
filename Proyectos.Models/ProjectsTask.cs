using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public  class ProjectsTask
    {
        public ProjectsTask()
        {
            ProjectTaskCheckList = new HashSet<ProjectTaskCheckList>();
        }

        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime? TaskDateExpiration { get; set; }
        public int? StatusId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual CatStatus Status { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ProjectTaskCheckList> ProjectTaskCheckList { get; set; }
    }
}

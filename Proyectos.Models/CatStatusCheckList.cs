using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public class CatStatusCheckList
    {
        public CatStatusCheckList()
        {
            ProjectTaskCheckList = new HashSet<ProjectTaskCheckList>();
        }

        public int CheckListStatusId { get; set; }
        public string CheckListStatusDescription { get; set; }

        public virtual ICollection<ProjectTaskCheckList> ProjectTaskCheckList { get; set; }
    }
}

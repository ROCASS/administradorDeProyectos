using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public  class ProjectTaskCheckList
    {
        public int CheckListId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string CheckListDescription { get; set; }
        public int? CheckListStatusId { get; set; }
        public bool? Active { get; set; }

        public virtual CatStatusCheckList CheckListStatus { get; set; }
        public virtual ProjectsTask Task { get; set; }
    }
}

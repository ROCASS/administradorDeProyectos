using System;
using System.Collections.Generic;

namespace Proyectos.Models
{
    public class ProjectsFiles
    {
        public int FileId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string ProjectFileName { get; set; }
        public string RouteFile { get; set; }
        public bool? Active { get; set; }

        public virtual Projects Project { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class ProjectTask
    {
        public int ProjectId { get; set; }
        public int TaskId { get; set; }

        public virtual Project Project { get; set; }
        public virtual Task Task { get; set; }
    }
}

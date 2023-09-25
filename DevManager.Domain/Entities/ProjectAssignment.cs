using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class ProjectAssignment
    {
        public int ProjectId { get; set; }
        public int AssignmentId { get; set; }
    }
}

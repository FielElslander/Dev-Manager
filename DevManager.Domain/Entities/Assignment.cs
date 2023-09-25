using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class Assignment
    {
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; } = null!;
        public string AssignmentDescription { get; set; } = null!;
        public int ProjectId { get; set; }
        public string UserId { get; set; } = null!;
    }
}

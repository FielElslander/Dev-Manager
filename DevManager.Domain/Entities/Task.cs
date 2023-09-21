using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = null!;
        public string TaskDescription { get; set; } = null!;
        public int ProjectId { get; set; }
        public string UserId { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;
        public string ProjectDescription { get; set; } = null!;
        public string Language { get; set; } = null!;
        public int CustomerId { get; set; }
    }
}

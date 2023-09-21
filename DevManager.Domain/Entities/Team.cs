using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; } = null!;
        public string? TeamDescription { get; set; }
    }
}

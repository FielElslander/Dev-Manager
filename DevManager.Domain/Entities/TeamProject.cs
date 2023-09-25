using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class TeamProject
    {
        public int TeamId { get; set; }
        public int ProjectId { get; set; }
    }
}

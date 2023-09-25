using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class TeamUser
    {
        public int TeamId { get; set; }
        public string UserId { get; set; } = null!;
    }
}

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class TeamUser
    {
        public int TeamId { get; set; }
        public string UserId { get; set; } = null!;

        public virtual Team Team { get; set; }

        public virtual IdentityUser User { get; set; }
        
    }
}

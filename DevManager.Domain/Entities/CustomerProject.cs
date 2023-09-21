using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class CustomerProject
    {
        public int CustomerId { get; set; }
        public int ProjectId { get; set; }

        public virtual Customer Customer { get; set; } = null!;

        public virtual Project Project { get; set; } = null!;
    }
}

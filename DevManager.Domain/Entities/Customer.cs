using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Projects = new HashSet<Project>();
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
    
        public virtual ICollection<Project> Projects { get; set; }
    }
}

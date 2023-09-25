using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
    }
}

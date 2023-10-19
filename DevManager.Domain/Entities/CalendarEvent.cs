using System;
using System.Collections.Generic;

namespace DevManager.Domain.Entities
{
    public partial class CalendarEvent
    {
        public int EventId { get; set; }
        public string Subject { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string? ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}

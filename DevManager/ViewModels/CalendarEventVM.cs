namespace DevManager.ViewModels
{
    public class CalendarEventVM
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime StartDate   { get; set; }
        public DateTime EndDate { get; set; }
    }
}

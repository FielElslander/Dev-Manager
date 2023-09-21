namespace DevManager.ViewModels
{
    public class TaskVM
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
    }
}

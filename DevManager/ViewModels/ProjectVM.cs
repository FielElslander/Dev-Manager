namespace DevManager.ViewModels
{
    public class ProjectVM
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectDescription { get; set; }
        public string language { get; set; }
        public int CustomerId { get; set; }

        public IEnumerable<TaskVM> taskVMs { get; set; }
    }
}

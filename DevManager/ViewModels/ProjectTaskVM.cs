namespace DevManager.ViewModels
{
    public class ProjectTaskVM
    {
        public int ProjectId { get; set; }
        public int TaskId { get; set; }

        public ProjectVM Project { get; set; }
        public TaskVM Task { get; set; }

    }
}

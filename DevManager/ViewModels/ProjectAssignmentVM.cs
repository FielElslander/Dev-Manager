namespace DevManager.ViewModels
{
    public class ProjectAssignmentVM
    {
        public int ProjectId { get; set; }
        public int AssignmentId { get; set; }

        public ProjectVM Project { get; set; }
        public AssignmentVM Assignment { get; set; }

    }
}

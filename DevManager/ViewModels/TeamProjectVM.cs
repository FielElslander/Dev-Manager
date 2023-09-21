namespace DevManager.ViewModels
{
    public class TeamProjectVM
    {
        public int TeamId { get; set; }
        public int ProjectId { get; set; }

        public TeamVM Team { get; set; }
        public ProjectVM Project { get; set; }
    }
}

namespace DevManager.ViewModels
{
    public class TeamUserVM
    {
        public int TeamId { get; set; }
        public String UserId { get; set; }

        public TeamVM Team { get; set; }

        public UserVM user { get; set; }
    }
}

namespace DevManager.ViewModels
{
    public class CustomerProjectVM
    {
        public int CustomerId { get; set; }

        public int ProjectId { get; set; }

        public CustomerVM Customer { get; set; }
        public ProjectVM Project { get; set; }
    }
}

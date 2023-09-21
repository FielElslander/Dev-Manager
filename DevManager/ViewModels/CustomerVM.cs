namespace DevManager.ViewModels
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public IEnumerable<ProjectVM> ProjectVM {get; set;}
    }
}

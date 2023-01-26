using To_Do.ViewModels.Category;
namespace To_Do.ViewModels.Job
{
    public class JobIndexVM
    {
        public IEnumerable<JobVM> Jobs { get; set; }
        public CreateJobVM CreateJobVM { get; set; }
    }
}
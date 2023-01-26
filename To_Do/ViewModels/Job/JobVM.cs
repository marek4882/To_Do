using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Job
{
    public class JobVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public Models.Category Category { get; set; }
        public IEnumerable<Models.Category> AllCategories { get; set; }
    }
}
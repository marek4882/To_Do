using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using To_Do.ViewModels.Category;

namespace To_Do.ViewModels.Job
{
    public class CreateJobVM
    {
        [Required(ErrorMessage = "Wprowadź nazwę zadania!")]
        public string Name { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public string CategoryId { get; set; }
        [Required]
        public int ScheduleId { get; set; }
    }
}
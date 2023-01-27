using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Job
{
    public class UpdateJobVM
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę zadania!")]
        public string Name { get; set; }
        public List<SelectListItem> Categories { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string CategoryId { get; set; }
        public int ScheduleId { get; set; }
    }
}
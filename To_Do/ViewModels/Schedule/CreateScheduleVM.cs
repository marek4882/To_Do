using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Schedule
{
    public class CreateScheduleVM
    {
        [Required(ErrorMessage = "Wprowadź nazwę listy zadań!")]
        public string Name { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }
}
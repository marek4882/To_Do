using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace To_Do.ViewModels.Schedule
{
    public class UpdateScheduleVM
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę listy zadań!")]
        public string Name { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;
namespace To_Do.ViewModels.Schedule
{
    public class UpdateScheduleVM
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        public DateTime DueDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace To_Do.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}

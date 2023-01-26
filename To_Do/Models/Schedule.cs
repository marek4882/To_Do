using System.ComponentModel.DataAnnotations;
using To_Do.Areas.Identity.Data;

namespace To_Do.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
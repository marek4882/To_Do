using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Category
{
    public class UpdateCategoryVM
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Name { get; set; }
    }
}
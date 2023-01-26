using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Category
{
    public class CreateCategoryVM
    {
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Name { get; set; }
    }
}
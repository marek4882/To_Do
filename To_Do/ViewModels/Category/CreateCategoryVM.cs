using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Category
{
    public class CreateCategoryVM
    {
        [Required(ErrorMessage = "Wprowadź nazwę kategorii!")]
        public string Name { get; set; }
    }
}
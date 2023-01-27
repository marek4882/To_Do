using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace To_Do.ViewModels.Category
{
    public class UpdateCategoryVM
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwę kategorii!")]
        public string Name { get; set; }
    }
}
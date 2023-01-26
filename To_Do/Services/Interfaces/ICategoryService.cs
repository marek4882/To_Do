using To_Do.Models;
using To_Do.ViewModels.Category;

namespace To_Do.Services.Interfaces
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryVM> GetCategories();
        public bool CreateCategory(string name);
        public bool UpdateCategory(Category category);
        public Category GetCategoryById(int id);
        public void DeleteCategory(int id);
    }
}

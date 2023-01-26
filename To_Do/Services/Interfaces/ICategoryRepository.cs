using To_Do.Models;

namespace To_Do.Services.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public void CreateCategory(Category category);
        public bool CategoryExists(string name);
        public Category GetCategoryById(int id);
        public void UpdateCategory(Category category);
        public void DeleteCategory(int id);
    }
}
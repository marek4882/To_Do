using To_Do.Models;
using To_Do.Repositories;
using To_Do.Services.Interfaces;
using To_Do.ViewModels.Category;

namespace To_Do.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public bool CreateCategory(string name)
        {
            var exists = _categoryRepository.CategoryExists(name);
            if (!exists)
            {
                var category = new Category() { Name = name };
                _categoryRepository.CreateCategory(category);
                return true;
            }
            return false;
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public IEnumerable<CategoryVM> GetCategories()
        {
            var categories = _categoryRepository.GetCategories().Select(x => new CategoryVM()
            {
                Name = x.Name,
                Id = x.Id,
            });

            return categories;
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }

        public bool UpdateCategory(Category category)
        {
            var exists = _categoryRepository.CategoryExists(category.Name);
            if (!exists)
            {
                _categoryRepository.UpdateCategory(category);
                return true;
            }
            return false;
        }
    }
}
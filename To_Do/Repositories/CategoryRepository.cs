using To_Do.Data;
using To_Do.Models;
using To_Do.Services.Interfaces;

namespace To_Do.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Where(_ => true);
        }

        public bool CategoryExists(string name)
        {
            return _context.Categories.Any(x => x.Name == name);
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
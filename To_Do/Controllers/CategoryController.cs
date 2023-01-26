using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using To_Do.Services.Interfaces;
using To_Do.ViewModels.Category;

namespace To_Do.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetCategories();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryVM request)
        {
            if (ModelState.IsValid)
            {
                var result = _categoryService.CreateCategory(request.Name);
                if (!result)
                {
                    ModelState.AddModelError("Name", "Kategoria o takiej nazwie już istnieje");
                    return View();
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int categoryId)
        {
            var category = _categoryService.GetCategoryById(categoryId);
            var model = new UpdateCategoryVM() { Id = category.Id, Name = category.Name };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UpdateCategoryVM request)
        {
            if (ModelState.IsValid)
            {
                var category = _categoryService.GetCategoryById(request.Id);
                category.Name = request.Name;
                var result = _categoryService.UpdateCategory(category);
                if (!result)
                {
                    ModelState.AddModelError("Name", "Kategoria o takiej nazwie już istnieje");
                    return View();
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int categoryId)
        {
            _categoryService.DeleteCategory(categoryId);
            return RedirectToAction("Index");
        }
    }
}

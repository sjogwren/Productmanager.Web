using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Smartproduct.Interface.Category;
using Smartproduct.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartproduct.Web.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {

        Category category = new Category();
        private readonly ICategory _categoryRouter;
        public CategoryController(ICategory categoryRouter)
        {
            _categoryRouter = categoryRouter;
        }

        [HttpGet]
        public async Task<IActionResult> Currentcategories()
        {
            return View(await _categoryRouter.GetAllCategories());
        }

        [HttpGet]
        public IActionResult Newcategory()
        {
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Newcategory(Category category)
        {
            var check1 = await _categoryRouter.DuplicateCategory(category.Name);
            var check2 = await _categoryRouter.CheckIfCategoryCodeExist(category.CategoryCode);

            do
            {
                if(check1 || check2)
                {
                    if (check1)
                    {
                        category.Errormessage1 = $"Category name chosen";
                    }
                    if (check2)
                    {
                        category.Errormessage3 = $"Category code chosen";
                    }
                    if (!CategoryValidator.IsValidCategoryCode(category.CategoryCode))
                    {
                        category.Errormessage2 = $"Format: ABC###      E.g      ABC123";
                    }
                    return View(category);
                }
                else
                {
                    category.CreatedBy = User.Identity.Name;
                    var result = await _categoryRouter.Post(category);
                    return RedirectToAction("Currentcategories");
                }
            }
            while (check1 == false && check2 == false);
        }

        [HttpGet]
        public async Task<IActionResult> Editcategory(int CategoryId)
        {
            category = await _categoryRouter.GetCategoryById(CategoryId);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Editcategory(Category category)
        {
            category.CreatedBy = User.Identity.Name;
            var result = await _categoryRouter.Put(category);
            return RedirectToAction("Currentcategories");
        }
    }
}

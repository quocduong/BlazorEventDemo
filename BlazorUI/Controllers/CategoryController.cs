using BlazorUI.Models.Category;
using Microsoft.AspNetCore.Mvc;

namespace BlazorUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> CreateOrEditModal(Guid? id)
        {
            return PartialView("_Partials/_CreateOrEdit", new CreateOrEditCategoryModalViewModel());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminCategoryController : Controller
    {
        TasteContext context=new TasteContext();
        public ActionResult CategoryList()
        {
            var values=context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public ActionResult DeleteCategory(int id)
        {

            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = context.Categories.Find(category.CategoryId);
            value.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        
    }
}

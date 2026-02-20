using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;
namespace TasteFoodIt.Controllers
{
    public class AdminChefController : Controller
    {
       private readonly TasteContext _context;

       public AdminChefController(TasteContext context)
       {
           _context = context;
       }

       public ActionResult ChefList()
        {
            var value=_context.Chefs.ToList();
            
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateChef()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateChef(Chef chef)
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return RedirectToAction("ChefList");
        }

        [HttpGet]
        public ActionResult UpdateChef(int id)
        {
            var chef = _context.Chefs.Find(id);
            return View(chef);
        }

        [HttpPost]
        public ActionResult UpdateChef(Chef chef)
        {
            var value = _context.Chefs.Find(chef.ChefId);
            if (value==null) return NotFound();
            value.Description = chef.Description;
            value.Title = chef.Title;
            value.ImageUrl = chef.ImageUrl;
            value.NameSurname = chef.NameSurname;
            _context.SaveChanges();
            return RedirectToAction("ChefList");
            
        }

        [HttpPost]
        public ActionResult DeleteChef(int id)
        {
            var chef = _context.Chefs.Find(id);
            if (chef==null) return NotFound();
            _context.Chefs.Remove(chef);
            _context.SaveChanges();
            return RedirectToAction("ChefList");
        }

    }
}

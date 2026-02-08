using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminAboutController : Controller
    {
      private readonly TasteContext _context;

      public AdminAboutController(TasteContext context)
      {
          _context = context;
      }

      [HttpGet]
      public ActionResult AboutList()
        {
            var value=_context.Abouts.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpPost]

        public ActionResult DeleteAbout(int id)
        {
            var about = _context.Abouts.Find(id);
            _context.Abouts.Remove(about);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = _context.Abouts.Find(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value=_context.Abouts.Find(about.AboutId);
            value.Title = about.Title;
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminTestimonialsController : Controller
    {
        private readonly TasteContext _context;

        public AdminTestimonialsController(TasteContext context)
        {
            _context = context;
        }

        public ActionResult TestimonialsList()
        {
            var value= _context.Testimonials.ToList();
            
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateTestimonials()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonials(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialsList");
        }

        [HttpGet]
        public ActionResult UpdateTestimonials(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            return View(testimonial);
        }

        [HttpPost]
        public ActionResult UpdateTestimonials(Testimonial testimonial)
        {
            var value=_context.Testimonials.Find(testimonial.TestimonialId);
            value.NameSurname = testimonial.NameSurname;
            value.Description = testimonial.Description;
            value.ImageUrl = testimonial.ImageUrl;
            value.Title= testimonial.Title;
            _context.SaveChanges();
            return RedirectToAction("TestimonialsList");
        }

        [HttpPost]
        public ActionResult DeleteTestimonials(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialsList");
        }

    }
}

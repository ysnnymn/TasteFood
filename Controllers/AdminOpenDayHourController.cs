using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminOpenDayHourController : Controller
    {

        private readonly TasteContext _context;

        public AdminOpenDayHourController(TasteContext context)
        {
            _context = context;
        } 
        [HttpGet]

        public ActionResult OpenDayHourList()
        {
            var value= _context.OpenDayHours.ToList();
            
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateOpenDayHour()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateOpenDayHour(OpenDayHour openDayHour)
        {
            _context.OpenDayHours.Add(openDayHour);
            _context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }

        [HttpGet]
        public ActionResult UpdateOpenDayHour(int id)
        {
            var value = _context.OpenDayHours.Find(id);
         
              return View(value);
                
            
        }

        [HttpPost]
        public ActionResult UpdateOpenDayHour(OpenDayHour openDayHour)
        {
            var value = _context.OpenDayHours.Find(openDayHour.OpenDayHourId);
            if (value==null)
                return NotFound();
            value.DayName = openDayHour.DayName;
            value.OpenHourRange = openDayHour.OpenHourRange;
            _context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
            
        }

        [HttpPost]
        public ActionResult DeleteOpenDayHour(int id)
        {
            var value = _context.OpenDayHours.Find(id);
            if(value==null)
                return NotFound();
            _context.OpenDayHours.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }
        

    }
}
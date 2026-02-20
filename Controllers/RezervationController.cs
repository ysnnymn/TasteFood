using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class RezervationController : Controller
    {
        private readonly TasteContext _context;

        public RezervationController(TasteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Index()
        {
           
          
            return View();
        }
        
        [HttpPost]
        public ActionResult CreateRezervation(Reservation rezervation)
        {
         
            rezervation.ReservationStatus ="0";
        
            _context.Reservations.Add(rezervation);
            _context.SaveChanges();
            TempData["Success"] = "Rezervasyon Oluşturuludu.";
            return RedirectToAction("Index");
        }

    }
}

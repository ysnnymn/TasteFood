using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminReservationController : Controller
    { 
        private readonly TasteContext _context;

        public AdminReservationController(TasteContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult ReservationList(int page = 1)
        {
            
            int pageSize = 10;
            int totalReservation=_context.Reservations.Count();
            int totalPages = (int)Math.Ceiling((double)totalReservation / pageSize);
            if(page<1) page = 1;
            if (page > totalPages && totalPages > 0) return RedirectToAction("ReservationList", new { page = totalPages });
            
            var values=_context.Reservations
                .OrderBy(p=>p.ReservationId)
                .Skip((page-1)*pageSize)
                .Take(pageSize)
                .ToList();
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            
            return View(values);
        }

        [HttpPost]
        public ActionResult MarkIsRead(int id)
        {
            var reservation = _context.Reservations.Find(id);
            if (reservation==null)
                return NotFound();
           reservation.ReservationStatus = "Aktif";
           _context.SaveChanges();
           return RedirectToAction("ReservationList");
        }

        [HttpPost]
        public ActionResult DeleteReservation(int id)
        {
            var reservation = _context.Reservations.Find(id);
            if (reservation != null)
            {
                reservation.ReservationStatus = "İptal Edildi";
                _context.SaveChanges();
            }
            
            return RedirectToAction("ReservationList");
        }

        [HttpGet]
        public ActionResult UpdateReservation(int id)
        {
            var reservation = _context.Reservations.Find(id);
            if (reservation == null)
                return NotFound();
            return View (reservation);
        }

        [HttpPost]
        public ActionResult UpdateReservation(Reservation reservation)
        {
            var value=_context.Reservations.Find(reservation.ReservationId);
            if (value != null)
            {
                value.Email=reservation.Email;
                
                value.Phone=reservation.Phone;
                value.Name = reservation.Name;
                value.Time = reservation.Time;
                value.ReservationDate=reservation.ReservationDate;
                value.GuestCount=reservation.GuestCount;
                _context.SaveChanges();
                
            }
            return RedirectToAction("ReservationList");
        }

    }
}
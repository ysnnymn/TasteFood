using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminAddressController : Controller
    {
       private readonly TasteContext _context;

       public AdminAddressController(TasteContext context)
       {
           _context = context;
       }

       [HttpGet]
       public ActionResult AddressList()
        {
            var value=_context.Addresses.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateAddress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return RedirectToAction("AddressList");
        }

        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var value=_context.Addresses.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAddress(Address address)
        {
            var value=_context.Addresses.Find(address.AddressId);
            if (value==null)
                return NotFound();
            
            value.Description = address.Description;
            value.Email=address.Email;
            value.Phone=address.Phone;
            _context.SaveChanges();
            return RedirectToAction("AddressList");
        }

        [HttpPost]
        public ActionResult DeleteAddress(int id)
        {
            var value=_context.Addresses.Find(id);
            if (value==null)
                return NotFound();
            _context.Addresses.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("AddressList");
        }

    }
}

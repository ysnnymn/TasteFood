using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class ContactController : Controller
    {
        private readonly TasteContext _context;

        public ContactController(TasteContext context)
        {
            _context = context;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            var value=_context.Contacts.ToList();
            return View(value);
        }

       

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            contact.SendDate = DateTime.Now;

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            TempData["Success"] = "Mesajınız başarıyla gönderildi!";
            return RedirectToAction("Index");
        }

    }
}
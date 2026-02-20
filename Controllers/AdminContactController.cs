using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly TasteContext _context;

        public AdminContactController(TasteContext context)
        {
            _context = context;
        }

      [HttpGet]
        public ActionResult ContactList()
        {
            var value = _context.Contacts
                .OrderByDescending(x => x.SendDate).ToList();
            return View(value);
        }

        [HttpPost]
        public ActionResult DeleteContact(int id)
        {
            var contact = _context.Contacts.Find(id);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpPost]
        public ActionResult MarkIsRead(int id)
        {
            var contact = _context.Contacts.Find(id);
            if(contact==null)
                return NotFound();
            contact.IsRead = true;
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }

    }
}

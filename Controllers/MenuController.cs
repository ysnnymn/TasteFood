using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.Controllers
{
    public class MenuController : Controller
    {
        // GET: MenuController
        public ActionResult Index()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.Controllers
{
    public class Dashboard : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

    }
}

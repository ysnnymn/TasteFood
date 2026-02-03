using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class DefaultController : Controller
    {
   
        public ActionResult Index()
        {
            return View();
        }

      
        

    }
}

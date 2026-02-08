using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.Controllers
{
    public class ErrorPageController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Handle(int statusCode)
        {
            return statusCode switch
            {
                404 => View("Page404"),
                405 => View("Page405"),
                500 => View("Page500"),
                _   => View("Page500") // default
            };
        }
    }
}
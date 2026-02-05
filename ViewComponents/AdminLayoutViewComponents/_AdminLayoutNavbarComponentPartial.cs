using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutNavbarComponentPartial:ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
}
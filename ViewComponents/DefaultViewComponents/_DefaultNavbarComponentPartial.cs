using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultNavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
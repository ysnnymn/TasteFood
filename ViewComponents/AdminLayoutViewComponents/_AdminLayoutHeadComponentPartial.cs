using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutHeadComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
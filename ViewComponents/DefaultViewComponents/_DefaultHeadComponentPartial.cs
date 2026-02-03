using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultHeadComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
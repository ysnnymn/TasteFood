using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultFooterComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
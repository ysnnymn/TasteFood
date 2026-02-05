using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutScriptComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutSidebarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
        
    }
    
}
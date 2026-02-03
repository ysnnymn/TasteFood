using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultSliderComponentPartial:ViewComponent
{
    
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
using Microsoft.AspNetCore.Mvc;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultPerfectIngredientsComponentPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}
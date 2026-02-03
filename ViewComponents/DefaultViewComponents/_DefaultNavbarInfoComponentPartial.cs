using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultNavbarInfoComponentPartial:ViewComponent
{
    TasteContext context=new TasteContext();

    public IViewComponentResult Invoke()
    {
        ViewBag.phone = context.Addresses.Select(x => x.Phone).FirstOrDefault();
        ViewBag.email = context.Addresses.Select(x => x.Email).FirstOrDefault();
        ViewBag.description = context.Addresses.Select(x => x.Description).FirstOrDefault();
        return View();
    }
    
}
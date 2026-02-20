using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutNavbarComponentPartial:ViewComponent
{
    private readonly TasteContext _context;

    public _AdminLayoutNavbarComponentPartial(TasteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        ViewBag.noticationIsReadByFalseCount=_context.Notifications.Where(x=>x.IsRead==false).Count();
        var values=_context.Notifications.Where(x=>x.IsRead==false).ToList();
        return View(values);
    }

  

}
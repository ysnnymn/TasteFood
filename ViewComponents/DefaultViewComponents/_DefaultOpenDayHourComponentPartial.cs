using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultOpenDayHourComponentPartial:ViewComponent
{
    private readonly TasteContext _context;

    public _DefaultOpenDayHourComponentPartial(TasteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var openDayHour = _context.OpenDayHours.ToList();
        return View(openDayHour);
    }
}
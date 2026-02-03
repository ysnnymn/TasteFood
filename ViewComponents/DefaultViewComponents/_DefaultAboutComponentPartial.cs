using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using TasteFoodIt.Context;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultAboutComponentPartial:ViewComponent
{
private readonly TasteContext _context;

public _DefaultAboutComponentPartial(TasteContext context)
{
    _context = context;
}

public IViewComponentResult Invoke()
{
    var about = _context.Abouts.FirstOrDefault();
        return View(about);
    }
    
}
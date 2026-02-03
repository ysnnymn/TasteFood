using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using TasteFoodIt.Context;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultChefComponentPartial:ViewComponent
{
    private readonly TasteContext _context;

    public _DefaultChefComponentPartial(TasteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var chef = _context.Chefs.ToList();
        return View(chef);
    }
}
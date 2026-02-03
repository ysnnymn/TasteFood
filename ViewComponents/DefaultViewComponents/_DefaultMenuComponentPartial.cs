using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteFoodIt.Context;
using TasteFoodIt.EntitiesExtensions;


namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultMenuComponentPartial:ViewComponent
{
    private readonly TasteContext _context;

    public _DefaultMenuComponentPartial(TasteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var products = _context.GetAllProducts();
        return View(products);
    }
}
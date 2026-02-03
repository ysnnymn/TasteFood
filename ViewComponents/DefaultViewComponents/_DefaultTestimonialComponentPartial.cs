using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.ViewComponents.DefaultViewComponents;

public class _DefaultTestimonialComponentPartial:ViewComponent
{
    private readonly TasteContext _context;

    public _DefaultTestimonialComponentPartial(TasteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var testimoial=_context.Testimonials.ToList();
        return View(testimoial);
    }
}
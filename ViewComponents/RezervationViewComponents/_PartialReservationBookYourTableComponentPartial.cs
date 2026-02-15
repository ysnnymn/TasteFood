using Microsoft.AspNetCore.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.ViewComponents.RezervationViewComponents;

public class _PartialReservationBookYourTableComponentPartial:ViewComponent
{
  

    public IViewComponentResult Invoke()
    {
       
        return View();
    }
}
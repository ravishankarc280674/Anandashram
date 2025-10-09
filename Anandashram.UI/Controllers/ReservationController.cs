using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

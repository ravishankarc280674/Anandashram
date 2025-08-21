using System.Diagnostics;
//using Anandashram.Models;
using Microsoft.AspNetCore.Mvc;
using static Anandashram.Controllers.DevoteeController;

namespace Anandashram.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ILogger<ReservationController> _logger;

        public ReservationController(ILogger<ReservationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public IActionResult ReservationSummary()
        {
            return View();
        }
    }
}

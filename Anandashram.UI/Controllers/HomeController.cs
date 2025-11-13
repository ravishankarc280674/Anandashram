using Anandashram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace Anandashram.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new DashboardVM
            {

                //TotalDevotees = _context.Devotees.Count(),
                //TotalRooms = _context.Rooms.Count(),
                //AvailableRooms = _context.Rooms.Count(r => r.IsAvailable),
                //TodayCheckIns = _context.Bookings.Count(b => b.CheckInDate == DateTime.Today),
                //TodayCheckOuts = _context.Bookings.Count(b => b.CheckOutDate == DateTime.Today),

                TotalDevotees = 2121,
                TotalRooms = 280,
                AvailableRooms = 114,
                TodayCheckIns = 22,
                TodayCheckOuts =16,
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

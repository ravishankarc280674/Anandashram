using Anandashram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace Anandashram.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHome _homeRepo;
        public HomeController(ILogger<HomeController> logger, IHome homeRepo)
        {
            _homeRepo = homeRepo;
            _logger = logger;
        }

        public async  Task<IActionResult> Index()
        {
            var model = await _homeRepo.GetHomeDataAsync();
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

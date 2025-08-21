using System.Diagnostics;
using Anandashram.DAL.Interface;

//using Anandashram.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class DevoteeController : Controller
    {
        private readonly ILogger<DevoteeController> _logger;
        IDevoteeDAO _devotee;
        const int PAGESIZE = 10;

        public DevoteeController(ILogger<DevoteeController> logger, IDevoteeDAO devotee)
        {
            _logger = logger;
            _devotee = devotee;
        }

        public IActionResult DevoteeList()
        {
            return View();
        }

        public IActionResult Devotee()
        {
            return View();
        }

       

    }
}

using Anandashram.Interfaces.Repository;
using System.Diagnostics;

namespace Anandashram.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHome _homeRepo;
    public HomeController(ILogger<HomeController> logger, IHome homeRepo)
    {
        _homeRepo = homeRepo;
        _logger = logger;
    }
   
    public IActionResult Index()
    {
        var model = _homeRepo.GetHomeData();
        model.ChartDTO = _homeRepo.GetDashBoardChartForCheckInCheckOut();
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

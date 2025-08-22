using Anandashram.BAL.Interface;
using Anandashram.DAL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class DevoteeCategoryController : Controller
    {
        private readonly ILogger<DevoteeCategoryController> _logger;
        private readonly IDevoteeBO _devotee;
        const int PAGESIZE = 10;

        public DevoteeCategoryController(ILogger<DevoteeCategoryController> logger, IDevoteeBO devotee)
        {
            _logger = logger;
            _devotee = devotee;
        }
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchText, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchText;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) || sortOrder.Equals("Name") ? "name_desc" : "";

            ViewData["CurrentFilter"] = searchText;
            ViewData["CurrentSort"] = sortOrder;

            return View(await _devotee.GetDevoteeCategoryList(sortOrder, currentFilter, searchText, pageNumber, PAGESIZE));
        }

    }
}

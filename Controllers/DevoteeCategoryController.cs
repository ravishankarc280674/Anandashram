using Anandashram.BAL.Interface;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Linq;
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
            return  View(await FilterData(sortOrder, currentFilter, searchText, pageNumber,PAGESIZE));
        }

        private async Task<PaginatedList<DevoteeCategory>> FilterData(string sortOrder, string currentFilter, string searchText, int? pageNumber,int pageSize)
        {
            if (searchText != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchText = currentFilter;
            }
            var devoteeCategoryList = (await  _devotee.GetDevoteeCategoryList()).AsQueryable<DevoteeCategory>();
            if (!String.IsNullOrEmpty(searchText))
            {
              devoteeCategoryList = devoteeCategoryList.Where(s => s.Name.ToLower().Contains(searchText.ToLower()));
            }
            devoteeCategoryList = sortOrder switch
            {
                "name_desc" => devoteeCategoryList.OrderByDescending(s => s.Name),
                _ => devoteeCategoryList.OrderBy(s => s.Name),
            };
            return await PaginatedList<DevoteeCategory>.CreateAsync(devoteeCategoryList.AsQueryable<DevoteeCategory>(), pageNumber ?? 1, pageSize);
        }

        public async Task<IActionResult> UpdateDevoteeCategory(int Id, string Name)
        {
            return View(await _devotee.UpdateDevoteeCategory(Id, Name));
        }
    }
}
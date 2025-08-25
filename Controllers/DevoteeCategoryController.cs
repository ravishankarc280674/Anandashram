using Anandashram.BAL.Interface;
using Anandashram.Core.Models;
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
       // public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchText, int? pageNumber)
       public IActionResult Index(string sortExpression="")
        {
            SortModel sortModel = new SortModel();//ApplySort(sortExpression);
            sortModel.AddColumn("name");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;

            var devoteeCategoryList = _devotee.GetDevoteeCategoryList(sortModel);
            return View(devoteeCategoryList);
        }

        

        //private async Task<PaginatedList<DevoteeCategory>> FilterData(string sortOrder, string currentFilter, string searchText, int? pageNumber,int pageSize)
        //{
        //    if (searchText != null)
        //    {
        //        pageNumber = 1;
        //    }
        //    else
        //    {
        //        searchText = currentFilter;
        //    }
        //    var devoteeCategoryList = (await  _devotee.GetDevoteeCategoryList(sortProperty, sortOrder)).AsQueryable<DevoteeCategory>();
        //    if (!String.IsNullOrEmpty(searchText))
        //    {
        //      devoteeCategoryList = devoteeCategoryList.Where(s => s.Name.ToLower().Contains(searchText.ToLower()));
        //    }
        //    devoteeCategoryList = sortOrder switch
        //    {
        //        "name_desc" => devoteeCategoryList.OrderByDescending(s => s.Name),
        //        _ => devoteeCategoryList.OrderBy(s => s.Name),
        //    };
        //    return await PaginatedList<DevoteeCategory>.CreateAsync(devoteeCategoryList.AsQueryable<DevoteeCategory>(), pageNumber ?? 1, pageSize);
        //}

        //public async Task<IActionResult> UpdateDevoteeCategory(int Id, string Name)
        //{
        //    return View(await _devotee.UpdateDevoteeCategory(Id, Name));
        //}
    }
}
using Anandashram.DAL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class InfrastructureController : Controller
    {
        private readonly ILogger<InfrastructureController> _logger;
        IInfraStructureDAO infraStructure;
        const int PAGESIZE = 10;

        public InfrastructureController(ILogger<InfrastructureController> logger, IInfraStructureDAO infrastructure)
        {
            _logger = logger;
            infraStructure = infrastructure;
        }


        //public async Task<IActionResult> BuildingList(string sortOrder, string currentFilter, string searchText, int? pageNumber)
        //{
        //    ViewData["CurrentFilter"] = searchText;
        //    ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) || sortOrder.Equals("Name") ? "name_desc" : "";

        //    ViewData["CurrentFilter"] = searchText;
        //    ViewData["CurrentSort"] = sortOrder;

        //    return View(await infraStructure.GetBuildingList(sortOrder, currentFilter, searchText, pageNumber, PAGESIZE));
        //}

        public IActionResult FloorList()
        {
            return View();
        }
        public IActionResult RoomList()
        {
            return View();
        }
        public IActionResult BlockList()
        {
            return View();
        }
        public IActionResult RoomTypeList()
        {
            return View();
        }
    }
}

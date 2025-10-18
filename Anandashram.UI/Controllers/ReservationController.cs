using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class ReservationController : Controller
    {
        // GET: ReservationController
        private readonly IRoom _roomRepo;
        private readonly IBlock _blockrepo;
        private readonly IBuilding _buildingrepo;
        private readonly IFloor _floorrepo;

        public ReservationController(IRoom roomRepo, IBlock blockrepo, IBuilding buildingrepo, IFloor floorrepo)
        {
            // _context = context;
            _roomRepo = roomRepo;
            _blockrepo = blockrepo;
            _buildingrepo = buildingrepo;
            _floorrepo = floorrepo;
        }

        // GET: Room
        public async Task<IActionResult> ReservationSummary(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000, string view = "Grid")
        {
            if (pg < 1) pg = 1;

            SortModel sortModel = new SortModel();//ApplySort(sortExpression);
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = PageSize;
            ViewBag.SearchText = SearchText;
            ViewBag.view = view;
            TempData["CurrentPage"] = pg;
            var RoomList = await _roomRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(RoomList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Room", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            pager.ViewType = view;
            this.ViewBag.Pager = pager;
            return View(RoomList);
        }
    }
}

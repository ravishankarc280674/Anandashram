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
        private readonly IReservation _reservationrepo;

        public ReservationController(IRoom roomRepo, IBlock blockrepo, IBuilding buildingrepo, IFloor floorrepo,IReservation reservationrepo)
        {
            _roomRepo = roomRepo;
            _blockrepo = blockrepo;
            _buildingrepo = buildingrepo;
            _floorrepo = floorrepo;
            _reservationrepo = reservationrepo;
        }

        // GET: Room
        public async Task<IActionResult> ReservationSummary(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000, string view = "Grid")
        {
           
            return View();
        }

        public async Task<IActionResult> ReservationList(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000, string view = "Grid")
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
            List<Room> ReservationList = await _roomRepo.GeRoomReservations(sortModel.SortedProperty, sortModel.SortedOrder, SearchText);

            //var pager = new PageModel(RoomList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Room", SearchText = SearchText };
            //pager.SortExpression = sortExpression;
            //pager.ViewType = view;
            //this.ViewBag.Pager = pager;
            //return View(RoomList);
            return View(ReservationList);
        }
    }
}


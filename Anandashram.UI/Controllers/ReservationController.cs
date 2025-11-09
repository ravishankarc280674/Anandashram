using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> ReservationSummary(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000)
        {
           
            return View();
        }

        public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("buildingname");
            sortModel.AddColumn("blockname");
            sortModel.AddColumn("floorname");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.SearchText = SearchText;
            List<Room> ReservationList = await _roomRepo.GeRoomReservations(sortModel.SortedProperty, sortModel.SortedOrder, SearchText);
            return View(ReservationList);
        }
    }
}


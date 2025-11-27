using Anandashram.Interfaces.Repository;

namespace Anandashram.Controllers;
[Authorize]
public class ReservationController : Controller
{
    // GET: ReservationController
    private readonly IRoomService _roomService;

    public ReservationController(IRoomService roomService)
    {
        _roomService = roomService;
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
        ViewBag.ReportType = "Reservation";
       
        List<Room> ReservationList = await _roomService.GeRoomReservations(sortModel.SortedProperty, sortModel.SortedOrder, SearchText);
        var pager = new PageModel(ReservationList.Count, pg, PageSize) { Action = "Index", Controller = "Reservation", SearchText = SearchText };
        pager.SortExpression = sortExpression;
        pager.ControllerName = "Reservation";
        this.ViewBag.Pager = pager;
        return View(ReservationList);
    }
}


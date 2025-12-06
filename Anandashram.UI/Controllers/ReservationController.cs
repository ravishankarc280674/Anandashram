namespace Anandashram.Controllers;
[Authorize]
public class ReservationController : Controller
{
    // GET: ReservationController
    private readonly IRoomService _roomService;
    private readonly IReservationService _reservationService;

    public ReservationController(IRoomService roomService, IReservationService reservationService)
    {
        _roomService = roomService;
        _reservationService = reservationService;
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
    public async Task<ReservationExtendDTO> GetReservationData(int id)
    {
        return await _reservationService.GetReservationDataAsync(id);
    }
    [HttpPost]
    public async Task<IActionResult> ExtendReservation(int reservationId, int newRoomId, DateTime newToDate)
    {
        try
        {
            await _reservationService.ExtendReservationAsync(reservationId, newRoomId, newToDate);
            return Ok(); // <--- REQUIRED for $.post(...).done()
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    public IActionResult ReservationTimeline()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetTimelineData(DateTime startDate, DateTime endDate)
    {
        var data = await _reservationService.GetReservationsForChart(startDate, endDate);
        return Json(data);
    }

}


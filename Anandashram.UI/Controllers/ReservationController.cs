using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Threading.Tasks;

namespace Anandashram.Controllers;
[Authorize]
public class ReservationController : Controller
{
    // GET: ReservationController
    private readonly IRoomService _roomService;
    private readonly IBuildingService _buildingService;
    private readonly IReservationService _reservationService;

    public ReservationController(IRoomService roomService, IReservationService reservationService, IBuildingService buildingService)
    {
        _roomService = roomService;
        _reservationService = reservationService;
        _buildingService= buildingService;
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
    public async Task<List<Building>> GetBuildings()
    {
        return (await _buildingService.GetBuildings()).ToList();
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
    [HttpPost]
    public async Task<IActionResult> PartialExtendReservation(int reservationId, int newRoomId, DateTime newToDate, int newAllocated)
    {
        try
        {
            await _reservationService.PartialReservationAsync(reservationId, newRoomId, newToDate, newAllocated);
            return Ok(); // <--- REQUIRED for $.post(...).done()
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    public async Task<IActionResult> ReservationTimeline()
    {
        ViewBag.Buildings = await GetBuildings();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetTimelineData(DateTime startDate, DateTime endDate, List<int> buildings)
    {
        var data = await _reservationService.GetReservationsForChart(startDate, endDate, buildings);
        return Json(data);
    }
   
    public async Task<IActionResult> ExportTimelineExcel(DateTime startDate, DateTime endDate, List<int> buildings)
    {
        var list = await _reservationService.GetReservationsForChart(startDate, endDate, buildings);

        using var stream = new MemoryStream();
        using (var spreadsheet = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
        {
            var workbookPart = spreadsheet.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Sheets sheets = spreadsheet.WorkbookPart.Workbook.AppendChild(new Sheets());
            Sheet sheet = new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Timeline" };
            sheets.Append(sheet);

            SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

            // Header
            Row headerRow = new Row();
            headerRow.Append(
                CreateCell("Room"),
                CreateCell("Devotee"),
                CreateCell("Code"),
                CreateCell("Allocated"),
                CreateCell("From"),
                CreateCell("To")
            );
            sheetData.Append(headerRow);

            foreach (var r in list)
            {
                Row row = new Row();
                row.Append(
                    CreateCell(r.RoomName),
                    CreateCell(r.DevoteeName),
                    CreateCell(r.DevoteeCode),
                    CreateCell(r.Allocated.ToString()),
                    CreateCell(r.FromDate.ToString("dd-MM-yyyy")),
                    CreateCell(r.ToDate.ToString("dd-MM-yyyy"))
                );
                sheetData.Append(row);
            }
        }

        return File(stream.ToArray(),
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "ReservationTimeline.xlsx");
    }
    private Cell CreateCell(string text) =>
        new Cell(new CellValue(text)) { DataType = CellValues.String };
    public IActionResult CloseReservations()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> AutoCloseReservation(DateTime dateValue)
    {
        // ✅ Validation (server-side safety)
        if (dateValue.Date > DateTime.Today.AddDays(-1))
            return BadRequest("Invalid date");
        await _reservationService.AutoCloseReservation(dateValue);



        return Ok();
    }

    public async Task<IActionResult> ReservationReport()
    {
        ViewBag.ReportType = "ReservationReport";
        ViewBag.Rooms =await _roomService.GetAllRooms();
        return View();
    }


}


using Anandashram.Reports;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System.Threading.Tasks;

namespace Anandashram.Controllers;
[Authorize]

public class ReportController : Controller
{
    private readonly IWebHostEnvironment _env;
    private readonly IRoom _roomRepo;
    private readonly IBlock _blockrepo;
    private readonly IBuilding _buildingrepo;
    private readonly IFloor _floorrepo;
    private readonly IDevotee _devoteerepo;
    private readonly IDevoteeCategory _devotecategoryrepo;
    private readonly ICompany _companyrepo;
    public ReportController(IWebHostEnvironment env, IRoom roomRepo, IBlock blockrepo,
            IBuilding buildingrepo, IFloor floorrepo, IReservation reservationrepo,
            IDevotee devoteerepo, IDevoteeCategory devotecatcategoryrepo, ICompany companyrepo)
    {
        _env = env;
        _roomRepo = roomRepo;
        _blockrepo = blockrepo;
        _buildingrepo = buildingrepo;
        _floorrepo = floorrepo;
        _devoteerepo = devoteerepo;
        _devotecategoryrepo = devotecatcategoryrepo;
        _companyrepo = companyrepo;
    }


    [HttpPost]
    public async Task<IActionResult> CheckOutViewer(DateTime dateValue, string typeofreport = "")
    {
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            return await DevoteeCheckOutReportList(dateValue, typeofreport, "Check-Out" + dateValue.Date.ToString("ddMMyyyy"));
        }
    }
    public async Task<IActionResult> AllocationViewer()
    {
        return await AllocationViewer(DateTime.MinValue, "screen","List");
    }
    [HttpPost]
    public async Task<IActionResult> AllocationViewer(DateTime dateValue, string typeofreport = "screen",string reportformat = "")
    {
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            if(reportformat == "detail")
            {
                return await (typeofreport == "screen" ? RoomsAllocationDetailPdfPreview(reportformat, dateValue) : RoomsAllocationDetailPdfDownload(reportformat, dateValue));
            }
            else
            {
                return await (typeofreport == "screen" ? RoomsAllocationPdfPreview(reportformat, dateValue) : RoomsAllocationPdfDownload(reportformat, dateValue));
            }

        }
    }
    private List<GenericItemDTO> LoadGenericTableData(string type)
    {
        return type switch
        {
            "Category" => _devotecategoryrepo.GetDevoteeCategories()
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),

            "Building" => _buildingrepo.GetBuildings()
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),

            "Block" => _blockrepo.GetBlocks()
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),

            "Floor" => _floorrepo.GetFloors()
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),
            _ => new(),
        };
}
    private async Task<IActionResult> DevoteeCheckOutReportList(DateTime dateValue, string typeofreport, string reportname)
    {
        string Subject = "Devotee Check-Out List as On: " + dateValue.Date.ToString("dd - MMM - yyyy");
        var document = new DevoteeCheckOutReport(_companyrepo.CompanyDetails(),await _devoteerepo.GetDevoteeSummaryByDateAsync(dateValue), Subject);
        var pdfBytes = document.GeneratePdf();
        return typeofreport switch
        {
            "screen" => File(pdfBytes, "application/pdf"),
            "pdf" => File(pdfBytes, "application/pdf", $"{reportname}.pdf"),
            _ => RedirectToAction("Index", "Home")
        };
    }
    private async Task<IActionResult> DevoteeCheckInReportList(DateTime dateValue, string typeofreport, string reportname)
    {
        string Subject = "Devotee Check-In List On: " + dateValue.Date.ToString("dd - MMM - yyyy");
        var document = new DevoteeCheckInReport(_companyrepo.CompanyDetails(), await _roomRepo.GetCheckInDetailsReportAsync(dateValue), Subject);
        var pdfBytes = document.GeneratePdf();
        return typeofreport switch
        {
            "screen" => File(pdfBytes, "application/pdf"),
            "pdf" => File(pdfBytes, "application/pdf", $"{reportname}.pdf"),
            _ => RedirectToAction("Index", "Home")
        };
    }
    //private IActionResult ExportPdfDetail(List<GenericItemDTO> model, string type)
    //{
    //    var document = new GenericDetailPdfDocument(model, type);
    //    var pdfBytes = document.GeneratePdf();
    //    return File(pdfBytes, "application/pdf", $"{type}_Detail.pdf");
    //}

    //private IActionResult ExportExcelList(List<GenericItemDTO> model, string type)
    //{
    //    using var workbook = new XLWorkbook();
    //    var ws = workbook.Worksheets.Add(type + " List");

    //    ws.Cell(1, 1).Value = "Name";
    //    ws.Cell(1, 2).Value = "Description";

    //    for (int i = 0; i < model.Count; i++)
    //    {
    //        ws.Cell(i + 2, 1).Value = model[i].Name;
    //        ws.Cell(i + 2, 2).Value = model[i].Description;
    //    }

    //    using var stream = new MemoryStream();
    //    workbook.SaveAs(stream);
    //    stream.Position = 0;

    //    return File(stream.ToArray(),
    //        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
    //        $"{type}_List.xlsx");
    //}

    //private IActionResult ExportExcelDetail(List<GenericItemDTO> model, string type)
    //{
    //    using var workbook = new XLWorkbook();
    //    var ws = workbook.Worksheets.Add(type + " Detail");

    //    ws.Cell(1, 1).Value = "Name";
    //    ws.Cell(1, 2).Value = "Description";

    //    for (int i = 0; i < model.Count; i++)
    //    {
    //        ws.Cell(i + 2, 1).Value = model[i].Name;
    //        ws.Cell(i + 2, 2).Value = model[i].Description;
    //    }

    //    using var stream = new MemoryStream();
    //    workbook.SaveAs(stream);
    //    stream.Position = 0;

    //    return File(stream.ToArray(),
    //        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
    //        $"{type}_Detail.xlsx");
    //}

    // Excel Export
    //private IActionResult ExportGenericReportToExcel(string type)
    //{
    //    try
    //    {
    //        var items = LoadGenericTableData(type) ?? new List<GenericItemDTO>();

    //        using var workbook = new XLWorkbook();
    //        var ws = workbook.Worksheets.Add(type + " List");

    //        // --- Header Row ---
    //        ws.Cell(1, 1).Value = "Name";
    //        ws.Cell(1, 2).Value = "Description";
    //        ws.Row(1).Style.Font.Bold = true;
    //        ws.Row(1).Style.Fill.BackgroundColor = XLColor.FromHtml("#1f6f43"); // dark green
    //        ws.Row(1).Style.Font.FontColor = XLColor.White;
    //        ws.Row(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

    //        // --- Data Rows ---
    //        for (int i = 0; i < items.Count; i++)
    //        {
    //            var row = i + 2; // because header is row 1
    //            ws.Cell(row, 1).Value = items[i].Name;
    //            ws.Cell(row, 2).Value = items[i].Description;

    //            // Alternating row colors
    //            var bgColor = i % 2 == 0 ? XLColor.FromHtml("#e9f5ea") : XLColor.White;
    //            ws.Row(row).Style.Fill.BackgroundColor = bgColor;

    //            // Borders
    //            ws.Row(row).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
    //            ws.Row(row).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
    //        }

    //        // --- Table Borders for Header ---
    //        ws.Range(1, 1, 1, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
    //        ws.Range(1, 1, 1, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

    //        // Auto-fit columns
    //        ws.Columns().AdjustToContents();

    //        // Export to MemoryStream
    //        using var stream = new MemoryStream();
    //        workbook.SaveAs(stream);
    //        stream.Position = 0;

    //        return File(
    //            stream,
    //            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
    //            $"{type}_List.xlsx"
    //        );
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest("Error generating Excel: " + ex.Message);
    //    }
    //}


    // PDF Export using QuestPDF
    public IActionResult ExportGenericReportToPdf(string type)
    {
        var items = LoadGenericTableData(type); // List<GenericItemDTO>
        var company = _companyrepo.CompanyDetails(); // your company details
        type = type == "Category" ? "Devotee Category" : type;
        var pdfBytes = new PrintGenericTable(company, type + " List", items).GeneratePdf();
        return File(pdfBytes, "application/pdf", $"{type}_List.pdf");
    }

    // PrintGenericReport view (browser)
    public IActionResult PrintGenericReport(string type)
    {
        var items = LoadGenericTableData(type); // List<GenericItemDTO>
        var company = _companyrepo.CompanyDetails(); // company details
        type = type == "Category" ? "Devotee Category" : type;
        var pdfBytes = new PrintGenericTable(company, type + " List", items).GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }
    private async Task<IActionResult> RoomsAllocationPdfDownload(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        string Subject = string.Empty;
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation List Report (All Dates)";
        else
            Subject = $"Rooms Allocation List Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDateWise(company, roomList , Subject);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        var fileName = $"RoomsAllocationListReport_{DateTime.Now:yyyyMMdd}.pdf";
        return File(pdfBytes, "application/pdf", fileName);
    }

    private async Task<IActionResult> RoomsAllocationPdfPreview(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        string Subject = string.Empty;
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation List Report (All Dates)";
        else
            Subject = $"Rooms Allocation List Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDateWise(company, roomList, Subject);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }
    private async Task<IActionResult> RoomsAllocationDetailPdfDownload(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        string Subject = string.Empty;
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation Detail Report (All Dates)";
        else
            Subject = $"Rooms Allocation Detail Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDetailDateWise(company, roomList, Subject);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        var fileName = $"RoomsAllocationListReport_{DateTime.Now:yyyyMMdd}.pdf";
        return File(pdfBytes, "application/pdf", fileName);
    }

    private async Task<IActionResult> RoomsAllocationDetailPdfPreview(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        string Subject = string.Empty;
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation Detail Report (All Dates)";
        else
            Subject = $"Rooms Allocation Detail Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDetailDateWise(company, roomList, Subject);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }

    public async Task<IActionResult> CheckOutViewer()
    {
        return await CheckOutViewer(DateTime.MinValue, "screen");
    }
  
    [HttpPost]
    public async Task<IActionResult> ShowReport(string reportType, string actionButton, int Id = 0)
    {
        WebReport wr = new WebReport();
        Company company = _companyrepo.CompanyDetails();
        switch (reportType)
        {
            case "DevoteeList":
                var jsonData = HttpContext.Session.GetString("DevoteesFilterData");
                if (string.IsNullOrEmpty(jsonData))
                    return Content("No filtered data available for report.");

                // 🧩 Step 2: Deserialize back to list
                var devotees = System.Text.Json.JsonSerializer.Deserialize<List<DevoteeReportDTO>>(jsonData);
                var doc = new DevoteeListReport(company, devotees, "Devotee List - Filtered");
                var pdfBytes = doc.GeneratePdf();
                return actionButton switch
                {
                    "Screen" => File(pdfBytes, "application/pdf"),
                    "Pdf" => File(pdfBytes, "application/pdf", "DevoteeList_Filter.pdf"),
                    _ => RedirectToAction("Index", "Home")
                };
            case "DevoteeDetail":
                {
                    var detail = new DevoteeDetailReport(company, await _devoteerepo.GetDevoteeWithReservations(Id), "Devotee Detail");
                    var pbytes = detail.GeneratePdf();
                    return actionButton switch
                    {
                        "Screen" => File(pbytes, "application/pdf"),
                        "Pdf" => File(pbytes, "application/pdf", "DevoteeDetail_"+ Id + ".pdf"),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
            case "Category":
            case "Building":
            case "Block":
            case "Floor":
                {
                    return actionButton switch
                    {
                        "Screen" => PrintGenericReport(reportType),
                        "Pdf" => ExportGenericReportToPdf(reportType),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
            case "Reservation":
                {
                    //var model = LoadGenericTableData(reportType);
                    //return actionButton switch
                    //{
                    //    "ScreenList" => View("ScreenListReport", model),
                    //    "ScreenDetail" => View("ScreenDetailReport", model),

                    //    "PdfList" => ExportPdfList(model, reportType),
                    //    "PdfDetail" => ExportPdfDetail(model, reportType),

                    //    "ExcelList" => ExportExcelList(model, reportType),
                    //    "ExcelDetail" => ExportExcelDetail(model, reportType),

                    //    _ => RedirectToAction("Index", "Home")
                    //};

                    if (actionButton =="ScreenList")
                        return await RoomsAllocationPdfPreview("List", DateTime.MinValue);
                    else if(actionButton == "PdfList")
                        return await RoomsAllocationPdfDownload("List", DateTime.MinValue);
                    if (actionButton == "ScreenDetail")
                        return await RoomsAllocationDetailPdfPreview("Detail", DateTime.MinValue);
                    else if (actionButton == "PdfDetail")
                        return await RoomsAllocationDetailPdfDownload("Detail", DateTime.MinValue);
                    else
                        return await RoomsAllocationPdfPreview("List", DateTime.MinValue);
                }
            case "Room":
                var roomList = _roomRepo.GetRooms();
                var roomsReport = new RoomsReportDocument(company, roomList);
                var pdBytes = roomsReport.GeneratePdf();
                return actionButton switch
                {
                    "Screen" => File(pdBytes, "application/pdf"),
                    "Pdf" => File(pdBytes, "application/pdf", $"RoomsReport_{DateTime.Now:yyyyMMdd}.pdf"),
                    _ => RedirectToAction("Index", "Home")
                };
            default:
                return View(wr);
        }
    }
  
    public async Task<IActionResult> CheckInViewer()
    {
        return await CheckInViewer(DateTime.MinValue, "screen");
    }
    [HttpPost]
    public async Task<IActionResult> CheckInViewer(DateTime dateValue, string typeofreport = "")
    {
        if (string.IsNullOrEmpty(typeofreport) || dateValue == DateTime.MinValue)
        {
            return View();
        }
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            return await DevoteeCheckInReportList(dateValue, typeofreport, "Check-In" + dateValue.Date.ToString("ddMMyyyy"));
        }
        //WebReport wr = new WebReport();
        //string reportPath = Path.Combine(_env.ContentRootPath, "Reports", "DevoteeCheckInDetails.frx");
        //wr.Report.Load(reportPath);
        //List<ReservationReportDTO> reservations = await _roomRepo.GetCheckInDetailsReportAsync(dateValue);
        //List<Company> companies = new() { _companyrepo.CompanyDetails() };
        //wr.Report.Dictionary.RegisterBusinessObject(companies, "Company", 1, true);
        //wr.Report.Dictionary.RegisterBusinessObject(reservations, "Reservations", 1, true);
        //wr.Report.SetParameterValue("FromDateParam", dateValue.Date.ToString("dd - MMM- yyyy"));
        //try
        //{
        //    wr.Report.Prepare();
        //    if (typeofreport == "screen")
        //    {

        //        return View(wr); // ⚠️ Possible error point
        //    }
        //    var export = new FastReport.Export.PdfSimple.PDFSimpleExport();
        //    MemoryStream ms = new MemoryStream();
        //    wr.Report.Export(export, ms);
        //    ms.Position = 0;
        //    return File(ms, "application/pdf", "Checkin.pdf");
        //}
        //catch (Exception ex)
        //{
        //    return View("Error", ex);
        //}
    }
}

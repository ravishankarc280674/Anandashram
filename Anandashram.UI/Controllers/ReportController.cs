using Anandashram.Reports;
using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using QuestPDF.Fluent;

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
        return await AllocationViewer(DateTime.MinValue, "screen", "List");
    }
    [HttpPost]
    public async Task<IActionResult> AllocationViewer(DateTime dateValue, string typeofreport = "screen", string reportformat = "")
    {
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
            var company = _companyrepo.CompanyDetails();
            string Subject = $"Rooms Allocation " + reportformat + " Report (Up to {dateValue:dd - MMM - yyyy})";
            return reportformat switch
            {
                "List" =>
                        typeofreport switch
                        {
                            "screen" => RoomsAllocationPdfPreview(company, roomList, dateValue),
                            "pdf" => RoomsAllocationPdfDownload(company, roomList, dateValue),
                            "excel" => ExportRoomAllocationDateWiseToExcel(company, roomList, Subject),
                            _ => RedirectToAction("Index", "Home")
                        },
                "Detail" =>
                        typeofreport switch
                        {
                            "screen" => await RoomsAllocationDetailPdfPreview(company, roomList, dateValue),
                            "pdf" => await RoomsAllocationDetailPdfDownload(company, roomList, dateValue),
                            "excel" => ExportRoomAllocationDetailDateWiseToExcel(company, roomList, Subject),
                            _ => RedirectToAction("Index", "Home")
                        },
                _ => RedirectToAction("Index", "Home")
            };
        };
    }
    public IActionResult ExportRoomAllocationDateWiseToExcel(Company company, List<RoomReportDTO> rooms, string subject)
    {
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Room Allocation");

        int currentRow = 1;
        int totalColumns = 4; // RoomName, Capacity, Allocated, Remaining

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Column(1).Width = 150;
        ws.Column(2).Width = 150;
        ws.Column(3).Width = 150;
        ws.Column(4).Width = 150;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;
        currentRow++;

        var grouped = rooms
            .OrderBy(r => r.BuildingName)
            .ThenBy(r => r.BlockName)
            .ThenBy(r => r.FloorName)
            .GroupBy(g => new { g.BuildingName, g.BlockName, g.FloorName });

        int headerRow = 0;

        foreach (var group in grouped)
        {
            // Group Header
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                .Value = $"Building: {group.Key.BuildingName} | Block: {group.Key.BlockName} | Floor: {group.Key.FloorName}";
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.LightGray)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
            currentRow++;

            // ===== TABLE HEADER =====
            ws.Cell(currentRow, 1).Value = "Room Name";
            ws.Cell(currentRow, 2).Value = "Capacity";
            ws.Cell(currentRow, 3).Value = "Allocated";
            ws.Cell(currentRow, 4).Value = "Remaining";
            
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.DarkGreen)
                .Font.SetFontColor(XLColor.White)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

            if (headerRow == 0)
                headerRow = currentRow;

            currentRow++;

            // ===== DATA ROWS =====
            bool isEven = true;
            foreach (var room in group)
            {
                var bg = isEven ? XLColor.White : XLColor.LightGray;
                isEven = !isEven;

                ws.Cell(currentRow, 1).Value = room.RoomName;
                ws.Cell(currentRow, 2).Value = room.Capacity;
                ws.Cell(currentRow, 3).Value = room.TotalAllocated;
                ws.Cell(currentRow, 4).Value = room.TotalRemaining;

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Fill.SetBackgroundColor(bg)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    .Alignment.SetWrapText(true);

                currentRow++;
            }

            // ===== SUBTOTAL =====
            ws.Cell(currentRow, 1).Value = "Subtotal :";
            ws.Cell(currentRow, 1).Style.Font.SetBold();

            ws.Cell(currentRow, 2).Value = group.Sum(r => r.Capacity);
            ws.Cell(currentRow, 3).Value = group.Sum(r => r.TotalAllocated);
            ws.Cell(currentRow, 4).Value = group.Sum(r => r.TotalRemaining);

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(XLColor.LightGreen)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
            currentRow += 2;
        }

        // ===== GRAND TOTAL =====
        ws.Cell(currentRow, 1).Value = "Grand Total :";
        ws.Cell(currentRow, 1).Style.Font.SetBold();

        ws.Cell(currentRow, 2).Value = rooms.Sum(r => r.Capacity);
        ws.Cell(currentRow, 3).Value = rooms.Sum(r => r.TotalAllocated);
        ws.Cell(currentRow, 4).Value = rooms.Sum(r => r.TotalRemaining);

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightBlue)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
        currentRow++;

        // ===== FOOTER =====
        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // ===== FORMATTING =====
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);
        ws.Columns().AdjustToContents();

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "RoomAllocationDateWise.xlsx");
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
       var company = _companyrepo.CompanyDetails();
        var devoteeList = await _devoteerepo.GetDevoteeSummaryByDateAsync(dateValue);
        var document = new DevoteeCheckOutReport(company, devoteeList, Subject);
        var pdfBytes = document.GeneratePdf();
        return typeofreport switch
        {
            "screen" => File(pdfBytes, "application/pdf"),
            "pdf" => File(pdfBytes, "application/pdf", $"{reportname}.pdf"),
            "excel" => ExportDevoteeCheckOutToExcel(company, devoteeList, Subject),
            _ => RedirectToAction("Index", "Home")
        };
    }
    private async Task<IActionResult> DevoteeCheckInReportList(DateTime dateValue, string typeofreport, string reportname)
    {
        string Subject = "Devotee Check-In List On: " + dateValue.Date.ToString("dd - MMM - yyyy");
        var data = await _roomRepo.GetCheckInDetailsReportAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        var document = new DevoteeCheckInReport(company, data, Subject);
        var pdfBytes = document.GeneratePdf();
        return typeofreport switch
        {
            "screen" => File(pdfBytes, "application/pdf"),
            "pdf" => File(pdfBytes, "application/pdf", $"{reportname}.pdf"),
            "excel" => ExportDevoteeCheckInToExcel(company, data, Subject),
            _ => RedirectToAction("Index", "Home")
        };
    }
     
    // PDF Export using QuestPDF
    public IActionResult ExportGenericReportToPdf(string type)
    {
        var items = LoadGenericTableData(type); // List<GenericItemDTO>
        var company = _companyrepo.CompanyDetails(); // your company details
        type = type == "Category" ? "Devotee Category" : type;
        var pdfBytes = new PrintGenericTable(company, type + " List", items).GeneratePdf();
        return File(pdfBytes, "application/pdf", $"{type}_List.pdf");
    }

    public IActionResult PrintGenericReport(string type)
    {
        var items = LoadGenericTableData(type); // List<GenericItemDTO>
        var company = _companyrepo.CompanyDetails(); // company details
        type = type == "Category" ? "Devotee Category" : type;
        var pdfBytes = new PrintGenericTable(company, type + " List", items).GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }

public IActionResult ExportDevoteeCheckOutToExcel(Company company, List<DevoteeReportDTO> items, string subject)
{
    using var workbook = new XLWorkbook();
    var ws = workbook.Worksheets.Add("Check-Out Report");

    int currentRow = 1;
    int totalColumns = 4;

    // ===== COMPANY HEADER =====
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Merge()
        .Value = company.Name;
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Style.Font.SetBold().Font.SetFontSize(14)
        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
    currentRow++;

    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Merge()
        .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
    currentRow++;

    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Merge()
        .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
    currentRow++;

    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Merge()
        .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
    currentRow++;

    if (!string.IsNullOrWhiteSpace(company.Website))
    {
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = company.Website;
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Font.SetUnderline()
            .Font.SetFontColor(XLColor.Blue)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;
    }

    currentRow++; // blank line

    // ===== SUBJECT =====
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Merge()
        .Value = subject;
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Style.Font.SetBold().Font.SetFontSize(12)
        .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
        .Font.SetFontColor(XLColor.White)
        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
    currentRow++;

    currentRow++; // blank line

    // ===== TABLE HEADER (filter only here) =====
    ws.Cell(currentRow, 1).Value = "Code";
    ws.Cell(currentRow, 2).Value = "Name";
    ws.Cell(currentRow, 3).Value = "Category";
    ws.Cell(currentRow, 4).Value = "Allocated";

    ws.Range(currentRow, 1, currentRow, totalColumns).Style
        .Font.SetBold()
        .Fill.SetBackgroundColor(XLColor.DarkGreen)
        .Font.SetFontColor(XLColor.White)
        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
        .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
        .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

    int headerRowNumber = currentRow;
    currentRow++;

    // ===== DATA ROWS =====
    bool isEven = true;
    foreach (var item in items)
    {
        var bgColor = isEven ? XLColor.White : XLColor.LightGray;
        isEven = !isEven;

        ws.Cell(currentRow, 1).Value = item.Code;
        ws.Cell(currentRow, 2).Value = item.Name;
        ws.Cell(currentRow, 3).Value = item.DevoteeCategoryName;
        ws.Cell(currentRow, 4).Value = item.TotalAllocated;

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(bgColor)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
            .Alignment.SetWrapText(true);

        currentRow++;
    }

    // ===== TOTAL ROW =====
    ws.Cell(currentRow, 3).Value = "Total Allocated:";
    ws.Cell(currentRow, 3).Style.Font.SetBold();
    ws.Cell(currentRow, 4).Value = items.Sum(x => x.TotalAllocated);
    ws.Cell(currentRow, 4).Style.Font.SetBold();

    ws.Range(currentRow, 1, currentRow, totalColumns).Style
        .Fill.SetBackgroundColor(XLColor.LightGreen)
        .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

    currentRow++;

    // ===== FOOTER PRINT DATE =====
    currentRow++;
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Merge()
        .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
    ws.Range(currentRow, 1, currentRow, totalColumns)
        .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left)
        .Font.SetItalic();

    // ===== FORMATTING =====
    ws.SheetView.FreezeRows(headerRowNumber); // freeze table header row only
    ws.Range(headerRowNumber, 1, currentRow, totalColumns).SetAutoFilter();
    ws.Columns().AdjustToContents();
    ws.Columns(2, 3).Width = 30; // Name & Category wider
    ws.Column(1).Width = 15; // Code

    var stream = new MemoryStream();
    workbook.SaveAs(stream);
    stream.Position = 0;

    return File(stream,
        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        "DevoteeCheckOutReport.xlsx");
}

    public IActionResult ExportDevoteeCheckInToExcel(Company company, List<ReservationReportDTO> items, string subject)
    {
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Check-In Report");

        int currentRow = 1;
        int totalColumns = 5;

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        currentRow++;

        // ===== TABLE HEADER =====
        ws.Cell(currentRow, 1).Value = "Code";
        ws.Cell(currentRow, 2).Value = "Name";
        ws.Cell(currentRow, 3).Value = "Room";
        ws.Cell(currentRow, 4).Value = "Check-Out";
        ws.Cell(currentRow, 5).Value = "Allocated";

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold()
            .Fill.SetBackgroundColor(XLColor.DarkGreen)
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
            .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        int headerRow = currentRow;
        currentRow++;

        // ===== DATA ROWS =====
        bool isEven = true;
        foreach (var item in items)
        {
            var bg = isEven ? XLColor.White : XLColor.LightGray;
            isEven = !isEven;

            ws.Cell(currentRow, 1).Value = item.DevoteeCode;
            ws.Cell(currentRow, 2).Value = item.DevoteeName;
            ws.Cell(currentRow, 3).Value = item.RoomName;
            ws.Cell(currentRow, 4).Value = item.ToDate.ToString("dd-MMM-yyyy");
            ws.Cell(currentRow, 5).Value = item.Allocated;

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(bg)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                .Alignment.SetWrapText(true);

            currentRow++;
        }

        // ===== TOTAL ROW =====
        ws.Cell(currentRow, 4).Value = "Total :";
        ws.Cell(currentRow, 4).Style.Font.SetBold();
        ws.Cell(currentRow, 5).Value = items.Sum(x => x.Allocated);
        ws.Cell(currentRow, 5).Style.Font.SetBold();

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightGreen)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        currentRow++;

        // ===== FOOTER (Print Date) =====
        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // ===== FORMATTING =====
        ws.SheetView.FreezeRows(headerRow);
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.Columns().AdjustToContents();
        ws.Column(1).Width = 15;
        ws.Column(2).Width = 30;
        ws.Column(3).Width = 20;
        ws.Column(4).Width = 15;

        // ===== RETURN EXCEL =====
        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "DevoteeCheckInReport.xlsx");
    }
    
    private IActionResult RoomsAllocationPdfDownload(Company company, List<RoomReportDTO> roomList, DateTime dateValue)
    {
        string Subject = string.Empty;
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation List Report (All Dates)";
        else
            Subject = $"Rooms Allocation List Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDateWise(company, roomList, Subject);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        var fileName = $"RoomsAllocationListReport_{DateTime.Now:yyyyMMdd}.pdf";
        return File(pdfBytes, "application/pdf", fileName);
    }

    private IActionResult RoomsAllocationPdfPreview(Company company,List<RoomReportDTO> roomList, DateTime dateValue)
    {
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

    public IActionResult ExportRoomAllocationDetailDateWiseToExcel(Company company, List<RoomReportDTO> rooms, string subject)
    {
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Room Allocation");

        int currentRow = 1;
        int totalColumns = 4;

        ws.Column(1).Width = 25;
        ws.Column(2).Width = 15;
        ws.Column(3).Width = 15;
        ws.Column(4).Width = 15;

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;
        currentRow++;

        var grouped = rooms
            .OrderBy(r => r.BuildingName)
            .ThenBy(r => r.BlockName)
            .ThenBy(r => r.FloorName)
            .GroupBy(g => new { g.BuildingName, g.BlockName, g.FloorName });

        int headerRow = 0;

        foreach (var group in grouped)
        {
            // GROUP HEADER
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                .Value = $"Building: {group.Key.BuildingName} | Block: {group.Key.BlockName} | Floor: {group.Key.FloorName}";
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.LightGray)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
            currentRow++;

            foreach (var room in group)
            {
                // ===== ROOM DETAILS =====
                ws.Cell(currentRow, 1).Value = room.RoomName;
                ws.Cell(currentRow, 2).Value = room.Capacity;
                ws.Cell(currentRow, 3).Value = room.TotalAllocated;
                ws.Cell(currentRow, 4).Value = room.TotalRemaining;

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.LightGreen)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                currentRow++;

                // ⭐ NEW: Reservations header row
                ws.Cell(currentRow, 1).Value = "Devotee Code";
                ws.Cell(currentRow, 2).Value = "Devotee Name";
                ws.Cell(currentRow, 3).Value = "From Date";
                ws.Cell(currentRow, 4).Value = "Allocated";

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.DarkGreen)
                    .Font.SetFontColor(XLColor.White)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                if (headerRow == 0)
                    headerRow = currentRow;

                currentRow++;

                // ⭐ NEW: Reservation data rows
                if (room.Reservations.Any())
                {
                    bool isEven = true;
                    foreach (var res in room.Reservations)
                    {
                        var bg = isEven ? XLColor.White : XLColor.FromHtml("#e9f7ef");
                        isEven = !isEven;

                        ws.Cell(currentRow, 1).Value = res.DevoteeCode;
                        ws.Cell(currentRow, 2).Value = res.DevoteeName;
                        ws.Cell(currentRow, 3).Value = res.FromDate.ToString("dd-MMM-yyyy");
                        ws.Cell(currentRow, 4).Value = res.Allocated;

                        ws.Range(currentRow, 1, currentRow, totalColumns).Style
                            .Fill.SetBackgroundColor(bg)
                            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                        currentRow++;
                    }
                }
                else
                {
                    ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                        .Value = "No active reservations";
                    ws.Range(currentRow, 1, currentRow, totalColumns).Style
                        .Font.SetItalic()
                        .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    currentRow++;
                }

                currentRow++;
            }

            // SUBTOTAL
            ws.Cell(currentRow, 1).Value = "Subtotal :";
            ws.Cell(currentRow, 1).Style.Font.SetBold();

            ws.Cell(currentRow, 2).Value = group.Sum(r => r.Capacity);
            ws.Cell(currentRow, 3).Value = group.Sum(r => r.TotalAllocated);
            ws.Cell(currentRow, 4).Value = group.Sum(r => r.TotalRemaining);

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(XLColor.LightYellow)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
            currentRow += 2;
        }

        // GRAND TOTAL
        ws.Cell(currentRow, 1).Value = "Grand Total :";
        ws.Cell(currentRow, 1).Style.Font.SetBold();

        ws.Cell(currentRow, 2).Value = rooms.Sum(r => r.Capacity);
        ws.Cell(currentRow, 3).Value = rooms.Sum(r => r.TotalAllocated);
        ws.Cell(currentRow, 4).Value = rooms.Sum(r => r.TotalRemaining);

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightBlue)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
        currentRow++;

        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // Formatting
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);
        ws.Columns().AdjustToContents();

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "RoomAllocationDateWise.xlsx");
    }

    private async Task<IActionResult> RoomsAllocationDetailPdfDownload(Company company, List<RoomReportDTO> roomList, DateTime dateValue)
    {
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

    private async Task<IActionResult> RoomsAllocationDetailPdfPreview(Company company, List<RoomReportDTO> roomList, DateTime dateValue)
    {
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
        Company company = _companyrepo.CompanyDetails();
        switch (reportType)
        {
            case "DevoteeList":
                var jsonData = HttpContext.Session.GetString("DevoteesFilterData");
                if (string.IsNullOrEmpty(jsonData))
                    return Content("No filtered data available for report.");

                // Deserialize the session JSON to a list
                var devotees = System.Text.Json.JsonSerializer.Deserialize<List<DevoteeReportDTO>>(jsonData);

                if (devotees == null || !devotees.Any())
                    return Content("No data available for report.");
                var doc = new DevoteeListReport(company, devotees, "Devotee List - Filtered");
                var pdfBytes = doc.GeneratePdf();
                return actionButton switch
                {
                    "Screen" => File(pdfBytes, "application/pdf"),
                    "Pdf" => File(pdfBytes, "application/pdf", "DevoteeList_Filter.pdf"),
                    "Excel" => ExportDevoteeListReportToExcel(devotees), // download Excel
                    _ => Content("Invalid action")
                };
            case "DevoteeDetail":
                {
                    var detail = new DevoteeDetailReport(company, await _devoteerepo.GetDevoteeWithReservations(Id), "Devotee Detail");
                    var pbytes = detail.GeneratePdf();
                    return actionButton switch
                    {
                        "Screen" => File(pbytes, "application/pdf"),
                        "Pdf" => File(pbytes, "application/pdf", "DevoteeDetail_" + Id + ".pdf"),
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
                        "Excel" => ExportGenericItemsToExcel(reportType),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
            //case "Reservation":
            //    {
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
                    
                    //if (actionButton == "ScreenList")
                    //    return await RoomsAllocationPdfPreview( "List", DateTime.MinValue);
                    //else if (actionButton == "PdfList")
                    //    return await RoomsAllocationPdfDownload("List", DateTime.MinValue);
                    //if (actionButton == "ScreenDetail")
                    //    return await RoomsAllocationDetailPdfPreview("Detail", DateTime.MinValue);
                    //else if (actionButton == "PdfDetail")
                    //    return await RoomsAllocationDetailPdfDownload("Detail", DateTime.MinValue);
                    //else
                    //    return await RoomsAllocationPdfPreview("List", DateTime.MinValue);
                //}
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
                return View(null);
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
    }

    #region Export To Excel Methods
    // Excel Export methods can be added here in future
    public IActionResult ExportDevoteeListReportToExcel(List<DevoteeReportDTO> devotees)
    {
        // Export to Excel
        using var workbook = new ClosedXML.Excel.XLWorkbook();
        var ws = workbook.Worksheets.Add("Devotee List");

        // Header row
        ws.Cell(1, 1).Value = "Code";
        ws.Cell(1, 2).Value = "Name";
        ws.Cell(1, 3).Value = "Category";
        ws.Cell(1, 4).Value = "StartDate";
        ws.Cell(1, 5).Value = "No. of People";
        ws.Cell(1, 6).Value = "Mobile";
        ws.Cell(1, 7).Value = "Document";
        ws.Cell(1, 8).Value = "Address";

        var headerRange = ws.Range(1, 1, 1, 8);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(34, 139, 34); // DarkGreen
        headerRange.Style.Font.FontColor = XLColor.White;
        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        headerRange.Style.Alignment.WrapText = true;
        // Fill data
        for (int i = 0; i < devotees.Count; i++)
        {
            var item = devotees[i];
            int row = i + 2;
            ws.Cell(row, 1).Value = item.Code;
            ws.Cell(row, 2).Value = item.Name;
            ws.Cell(row, 3).Value = item.DevoteeCategoryName;
            ws.Cell(row, 4).Value = item.StartDate.ToString("dd/MM/yyyy");
            ws.Cell(row, 5).Value = item.NoOfPeople;
            ws.Cell(row, 6).Value = item.Mobile;
            ws.Cell(row, 7).Value = item.Document;
            ws.Cell(row, 8).Value = $"{item.AddressLine1} {item.AddressLine2} {item.State} {item.Country} {item.PinCode}".Trim();
            ws.Range(row, 2, row, 8).Style.Alignment.WrapText = true;
        }

        // fit columns
        ws.Column(1).Width = 12;  // Code
        ws.Column(2).Width = 25;  // Name
        ws.Column(3).Width = 20;  // Category
        ws.Column(4).Width = 12;  // Start Date
        ws.Column(5).Width = 15;  // No. of Devotees
        ws.Column(6).Width = 25;  // Mobile
        ws.Column(7).Width = 25;  // Document
        ws.Column(8).Width = 40;  // Address

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "DevoteeList_Filtered.xlsx");
    }
    public IActionResult ExportGenericItemsToExcel(string itemType)
    {
        List<GenericItemDTO> items;
        items = LoadGenericTableData(itemType);
        if (items == null || items.Count == 0)
            return Content("No data available for export.");

        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Items List");

        // Header row
        ws.Cell(1, 1).Value = "Name";
        ws.Cell(1, 2).Value = "Description";

        // Style header
        var headerRange = ws.Range(1, 1, 1, 2);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(34, 139, 34); // DarkGreen
        headerRange.Style.Font.FontColor = XLColor.White;
        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        headerRange.Style.Alignment.WrapText = true;

        // Fill data
        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
            int row = i + 2;

            ws.Cell(row, 1).Value = item.Name;
            ws.Cell(row, 2).Value = item.Description;

            ws.Range(row, 1, row, 2).Style.Alignment.WrapText = true;
        }

        // Set column widths
        ws.Column(1).Width = 50; // Name
        ws.Column(2).Width = 50; // Description
        //ws.Columns().AdjustToContents(); // Optional auto-fit

        // Save to memory stream
        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            itemType + "_List.xlsx");
    }
     

    #endregion
}


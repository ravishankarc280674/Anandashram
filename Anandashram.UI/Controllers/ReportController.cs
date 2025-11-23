using Anandashram.Reports;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace Anandashram.Controllers;
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
            string ReportName = string.Empty;
            WebReport wr = new WebReport();
            List<DevoteeReportDTO> devotees = await _devoteerepo.GetDevoteeSummaryByDateAsync(dateValue);
            wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeCheckOut.frx"));
            List<Company> companies = new List<Company>();
            companies.Add(_companyrepo.CompanyDetails());
            wr.Report.RegisterData(companies, "CompanyRef");
            wr.Report.RegisterData(devotees, "Devotees");
            wr.Report.SetParameterValue("Title", "Devotee Checkout List");
            wr.Report.SetParameterValue("ToDate", dateValue.Date.ToString("dd - MMM - yyyy"));
            ReportName = "Devotee Checkout List";
            if (typeofreport == "screen")
            {
                return View(wr);
            }
            else
            {
                if (wr.Report.Prepare())
                {
                    FastReport.Export.PdfSimple.PDFSimpleExport pDFSimpleExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
                    pDFSimpleExport.ShowProgress = false;
                    pDFSimpleExport.Subject = ReportName;
                    MemoryStream ms = new MemoryStream();
                    wr.Report.Export(pDFSimpleExport, ms);
                    wr.Report.Dispose();
                    pDFSimpleExport.Dispose();
                    ms.Position = 0;
                    return File(ms, "application/pdf", ReportName + ".pdf");
                }
                else
                {
                    return null;
                }
            }
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
    public List<GenericItemDTO> LoadGenericTableData(string type)
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

    // Excel Export
    public IActionResult ExportGenericReportToExcel(string type)
    {
        try
        {
            var items = LoadGenericTableData(type) ?? new List<GenericItemDTO>();

            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add(type + " List");

            // --- Header Row ---
            ws.Cell(1, 1).Value = "Name";
            ws.Cell(1, 2).Value = "Description";
            ws.Row(1).Style.Font.Bold = true;
            ws.Row(1).Style.Fill.BackgroundColor = XLColor.FromHtml("#1f6f43"); // dark green
            ws.Row(1).Style.Font.FontColor = XLColor.White;
            ws.Row(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            // --- Data Rows ---
            for (int i = 0; i < items.Count; i++)
            {
                var row = i + 2; // because header is row 1
                ws.Cell(row, 1).Value = items[i].Name;
                ws.Cell(row, 2).Value = items[i].Description;

                // Alternating row colors
                var bgColor = i % 2 == 0 ? XLColor.FromHtml("#e9f5ea") : XLColor.White;
                ws.Row(row).Style.Fill.BackgroundColor = bgColor;

                // Borders
                ws.Row(row).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws.Row(row).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            }

            // --- Table Borders for Header ---
            ws.Range(1, 1, 1, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            ws.Range(1, 1, 1, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Auto-fit columns
            ws.Columns().AdjustToContents();

            // Export to MemoryStream
            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;

            return File(
                stream,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                $"{type}_List.xlsx"
            );
        }
        catch (Exception ex)
        {
            return BadRequest("Error generating Excel: " + ex.Message);
        }
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

    // PrintGenericReport view (browser)
    public IActionResult PrintGenericReport(string type)
    {
        var items = LoadGenericTableData(type); // List<GenericItemDTO>
        var company = _companyrepo.CompanyDetails(); // your company details
        type = type == "Category" ? "Devotee Category" : type;
        var pdfBytes = new PrintGenericTable(company, type + " List", items).GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }
    private async Task<IActionResult> RoomsAllocationPdfDownload(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        var doc = new RoomAllocationDateWise(company, roomList ,dateValue);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        var fileName = $"RoomsAllocationListReport_{DateTime.Now:yyyyMMdd}.pdf";
        return File(pdfBytes, "application/pdf", fileName);
    }

    private async Task<IActionResult> RoomsAllocationPdfPreview(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        var doc = new RoomAllocationDateWise(company, roomList, dateValue);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }
    private async Task<IActionResult> RoomsAllocationDetailPdfDownload(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        var doc = new RoomAllocationDetailDateWise(company, roomList, dateValue);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        var fileName = $"RoomsAllocationListReport_{DateTime.Now:yyyyMMdd}.pdf";
        return File(pdfBytes, "application/pdf", fileName);
    }

    private async Task<IActionResult> RoomsAllocationDetailPdfPreview(string reportformat, DateTime dateValue)
    {
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        var doc = new RoomAllocationDetailDateWise(company, roomList, dateValue);

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
        List<Company> companies = new List<Company>();
        companies.Add(_companyrepo.CompanyDetails());
        string ReportName;
        switch (reportType)
        {
            case "DevoteeList":
                var jsonData = HttpContext.Session.GetString("DevoteesFilterData");
                if (string.IsNullOrEmpty(jsonData))
                    return Content("No filtered data available for report.");

                // 🧩 Step 2: Deserialize back to list
                var devotees = System.Text.Json.JsonSerializer.Deserialize<List<DevoteeReportDTO>>(jsonData);
                wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeList.frx"));

                wr.Report.RegisterData(companies, "CompanyRef");
                wr.Report.RegisterData(devotees, "Devotees");
                ReportName = "Devotee List";
                return PrintScreenOrPdf(actionButton, wr, ReportName);
            case "DevoteeDetail":
                {
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeDetail.frx"));
                    wr.Report.RegisterData(companies, "CompanyRef");
                    List<Devotee> devoteeList = new List<Devotee>();
                    devoteeList.Add(await _devoteerepo.GetDevoteeWithReservations(Id));
                    foreach (var d in devoteeList)
                    {
                        d.Reservations ??= new List<Reservation>();
                    }
                    wr.Report.RegisterData(devoteeList, "Devotees");
                    wr.Report.GetDataSource("Devotees").Enabled = true;
                    wr.Report.GetDataSource("Devotees.Reservations").Enabled = true;
                    ReportName = "Devotee Detail";
                    return PrintScreenOrPdf(actionButton, wr, ReportName);
                }
            case "Category":
            case "Building":
            case "Block":
            case "Floor":
                {
                    if (actionButton=="Screen")
                     return PrintGenericReport(reportType);
                    else if(actionButton=="Pdf")
                        return ExportGenericReportToPdf(reportType);
                    else
                        return ExportGenericReportToExcel(reportType);
                    
                }
            //case "Building":
            //    {
            //        wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
            //        wr.Report.RegisterData(companies, "CompanyRef");
            //        wr.Report.RegisterData(_buildingrepo.GetBuildings(), "GeneralRef");
            //        wr.Report.SetParameterValue("Title", "Buildings");
            //        ReportName = "Buildings";
            //        return PrintScreenOrPdf(actionButton, wr, ReportName);
            //    }
            //case "Block":
            //    {
            //        wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
            //        wr.Report.RegisterData(companies, "CompanyRef");
            //        wr.Report.RegisterData(_blockrepo.GetBlocks(), "GeneralRef");
            //        wr.Report.SetParameterValue("Title", "Blocks");
            //        ReportName = "Blocks";
            //        return PrintScreenOrPdf(actionButton, wr, ReportName);
            //    }
            //case "Floor":
            //    {
            //        wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
            //        wr.Report.RegisterData(companies, "CompanyRef");
            //        wr.Report.RegisterData(_floorrepo.GetFloors(), "GeneralRef");
            //        wr.Report.SetParameterValue("Title", "Floors");
            //        ReportName = "Floors";
            //        return PrintScreenOrPdf(actionButton, wr, ReportName);
            //    }
            case "Room":
                {
                  return await (actionButton == "Screen" ?  RoomsPdfPreview() :  RoomsPdfDownload());
                }
            default:
                return View(wr);
        }
    }
    [HttpGet]
    public async Task<IActionResult> RoomsPdfPreview()
    {
        var roomList = _roomRepo.GetRooms();
        var company = _companyrepo.CompanyDetails();
        var doc = new RoomsReportDocument(company, roomList);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        return File(pdfBytes, "application/pdf");
    }

    // Force download
    [HttpGet]
    public async Task<IActionResult> RoomsPdfDownload(DateTime? date = null)
    {
        var roomList = _roomRepo.GetRooms();
        var company = _companyrepo.CompanyDetails();
        var doc = new RoomsReportDocument(company, roomList);

        var pdfBytes = doc.GeneratePdf();
        var fileName = $"RoomsReport_{DateTime.Now:yyyyMMdd}.pdf";
        return File(pdfBytes, "application/pdf", fileName);
    }
    private IActionResult PrintScreenOrPdf(string actionButton, WebReport wr, string ReportName)
    {
        try
        {
            switch (actionButton)
            {
                case "Screen":
                    {
                        return View(wr);
                    }
                case "Pdf":
                    {
                        wr.Report.Prepare();
                        using var stream = new MemoryStream();
                        var pdfExport = new PDFSimpleExport();
                        wr.Report.Export(pdfExport, stream);
                        pdfExport.ShowProgress = false;
                        pdfExport.Subject = ReportName;
                        wr.Report.Dispose();
                        pdfExport.Dispose();
                        return File(stream.ToArray(), "application/pdf", ReportName + ".pdf");
                    }
                default:
                    return View(wr);

            }
        }
        catch (Exception ex)
        {
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

        WebReport wr = new WebReport();
        string reportPath = Path.Combine(_env.ContentRootPath, "Reports", "DevoteeCheckInDetails.frx");
        wr.Report.Load(reportPath);
        List<ReservationReportDTO> reservations = await _roomRepo.GetCheckInDetailsReportAsync(dateValue);
        List<Company> companies = new() { _companyrepo.CompanyDetails() };
        wr.Report.Dictionary.RegisterBusinessObject(companies, "Company", 1, true);
        wr.Report.Dictionary.RegisterBusinessObject(reservations, "Reservations", 1, true);
        wr.Report.SetParameterValue("FromDateParam", dateValue.Date.ToString("dd - MMM- yyyy"));
        try
        {
            wr.Report.Prepare();
            if (typeofreport == "screen")
            {
                
                return View(wr); // ⚠️ Possible error point
            }
            var export = new FastReport.Export.PdfSimple.PDFSimpleExport();
            MemoryStream ms = new MemoryStream();
            wr.Report.Export(export, ms);
            ms.Position = 0;
            return File(ms, "application/pdf", "Checkin.pdf");
        }
        catch (Exception ex)
        {
            return View("Error", ex);
        }
    }
}

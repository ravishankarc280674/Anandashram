using FastReport.Export.PdfSimple;
using FastReport.Web;

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
        return await AllocationViewer(DateTime.MinValue, "screen");
    }
    [HttpPost]
    public async Task<IActionResult> AllocationViewer(DateTime dateValue, string typeofreport = "")
    {
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            WebReport wr = new WebReport();
            wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "RoomAllocation.frx"));
            // Register Company
            var company = _companyrepo.CompanyDetails();
            wr.Report.RegisterData(new List<Company> { company }, "Company");
            wr.Report.GetDataSource("Company").Enabled = true;
            List<RoomReportDTO> roomList = await _roomRepo.GetRoomsWithReservationsUpToDateAsync(dateValue);
            wr.Report.RegisterData(roomList, "Rooms");
            wr.Report.GetDataSource("Rooms").Enabled = true;
            wr.Report.GetDataSource("Rooms.Reservations").Enabled = true;
            wr.Report.SetParameterValue("DatePassed", dateValue.ToString("dd-MMM-yyyy"));

            if (typeofreport == "screen")
            {
                return View(wr);
            }

            // Prepare only for export
            wr.Report.Prepare();
            using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
            using var ms = new MemoryStream();
            wr.Report.Export(pdfExport, ms);
            ms.Position = 0;
            return File(ms.ToArray(), "application/pdf", "Room Allocation - Detail.pdf");
        }
    }

    public async Task<IActionResult> CheckOutViewer()
    {
        return await CheckOutViewer(DateTime.MinValue, "screen");
    }
  
    public IActionResult DevoteeReportViewer()
    {
        return View();
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
            case "DevoteeCategory":
                {
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
                    wr.Report.RegisterData(companies, "CompanyRef");
                    wr.Report.RegisterData(_devotecategoryrepo.GetDevoteeCategories(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Devotee Categories");
                    ReportName = "Devotee Categories";
                    return PrintScreenOrPdf(actionButton, wr, ReportName);
                }
            case "Building":
                {
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
                    wr.Report.RegisterData(companies, "CompanyRef");
                    wr.Report.RegisterData(_buildingrepo.GetBuildings(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Buildings");
                    ReportName = "Buildings";
                    return PrintScreenOrPdf(actionButton, wr, ReportName);
                }
            case "Block":
                {
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
                    wr.Report.RegisterData(companies, "CompanyRef");
                    wr.Report.RegisterData(_blockrepo.GetBlocks(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Blocks");
                    ReportName = "Blocks";
                    return PrintScreenOrPdf(actionButton, wr, ReportName);
                }
            case "Floor":
                {
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
                    wr.Report.RegisterData(companies, "CompanyRef");
                    wr.Report.RegisterData(_floorrepo.GetFloors(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Floors");
                    ReportName = "Floors";
                    return PrintScreenOrPdf(actionButton, wr, ReportName);
                }
            case "Room":
                {
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "RoomListDetails.frx"));
                    wr.Report.RegisterData(_roomRepo.GetRooms(), "Rooms");
                    wr.Report.GetDataSource("Rooms").Enabled = true;

                    wr.Report.RegisterData(companies, "Company");
                    wr.Report.GetDataSource("Company").Enabled = true;
                    ReportName = "Rooms";
                    return PrintScreenOrPdf(actionButton, wr, ReportName);
                }
            default:
                return View(wr);
        }
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

    [HttpPost]
    public async Task<IActionResult> DevoteeReportViewer(string typeofreport = "")
    {
        WebReport wr = new WebReport();
        wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeDetail.frx"));
        List<Company> companies = new List<Company>();
        companies.Add(_companyrepo.CompanyDetails());
        wr.Report.RegisterData(companies, "CompanyRef");
        List<Devotee> devotees = new List<Devotee>();
        devotees.Add(await _devoteerepo.GetDevoteeWithReservations(1));
        foreach (var d in devotees)
        {
            d.Reservations ??= new List<Reservation>();
        }
        wr.Report.RegisterData(devotees, "Devotees");
        wr.Report.GetDataSource("Devotees").Enabled = true;
        wr.Report.GetDataSource("Devotees.Reservations").Enabled = true;
        wr.Report.Prepare();
        if (typeofreport == "screen")
        {
            return View(wr);
        }
        else
        {
            FastReport.Export.PdfSimple.PDFSimpleExport pDFSimpleExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
            pDFSimpleExport.ShowProgress = false;
            pDFSimpleExport.Subject = "Devotee Details";
            MemoryStream ms = new MemoryStream();
            wr.Report.Export(pDFSimpleExport, ms);
            wr.Report.Dispose();
            pDFSimpleExport.Dispose();
            ms.Position = 0;
            return File(ms, "application/pdf", "DevoteeDetail.pdf");
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

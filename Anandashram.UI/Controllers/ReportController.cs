using Anandashram.Reports;
using AspNetCoreGeneratedDocument;
using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using QuestPDF.Fluent;
using System.IO;
using System.Threading.Tasks;

namespace Anandashram.Controllers;
[Authorize]

public class ReportController : Controller
{
    private readonly IReportService _reportService;
    public ReportController(IReportService reportService)
    {
        _reportService = reportService;
    }
    #region << Moved to Services >>
    [HttpPost]
    public async Task<IActionResult> CheckOutViewer(DateTime dateValue, string typeofreport = "", string dataType = "All")
    {
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            return await DevoteeCheckOutReportList(dateValue, typeofreport, "Check-Out" + dateValue.Date.ToString("ddMMyyyy"), dataType);
        }
    }
    private async Task<IActionResult> DevoteeCheckOutReportList(DateTime dateValue, string typeofreport, string reportname,string dataType)
    {
        return typeofreport switch
        {
            "screen" => await DevoteeCheckOutReportListData(dateValue,typeofreport,string.Empty, dataType),
            "pdf" => await DevoteeCheckOutReportListData(dateValue, typeofreport, reportname, dataType),
            "excel" =>await ExportDevoteeCheckOutToExcel(dateValue, dataType),
            _ => RedirectToAction("Index", "Home")
        };
    }

    private async Task<IActionResult> DevoteeCheckOutReportListData(DateTime dateValue, string typeofreport, string reportname, string dataType)
    {
        var reportResult = await _reportService.DevoteeCheckOutReportList(dateValue, typeofreport, dataType);
        if (reportResult.HasData)
            if (reportname == string.Empty)
                return File(reportResult.DataArray, "application/pdf");
            else
                return File(reportResult.DataArray, "application/pdf", $"{reportname}.pdf");
        else
            return Content("No data available for report.");
    }

    public async Task<IActionResult> AllocationViewer()
    {
        return await AllocationViewer(DateTime.MinValue, "screen", "List");
    }
    private async Task<IActionResult> RoomsAllocationPdfPreview(DateTime dateValue, string fileName, string controller)
    {
        var pdfBytes = await _reportService.RoomsAllocationPdfPreview(dateValue);
        if (fileName == string.Empty)
            return ShowScreenView(pdfBytes,"Allocation List Report",controller);
        else
            return File(pdfBytes, "application/pdf", fileName + ".pdf");
    }
private async Task<IActionResult> RoomsAllocationPdfPreviewAllocated(DateTime dateValue, string fileName)
    {
        var pdfBytes = await _reportService.RoomsAllocationPdfPreview(dateValue);
        if (fileName == string.Empty)
            return File(pdfBytes, "application/pdf");
        else
            return File(pdfBytes, "application/pdf", fileName + ".pdf");
    }
    private async Task<IActionResult> RoomsAllocationDetailPdfPreview(DateTime dateValue, string fileName, string controller)
    {
        var pdfBytes = await _reportService.RoomsAllocationDetailPdfPreview(dateValue);
        if (fileName == string.Empty)
            return ShowScreenView(pdfBytes, "Allocation Detail Report", controller);
        else
            return File(pdfBytes, "application/pdf", fileName + ".pdf");
    }
private async Task<IActionResult> RoomsAllocationDetailPdfPreviewAlloted(DateTime dateValue, string fileName)
    {
        var pdfBytes = await _reportService.RoomsAllocationDetailPdfPreview(dateValue);
        if (fileName == string.Empty)
            return File(pdfBytes, "application/pdf");
        else
            return File(pdfBytes, "application/pdf", fileName + ".pdf");
    }
    public async Task<IActionResult> CheckOutViewer()
    {
        return await CheckOutViewer(DateTime.MinValue, "screen");
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
    #endregion



    private IActionResult ShowScreenView(byte[] pdfBytes, string title, string controllerName)
    {
        string base64 = Convert.ToBase64String(pdfBytes);
        ViewBag.PdfSource = $"data:application/pdf;base64,{base64}";
        ViewBag.Title = title;
        controllerName = controllerName == "Category" ? "DevoteeCategory" : controllerName;

        @ViewBag.BackController = controllerName;
        return View("ReportViewer");
    }
    private IActionResult ShowView(byte[] pdfBytes,string fileName)
    {
        string base64 = Convert.ToBase64String(pdfBytes);
        return File(pdfBytes, "application/pdf",fileName + ".pdf");
    }
    
    
    private async Task<IActionResult> DevoteeCheckInReportList(DateTime dateValue, string typeofreport, string reportname)
    {
        return typeofreport switch
        {
            "screen" => await DevoteeCheckInReportListData(dateValue, typeofreport, string.Empty),
            "pdf" => await DevoteeCheckInReportListData(dateValue, typeofreport, reportname),
            "excel" =>await ExportDevoteeCheckInToExcel(dateValue),
            _ => RedirectToAction("Index", "Home")
        };
    }

    private async Task<IActionResult> DevoteeCheckInReportListData(DateTime dateValue, string typeofreport,string reportname)
    {
        var reportResult = await _reportService.DevoteeCheckInReportList(dateValue, typeofreport);
        if (reportResult.HasData)
            if (reportname == string.Empty)
                return File(reportResult.DataArray, "application/pdf");
            else
                return File(reportResult.DataArray, "application/pdf", $"{reportname}.pdf");
            else
                return Content("No data available for report.");
    }
    public async Task<IActionResult> ExportDevoteeCheckInToExcel(DateTime dateValue)
    {
        var reportResult =await _reportService.ExportDevoteeCheckInToExcel(dateValue);
        if (reportResult.HasData)
        {
            return File(reportResult.DataStream,
           "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
           "DevoteeCheckin.xlsx");
        }
        else
            return Content("No data available for report.");

    }
    private async Task<byte[]> PrintGenericReport(string type)
    {
        return await _reportService.PrintGenericReport(type);
    }


    [HttpPost]
    public async Task<IActionResult> ShowReport(string reportType, string actionButton, int Id = 0)
    {
      
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
                
                return actionButton switch
                {
                    "Screen" => ShowScreenView(await _reportService.DevoteeListtoPdf(devotees), "Devotee List - Filtered", "Devotee"),
                    "Pdf" => File(await _reportService.DevoteeListtoPdf(devotees), "application/pdf", "DevoteeList_Filter.pdf"),
                    "Excel" =>await ExportDevoteeListReportToExcel(devotees), // download Excel
                    _ => Content("Invalid action")
                };
            case "DevoteeDetail":
                {
                    return actionButton switch
                    {
                        "Screen" => ShowScreenView(await _reportService.DevoteeDetailToPdf(Id), "Devotee Detail", "Devotee"),
                        "Pdf" => File(await _reportService.DevoteeDetailToPdf(Id), "application/pdf", "DevoteeDetail_" + Id + ".pdf"),
                        "Excel" =>await ExportDevoteeDetailToExcel(Id, "Devotee Detail"),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
            case "DevoteeCategory":
            case "Building":
            case "Block":
            case "Floor":
                {
                    return actionButton switch
                    {
                        "Screen" => ShowScreenView(await PrintGenericReport(reportType),reportType + " List ", reportType),
                        "Pdf" => ShowView(await PrintGenericReport(reportType), reportType),
                        "Excel" =>await ExportGenericItemsToExcel(reportType),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
            case "Reservation":
                {
                    string Subject = $"Rooms Allocation List / Detail Report (All Dates)";
                    return actionButton switch
                    {
                        "ScreenList" => await RoomsAllocationPdfPreview(DateTime.MinValue, string.Empty, reportType),
                        "PdfList" => await RoomsAllocationPdfPreview(DateTime.MinValue, "Allocation-List", string.Empty),
                        "ExcelList" => await ExportRoomAllocationDateWiseToExcel(DateTime.MinValue, Subject),
                        "ScreenDetail" => await RoomsAllocationDetailPdfPreview(DateTime.MinValue, string.Empty, reportType),
                        "PdfDetail" => await RoomsAllocationDetailPdfPreview(DateTime.MinValue, "Allocation-Detail.pdf", string.Empty),
                        "ExcelDetail" => await ExportRoomAllocationDetailDateWiseToExcel(DateTime.MinValue, Subject),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
            case "Room":
               
                return actionButton switch
                {
                    "Screen" => ShowScreenView(await _reportService.RoomsListToPdf("Room List"), "Room List","Room"),
                    "Pdf" => File(await _reportService.RoomsListToPdf("Room List"), "application/pdf", $"RoomsReport.pdf"),
                    "Excel" =>await ExportRoomsListToExcel("Room List"),
                    _ => RedirectToAction("Index", "Home")
                };
            default:
                return RedirectToAction("Index", "Home");
        }
    }

   


    #region Export To Excel Methods
    [HttpPost]
    public async Task<IActionResult> AllocationViewer(DateTime dateValue, string typeofreport = "screen", string reportformat = "")
    {
        if (typeofreport == "" || dateValue == DateTime.MinValue)
            return View();
        else
        {
            string Subject = $"Rooms Allocation " + reportformat + " Report (Up to " + dateValue.Date.ToString("dd - MMM - yyyy") + ")" ;
            return reportformat switch
            {
                "List" =>
                        typeofreport switch
                        {
                            "screen" => await RoomsAllocationPdfPreviewAllocated(dateValue, string.Empty),
                            "pdf" => await RoomsAllocationPdfPreviewAllocated(dateValue, "Allocation-List"),
                            "excel" => await ExportRoomAllocationDateWiseToExcel(dateValue, Subject),
                            _ => RedirectToAction("Index", "Home")
                        },
                "Detail" =>
                        typeofreport switch
                        {
                            "screen" => await RoomsAllocationDetailPdfPreviewAlloted(dateValue, string.Empty),
                            "pdf" => await RoomsAllocationDetailPdfPreviewAlloted(dateValue, "Allocation-List"),
                            "excel" => await ExportRoomAllocationDetailDateWiseToExcel(dateValue, Subject),
                            _ => RedirectToAction("Index", "Home")
                        },
                _ => RedirectToAction("Index", "Home")
            };
        }
        ;
    }
    public async Task<IActionResult> ExportDevoteeCheckOutToExcel(DateTime dateValue, string dataType)
    {
        string Subject = "Devotee Check-Out List as On: " + dateValue.Date.ToString("dd - MMM - yyyy") + " - " +dataType;
        var stream =await _reportService.ExportDevoteeCheckOutToExcel(dateValue, Subject, dataType);

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "DevoteeCheckOutReport.xlsx");
    }
    public async Task<IActionResult> ExportRoomAllocationDetailDateWiseToExcel(DateTime dateValue, string subject)
    {
        var stream = await _reportService.ExportRoomAllocationDetailDateWiseToExcel(dateValue, subject);
        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "RoomAllocationDateWise.xlsx");
    }
    public async Task<IActionResult> ExportDevoteeListReportToExcel(List<DevoteeReportDTO> devotees)
    {
        var stream =await _reportService.ExportDevoteeListReportToExcel(devotees);

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "DevoteeList_Filtered.xlsx");
    }
    public async Task<IActionResult> ExportGenericItemsToExcel(string itemType)
    {
        var stream = await _reportService.ExportGenericItemsToExcel(itemType);

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            itemType + "_List.xlsx");
    }
    public async Task<IActionResult> ExportRoomsListToExcel(string subject)
    {
        var stream = await _reportService.ExportRoomsListToExcel(subject);

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "RoomsList.xlsx");
    }
    public async Task<IActionResult> ExportDevoteeDetailToExcel(int Id, string subject)
    {
        var stream = await _reportService.ExportDevoteeDetailToExcel(Id, subject);

        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            $"Devotee_{Id}_Detail.xlsx");
    }
    public async Task<IActionResult> ExportRoomAllocationDateWiseToExcel(DateTime dateValue, string subject)
    {
        var stream =await _reportService.ExportRoomAllocationDateWiseToExcel(dateValue, subject);
        return File(stream,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "RoomAllocationDateWise.xlsx");
    }
    
    #endregion
}


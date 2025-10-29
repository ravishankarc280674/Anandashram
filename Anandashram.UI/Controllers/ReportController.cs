using DocumentFormat.OpenXml.Office2010.Excel;
using FastReport;
using FastReport.Data;

using FastReport.Web;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Composition;
using System.IO;

namespace Anandashram.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IRoom _roomRepo;
        private readonly IBlock _blockrepo;
        private readonly IBuilding _buildingrepo;
        private readonly IFloor _floorrepo;
        private readonly IReservation _reservationrepo;
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
            _reservationrepo = reservationrepo;
            _devoteerepo = devoteerepo;
            _devotecategoryrepo = devotecatcategoryrepo;
            _companyrepo = companyrepo;
        }

        public IActionResult ReportViewer()
        {
            return ReportViewer("", "");
        }

        [HttpPost]
        public IActionResult ReportViewer(string report = "", string typeofreport = "")
        {
            if (report == "" || typeofreport == "")
                return View();
            else
            {
                string ReportName = string.Empty;
                WebReport wr = new WebReport();
                wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "General.frx"));
                List<Company> companies = new List<Company>();
                companies.Add(_companyrepo.CompanyDetails());
                wr.Report.RegisterData(companies, "CompanyRef");
                switch (report)
                {
                    case "dc":
                        wr.Report.RegisterData(_devotecategoryrepo.GetDevoteeCategories(), "GeneralRef");
                        wr.Report.SetParameterValue("Title", "Devotee Categories");
                        ReportName = "Devotee Categories";
                        break;
                    case "building":
                        wr.Report.RegisterData(_buildingrepo.GetBuildings(), "GeneralRef");
                        wr.Report.SetParameterValue("Title", "Buildings");
                        ReportName = "Buildings";
                        break;
                    case "block":
                        wr.Report.RegisterData(_blockrepo.GetBlocks(), "GeneralRef");
                        wr.Report.SetParameterValue("Title", "Blocks");
                        ReportName = "Blocks";
                        break;
                    case "floor":
                        wr.Report.RegisterData(_floorrepo.GetFloors(), "GeneralRef");
                        wr.Report.SetParameterValue("Title", "Floors");
                        ReportName = "Floors";
                        break;
                }
                ViewBag.WebReport = wr;
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

        public IActionResult RoomDetailsViewer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoomDetailsViewer(string report = "", string typeofreport = "")
        {
            if (report == "" || typeofreport == "")
                return View();
            else
            {
                try
                {
                    WebReport wr = new WebReport();
                    if (report == "List")
                        wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "RoomAllocation.frx"));
                    else
                    wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "RoomAllocation-detail.frx"));

                    List<Company> companies = new List<Company>();
                    List<Room> roomList = await _roomRepo.GetAllRoomReservations();
                    companies.Add(_companyrepo.CompanyDetails());
                    wr.Report.RegisterData(companies, "CompanyRef");
                    wr.Report.RegisterData(roomList, "RoomAllocationRef");
                    if (report == "Detail")
                    {
                        wr.Report.GetDataSource("RoomAllocationRef").Enabled = true;
                        // This line enables nested collections (Details)
                        wr.Report.Dictionary.RegisterBusinessObject(roomList, "RoomAllocationRef", 10, true);
                    }
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
                            pDFSimpleExport.Subject = "Room Availability - List";
                            MemoryStream ms = new MemoryStream();
                            wr.Report.Export(pDFSimpleExport, ms);
                            wr.Report.Dispose();
                            pDFSimpleExport.Dispose();
                            ms.Position = 0;
                            return File(ms, "application/pdf", "Room Availability - List.pdf");
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }

        public IActionResult DevoteeReportViewer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DevoteeReportViewer(string typeofreport = "")
        {
            WebReport wr = new WebReport();
            wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeList.frx"));
            List<Company> companies = new List<Company>();
            companies.Add(_companyrepo.CompanyDetails());
            wr.Report.RegisterData(companies, "CompanyRef");
            wr.Report.RegisterData(await _devoteerepo.GetAllDevotees(false), "DevoteesRef");
           
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
                    pDFSimpleExport.Subject = "Room Availability - List";
                    MemoryStream ms = new MemoryStream();
                    wr.Report.Export(pDFSimpleExport, ms);
                    wr.Report.Dispose();
                    pDFSimpleExport.Dispose();
                    ms.Position = 0;
                    return File(ms, "application/pdf", "DevoteeList.pdf");
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

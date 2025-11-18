using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using FastReport;
using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System;
using System.Collections.Generic;
using System.Composition;
using System.IO;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
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
        public async Task<IActionResult> ReportViewer(DateTime dateValue, string typeofreport = "")
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

        [HttpPost]
        public async Task<IActionResult> RoomViewer(DateTime dateValue, string typeofreport = "", string reportformat = "list")
        {
            if (typeofreport == "" || dateValue == DateTime.MinValue)
                return View();

            WebReport wr = new WebReport();
            string reportPath = Path.Combine(_env.ContentRootPath, "Reports",
                reportformat == "list" ? "RoomAllocation.frx" : "RoomAllocationDetail.frx");

            wr.Report.Load(reportPath);

            // Register Company
            var company = _companyrepo.CompanyDetails();
            wr.Report.RegisterData(new List<Company> { company }, "Company");
            wr.Report.GetDataSource("Company").Enabled = true;

            // Register Rooms (master) — each Room has List<ReservationReportDTO> Reservations
            List<RoomReportDTO> roomList = await _roomRepo.GetRoomsWithReservationsUpToDateAsync(dateValue);
            wr.Report.RegisterData(roomList, "Rooms");
            wr.Report.GetDataSource("Rooms").Enabled = true;

            // IMPORTANT: enable the child collection datasource (OpenSource expects this)
            // Use this *exact* name because the FRX below references Rooms.Reservations
            wr.Report.GetDataSource("Rooms.Reservations").Enabled = true;

            // Always set DatePassed (FRX references it)
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

        public async Task<IActionResult> ReportViewer()
        {
            return await ReportViewer(DateTime.MinValue, "screen");
        }
        public async Task<IActionResult> RoomViewer()
        {
            return await RoomViewer(DateTime.MinValue, "screen");
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
                        wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "RoomList.frx"));
                        wr.Report.RegisterData(companies, "Company");
                        wr.Report.RegisterData(await _roomRepo.GetRoomsAsync(), "Rooms");
                        //wr.Report.SetParameterValue("Title", "Rooms");
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
    }
}

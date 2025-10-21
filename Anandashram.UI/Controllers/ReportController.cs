using FastReport;
using FastReport.Data;
using FastReport.Web;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

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
            return View();
            //WebReport wr = new WebReport();
            //List<Company> companies = new List<Company>();
            //companies.Add(_companyrepo.CompanyDetails());
            //List<DevoteeCategory> DevoteeCategories = _devotecategoryrepo.GetDevoteeCategories();
            //List<Building> Buildings = _buildingrepo.GetBuildings().ToList();
            //wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeCategories.frx"));
            //wr.Report.RegisterData(Buildings, "GeneralRef");
            //wr.Report.RegisterData(companies, "CompanyRef");
            //ViewBag.WebReport = wr;
            // return View(wr);
            //if (wr.Report.Prepare())
            //{
            //    FastReport.Export.PdfSimple.PDFSimpleExport pDFSimpleExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
            //    pDFSimpleExport.ShowProgress = false;
            //    pDFSimpleExport.Subject = "Devotee Category";
            //    MemoryStream ms = new MemoryStream();
            //    wr.Report.Export(pDFSimpleExport, ms);
            //    wr.Report.Dispose();
            //    pDFSimpleExport.Dispose();
            //    ms.Position = 0;
            //    return File(ms, "application/pdf", "DevoteeCategory.pdf");
            //}
            //else
            //{
            //    return null;
            //}
        }
        [HttpPost]
        public IActionResult ShowReport(string report, string typeofreport)
        {
            WebReport wr = new WebReport();
            wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeCategories.frx"));
            List<Company> companies = new List<Company>();
            companies.Add(_companyrepo.CompanyDetails());
            wr.Report.RegisterData(companies, "CompanyRef");
            switch (report)
            {
                case "dc":
                    wr.Report.RegisterData(_devotecategoryrepo.GetDevoteeCategories(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Devotee Categories");
                    break;
                case "building":
                    wr.Report.RegisterData(_buildingrepo.GetBuildings(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Buildings");
                    break;
                case "block":
                    wr.Report.RegisterData(_blockrepo.GetBlocks(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Blocks");
                    break;
                case "floor":
                    wr.Report.RegisterData(_floorrepo.GetFloors(), "GeneralRef");
                    wr.Report.SetParameterValue("Title", "Floors");
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
                    pDFSimpleExport.Subject = "Devotee Category";
                    MemoryStream ms = new MemoryStream();
                    wr.Report.Export(pDFSimpleExport, ms);
                    wr.Report.Dispose();
                    pDFSimpleExport.Dispose();
                    ms.Position = 0;
                    return File(ms, "application/pdf", "DevoteeCategory.pdf");
                }
                else
                {
                    return null;
                }
            }

        }
    }
}

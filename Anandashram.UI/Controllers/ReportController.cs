using FastReport;
using FastReport.Data;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public ReportController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult ReportViewer()
        {
            FastReport.Utils.RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));
            WebReport wr = new WebReport();
            wr.Report.Load(Path.Combine(_env.ContentRootPath, "Reports", "DevoteeCategory.frx"));
            wr.Report.Dictionary.Connections[0].ConnectionString = @"Data Source=DESKTOP-GL9HVMN\SQLEXPRESS;Initial Catalog=Anandashram;Integrated Security=True;Persist Security Info=False";
            ViewBag.WebReport = wr;
            return View(wr);
        }
    }
}

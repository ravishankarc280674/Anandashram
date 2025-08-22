using Anandashram.BAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class FloorController : Controller
    {
        private readonly ILogger<FloorController> _logger;
        private readonly IInfraStructureBO _infrastructure;
        const int PAGESIZE = 10;

        public FloorController(ILogger<FloorController> logger, IInfraStructureBO infrastructure)
        {
            _logger = logger;
            _infrastructure = infrastructure;
        }

        // GET: HotelBlocks
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchText, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchText;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) || sortOrder.Equals("Name") ? "name_desc" : "";

            ViewData["CurrentFilter"] = searchText;
            ViewData["CurrentSort"] = sortOrder;

            return View(await _infrastructure.GetFloorList(sortOrder, currentFilter, searchText, pageNumber, PAGESIZE));
        }

        // GET: FloorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FloorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FloorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FloorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FloorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FloorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FloorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

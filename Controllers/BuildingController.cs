using Anandashram.BAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class BuildingController : Controller
    {
        private readonly ILogger<BlockController> _logger;
        private readonly IInfraStructureBO _infrastructure;
        const int PAGESIZE = 10;

        public BuildingController(ILogger<BlockController> logger, IInfraStructureBO infrastructure)
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

            return View(await _infrastructure.GetBuildingList(sortOrder, currentFilter, searchText, pageNumber, PAGESIZE));
        }

        // GET: BuildingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuildingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuildingController/Create
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


        [HttpPost]
        public IActionResult UpdateDevoteeCaegory(int id, string name)
        {
            //var product = _.FirstOrDefault(p => p.Id == id);
            //if (product != null)
            //{
            //    product.Name = name;
            //    product.Price = price;
            //    return Json(new { success = true }); // Return success message
            //}
            //return Json(new { success = false, message = "Product not found." });

            return View();
            //}
        }
        // GET: BuildingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuildingController/Edit/5
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

        // GET: BuildingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuildingController/Delete/5
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class BuildingController : Controller
    {
        // GET: BuildingController
        public ActionResult Index()
        {
            return View();
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

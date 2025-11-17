using Anandashram.Data;
using Anandashram.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    [Authorize]
    public class BuildingController : Controller
    {
        private readonly IBuilding _buildingRepo;

        public BuildingController(IBuilding buildingRepo)
        {
            _buildingRepo = buildingRepo;
        }

        // GET: Building
        public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5)
        {
            if (pg < 1) pg = 1;

            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = PageSize;
            ViewBag.SearchText = SearchText;
            TempData["CurrentPage"] = pg;
            var BuildingList = await _buildingRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(BuildingList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Building", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
            ViewBag.ReportType = "Building";

            return View(BuildingList);
        }

        private List<SelectListItem> GetPageSizes(int selectedPageSize = 5)
        {
            var pagesSizes = new List<SelectListItem>();

            if (selectedPageSize == 5)
                pagesSizes.Add(new SelectListItem("5", "5", true));
            else
                pagesSizes.Add(new SelectListItem("5", "5"));

            for (int lp = 10; lp <= 100; lp += 10)
            {
                if (lp == selectedPageSize)
                { pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
                else
                    pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
            }

            return pagesSizes;
        }

        // GET: Building/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var building = await _buildingRepo.GetBuilding(id);
            if (building == null)
            {
                return NotFound();
            }

            return View(building);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {

            Building building = new Building();
            if (id == 0)
            {
                building.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                building.CreatedDate = DateTime.Now;
                return View(building);
            }
            else
            {
                building = await _buildingRepo.GetBuilding(id);
                TempData.Keep();
                if (building == null)
                {
                    return NotFound();
                }
                building.ModifiedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                building.ModifiedDate = DateTime.Now;
            }
            return View(building);
        }
        [HttpPost]
        
        
        //  [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(Building building,int id, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    building = await _buildingRepo.Create(building);
                }
                else
                {
                    try
                    {

                        building = await _buildingRepo.Edit(building);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (_buildingRepo.GetBuilding(building.Id) == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _buildingRepo.GetBuildings()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", building) });
        }

        private void BuildData(int pg, int pageSize, string sortExpression, string searchText)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = pageSize;
            ViewBag.SearchText = searchText;
            TempData["CurrentPage"] = pg;
        }

        [HttpPost]
        
        //[NoDirectAccess]
        public async Task<IActionResult> Delete(Building building, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);
            building = await _buildingRepo.Delete(building);
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _buildingRepo.GetBuildings()) });
        }
    }
}

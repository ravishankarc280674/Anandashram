
using Anandashram.UI.Tools.Models;
using Microsoft.IdentityModel.Tokens;
using System.Drawing.Printing;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    public class DevoteeCategoryController : Controller
    {
        //  private readonly ApplicationDbContext _context;
        private readonly IDevoteeCategory _devoteeCategoryRepo;

        public DevoteeCategoryController(IDevoteeCategory devoteeCategoryRepo)
        {
            // _context = context;
            _devoteeCategoryRepo = devoteeCategoryRepo;
        }

        // GET: DevoteeCategory
        public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5)
        {
            if (pg < 1) pg = 1;

            SortModel sortModel = new SortModel();//ApplySort(sortExpression);
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = PageSize;
            ViewBag.SearchText = SearchText;
            TempData["CurrentPage"] = pg;
            var DevoteeCategoryList =await _devoteeCategoryRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(DevoteeCategoryList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "DevoteeCategory", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
            return View(DevoteeCategoryList);
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

        public async Task<IActionResult> Details(int id)
        {
            var devoteeCategory = await _devoteeCategoryRepo.GetDevoteeCategory(id);
            if (devoteeCategory == null)
            {
                return NotFound();
            }

            return View(devoteeCategory);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
                DevoteeCategory devoteeCategory = new DevoteeCategory();
            if (id == 0)
            {
                devoteeCategory.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                devoteeCategory.CreatedDate = DateTime.Now;
                return View(devoteeCategory);
            }
            else
            { 
                devoteeCategory = await _devoteeCategoryRepo.GetDevoteeCategory(id);
                TempData.Keep();
                if (devoteeCategory == null)
                {
                    return NotFound();
                }
                devoteeCategory.ModifiedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                devoteeCategory.ModifiedDate = DateTime.Now;
            }

            return View(devoteeCategory);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
      //  [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id, DevoteeCategory devoteeCategory, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    devoteeCategory = await _devoteeCategoryRepo.Create(devoteeCategory);
                }
                else
                {
                    try
                    {

                        devoteeCategory = await _devoteeCategoryRepo.Edit(devoteeCategory);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (_devoteeCategoryRepo.GetDevoteeCategory(devoteeCategory.Id) == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this,"_ViewAll", _devoteeCategoryRepo.GetDevoteeCategories()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", devoteeCategory) });
        }

        [HttpPost]
        //[NoDirectAccess]
        public async Task<IActionResult> Delete(DevoteeCategory devoteeCategory, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            devoteeCategory = await _devoteeCategoryRepo.Delete(devoteeCategory);
                return Json(new { html = Helper.RenderRazorViewToString(this,"_ViewAll", _devoteeCategoryRepo.GetDevoteeCategories()) });
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
    }
}

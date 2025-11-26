namespace Anandashram.Controllers
{
    [Authorize]
    public class DevoteeCategoryController : Controller
    {
        private readonly IDevoteeCategoryService _devoteeCategoryService;

        public DevoteeCategoryController(IDevoteeCategoryService devoteeCategoryService)
        {
            _devoteeCategoryService = devoteeCategoryService;
        }

        // GET: DevoteeCategory
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

            var DevoteeCategoryList = await _devoteeCategoryService.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(DevoteeCategoryList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "DevoteeCategory", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
            ViewBag.ReportType = "DevoteeCategory";

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
                    pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true));
                else
                    pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
            }

            return pagesSizes;
        }

        // GET: DevoteeCategory/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var devoteeCategory = await _devoteeCategoryService.GetDevoteeCategory(id);
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
                devoteeCategory = await _devoteeCategoryService.GetDevoteeCategory(id);
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
        public async Task<IActionResult> AddOrEdit(DevoteeCategory devoteeCategory, int id, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var result = await _devoteeCategoryService.Create(devoteeCategory);
                    if (!result.Success)
                    {
                        // Service reported validation/error
                        ModelState.AddModelError(string.Empty, result.Message);
                        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", devoteeCategory) });
                    }

                    // Created OK
                    var all = _devoteeCategoryService.GetDevoteeCategories();
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
                }
                else
                {
                    try
                    {
                        var result = await _devoteeCategoryService.Edit(devoteeCategory);
                        if (!result.Success)
                        {
                            ModelState.AddModelError(string.Empty, result.Message);
                            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", devoteeCategory) });
                        }

                        var all = _devoteeCategoryService.GetDevoteeCategories();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        // replicate original behavior
                        var exists = await _devoteeCategoryService.GetDevoteeCategory(devoteeCategory.Id);
                        if (exists == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }

            // model invalid
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", devoteeCategory) });
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
        public async Task<IActionResult> Delete(DevoteeCategory devoteeCategory, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            var result = await _devoteeCategoryService.Delete(devoteeCategory);
            if (!result.Success)
            {
                // return view with error message (or JSON with error)
                ModelState.AddModelError(string.Empty, result.Message);
            }

            var all = _devoteeCategoryService.GetDevoteeCategories();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
        }
    }
}

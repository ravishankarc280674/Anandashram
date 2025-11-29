namespace Anandashram.Controllers;

[Authorize]
public class FloorController : Controller
{
    private readonly IFloorService _floorService;

    public FloorController(IFloorService floorService)
    {
        _floorService = floorService;
    }

    // GET: Floor
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

        var FloorList = await _floorService.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

        var pager = new PageModel(FloorList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Floor", SearchText = SearchText };
        pager.SortExpression = sortExpression;
        this.ViewBag.Pager = pager;
        this.ViewBag.PageSizes = GetPageSizes(PageSize);
        ViewBag.ReportType = "Floor";

        return View(FloorList);
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

    // GET: Floor/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var floor = await _floorService.GetFloor(id);
        if (floor == null)
        {
            return NotFound();
        }

        return View(floor);
    }

    public async Task<IActionResult> AddOrEdit(int id = 0)
    {
        Floor floor = new Floor();
        if (id == 0)
        {
            floor.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            floor.CreatedDate = DateTime.Now;
            return View(floor);
        }
        else
        {
            floor = await _floorService.GetFloor(id);
            TempData.Keep();
            if (floor == null)
            {
                return NotFound();
            }
            floor.ModifiedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            floor.ModifiedDate = DateTime.Now;
        }
        return View(floor);
    }

    [HttpPost]
    public async Task<IActionResult> AddOrEdit(Floor floor, int id, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
    {
        BuildData(pg, pageSize, sortExpression, searchText);

        if (ModelState.IsValid)
        {
            if (id == 0)
            {
                var result = await _floorService.Create(floor);
                if (!result.Success)
                {
                    // Service reported validation/error
                    ModelState.AddModelError(string.Empty, result.Message);
                    return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", floor) });
                }

                // Created OK
                var all =await _floorService.GetFloors();
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
            }
            else
            {
                try
                {
                    var result = await _floorService.Edit(floor);
                    if (!result.Success)
                    {
                        ModelState.AddModelError(string.Empty, result.Message);
                        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", floor) });
                    }

                    var all =await _floorService.GetFloors();
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
                }
                catch (DbUpdateConcurrencyException)
                {
                    // replicate original behavior
                    var exists = await _floorService.GetFloor(floor.Id);
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
        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", floor) });
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
    public async Task<IActionResult> Delete(Floor floor, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
    {
        BuildData(pg, pageSize, sortExpression, searchText);

        var result = await _floorService.Delete(floor);
        if (!result.Success)
        {
            // return view with error message (or JSON with error)
            ModelState.AddModelError(string.Empty, result.Message);
        }

        var all =await _floorService.GetFloors();
        return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
    }
}

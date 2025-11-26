namespace Anandashram.Controllers
{
    [Authorize]
    public class BlockController : Controller
    {
        private readonly IBlockService _blockService;

        public BlockController(IBlockService blockService)
        {
            _blockService = blockService;
        }

        // GET: Block
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

            var BlockList = await _blockService.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(BlockList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Block", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
            ViewBag.ReportType = "Block";

            return View(BlockList);
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

        // GET: Block/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var block = await _blockService.GetBlock(id);
            if (block == null)
            {
                return NotFound();
            }

            return View(block);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            Block block = new Block();
            if (id == 0)
            {
                block.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                block.CreatedDate = DateTime.Now;
                return View(block);
            }
            else
            {
                block = await _blockService.GetBlock(id);
                TempData.Keep();
                if (block == null)
                {
                    return NotFound();
                }
                block.ModifiedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                block.ModifiedDate = DateTime.Now;
            }
            return View(block);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrEdit(Block block, int id, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var result = await _blockService.Create(block);
                    if (!result.Success)
                    {
                        // Service reported validation/error
                        ModelState.AddModelError(string.Empty, result.Message);
                        return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", block) });
                    }

                    // Created OK
                    var all = _blockService.GetBlocks();
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
                }
                else
                {
                    try
                    {
                        var result = await _blockService.Edit(block);
                        if (!result.Success)
                        {
                            ModelState.AddModelError(string.Empty, result.Message);
                            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", block) });
                        }

                        var all = _blockService.GetBlocks();
                        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        // replicate original behavior
                        var exists = await _blockService.GetBlock(block.Id);
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
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", block) });
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
        public async Task<IActionResult> Delete(Block block, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            var result = await _blockService.Delete(block);
            if (!result.Success)
            {
                // return view with error message (or JSON with error)
                ModelState.AddModelError(string.Empty, result.Message);
            }

            var all = _blockService.GetBlocks();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", all) });
        }
    }
}

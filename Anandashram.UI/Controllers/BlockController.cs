namespace Anandashram.Controllers
{
    [Authorize]
    public class BlockController : Controller
    {
        private readonly IBlock _blockRepo;
        private ILogger<BlockController> _logger;

        public BlockController(IBlock blockRepo, ILogger<BlockController> logger)
        {
            _logger = logger;
            _blockRepo = blockRepo;
        }

        // GET: Block
        public async Task<IActionResult> Index(string sortExpression = "", string searchText = "", int pg = 1, int pageSize = 5)
        {
            if (pg < 1) pg = 1;
            SortModel sortModel = ApplySorting(sortExpression); // Consolidated sorting logic
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = pageSize;
            ViewBag.SearchText = searchText;
            TempData["CurrentPage"] = pg;

            var blockList = await _blockRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, searchText, pg, pageSize);
            var pager = new PageModel(blockList.TotalRecords, pg, pageSize)
            {
                Action = "Index",
                Controller = "Block",
                SearchText = searchText,
                SortExpression = sortExpression
            };
            ViewBag.Pager = pager;
            ViewBag.PageSizes = GetPageSizes(pageSize);

            ViewBag.ReportType = "Block";
            return View(blockList);
        }

        // Helper method for sorting logic
        private SortModel ApplySorting(string sortExpression)
        {
            var sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.ApplySort(sortExpression);
            return sortModel;
        }

        // Helper method to get page sizes
        private List<SelectListItem> GetPageSizes(int selectedPageSize = 5)
        {
            var pageSizes = new List<SelectListItem>
            {
                new SelectListItem("5", "5", selectedPageSize == 5)
            };
            for (int i = 10; i <= 100; i += 10)
            {
                pageSizes.Add(new SelectListItem(i.ToString(), i.ToString(), i == selectedPageSize));
            }
            return pageSizes;
        }

        // GET: Block/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var block = await _blockRepo.GetBlock(id);
            if (block == null)
            {
                return NotFound();
            }
            return View(block);
        }

        // GET: Block/AddOrEdit
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            Block block = new Block();
            if (id == 0)
            {
                block.CreatedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);
                block.CreatedDate = DateTime.Now;
                return View(block);
            }
            else
            {
                block = await _blockRepo.GetBlock(id);
                TempData.Keep();
                if (block == null)
                {
                    return NotFound();
                }
                block.ModifiedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);
                block.ModifiedDate = DateTime.Now;
            }
            return View(block);
        }

        // POST: Block/AddOrEdit
        [HttpPost]
        public async Task<IActionResult> AddOrEdit(Block block, int id, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            if (ModelState.IsValid)
            {
                try
                {
                    if (id == 0)
                    {
                        block = await _blockRepo.Create(block);
                    }
                    else
                    {
                        block = await _blockRepo.Edit(block);
                    }

                    var html = Helper.RenderRazorViewToString(this, "_ViewAll", _blockRepo.GetBlocks());
                    return Json(new { isValid = true, html });
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Handle concurrency issue
                    if (_blockRepo.GetBlock(block.Id) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception and show a friendly error page
                    _logger.LogError(ex, "Error occurred while saving the block.");
                    return View("Error");
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", block) });
        }

        // POST: Block/Delete
        [HttpPost]
        public async Task<IActionResult> Delete(Block block, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            try
            {
                block = await _blockRepo.Delete(block);
                var html = Helper.RenderRazorViewToString(this, "_ViewAll", _blockRepo.GetBlocks());
                return Json(new { html });
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "Error occurred while deleting the block.");
                return Json(new { success = false, message = "Error occurred during deletion" });
            }
        }

        // Helper method to build pagination and sorting data
        private void BuildData(int pg, int pageSize, string sortExpression, string searchText)
        {
            SortModel sortModel = ApplySorting(sortExpression); // Reuse the sorting helper
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = pageSize;
            ViewBag.SearchText = searchText;
            TempData["CurrentPage"] = pg;
        }
    }
}

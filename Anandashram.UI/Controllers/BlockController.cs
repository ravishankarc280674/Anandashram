
using System.Drawing.Printing;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    public class BlockController : Controller
    {
      //  private readonly ApplicationDbContext _context;
        private readonly IBlock _blockRepo;

        public BlockController(IBlock blockRepo)
        {
           // _context = context;
            _blockRepo = blockRepo;
        }

        // GET: Block
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
            var BlockList =await _blockRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(BlockList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Block", SearchText = SearchText};
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
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
                { pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
                else
                    pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
            }

            return pagesSizes;
        }

        // GET: Block/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var block =await  _blockRepo.GetBlock(id);
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
                block = await _blockRepo.GetBlock(id);
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
        [ValidateAntiForgeryToken]
        //  [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(Block block, int id, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    block = await _blockRepo.Create(block);
                }
                else
                {
                    try
                    {

                        block = await _blockRepo.Edit(block);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (_blockRepo.GetBlock(block.Id) == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _blockRepo.GetBlocks()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", block) });
        }

        [HttpPost]
        //[NoDirectAccess]
        public async Task<IActionResult> Delete(Block block, int pg = 0, int pageSize = 5, string sortExpression = "", string searchText = "")
        {
            BuildData(pg, pageSize, sortExpression, searchText);

            block = await _blockRepo.Delete(block);
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _blockRepo.GetBlocks()) });
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

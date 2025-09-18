
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    public class FloorController : Controller
    {
        //  private readonly ApplicationDbContext _context;
        private readonly IFloor _floorRepo;

        public FloorController(IFloor floorRepo)
        {
            // _context = context;
            _floorRepo = floorRepo;
        }

        // GET: Floor
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
            var FloorList =await _floorRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);
            //int recSkip = (pg - 1) * PageSize;
            //List<Floor> retFloorList = FloorList.Skip(recSkip).Take(PageSize).ToList();

            var pager = new PageModel(FloorList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Floor", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
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
                { pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
                else
                    pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
            }

            return pagesSizes;
        }

        // GET: Floor/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var floor =await _floorRepo.GetFloor(id);
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
                floor = await _floorRepo.GetFloor(id);
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
        [ValidateAntiForgeryToken]
        //  [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id, Floor floor)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    floor = await _floorRepo.Create(floor);
                }
                else
                {
                    try
                    {

                        floor = await _floorRepo.Edit(floor);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (_floorRepo.GetFloor(floor.Id) == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _floorRepo.GetFloors()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", floor) });
        }

        [HttpPost]
        //[NoDirectAccess]
        public async Task<IActionResult> Delete(Floor floor)
        {

            floor = await _floorRepo.Delete(floor);
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _floorRepo.GetFloors()) });
        }
    }
}

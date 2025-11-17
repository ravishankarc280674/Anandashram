
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    [Authorize]
    public class RoomController : Controller
    {
        //  private readonly ApplicationDbContext _context;
        private readonly IRoom _roomRepo;
        private readonly IBlock _blockrepo;
        private readonly IBuilding _buildingrepo;
        private readonly IFloor _floorrepo;

        public RoomController(IRoom roomRepo, IBlock blockrepo, IBuilding buildingrepo, IFloor floorrepo)
        { 
            // _context = context;
            _roomRepo = roomRepo;
            _blockrepo = blockrepo;
            _buildingrepo = buildingrepo;
            _floorrepo = floorrepo;
        }

        // GET: Room
        public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000,string view = "Grid" )
        {
            if (pg < 1) pg = 1;

            SortModel sortModel = new SortModel();//ApplySort(sortExpression);
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = PageSize;
            ViewBag.SearchText = SearchText;
            ViewBag.view = view;
            TempData["CurrentPage"] = pg;
            var RoomList = await _roomRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(RoomList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Room", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            pager.ViewType = view;
            this.ViewBag.Pager = pager;
            return View(RoomList);
        }

        public List<SelectListItem> GetBlocks()
        {
            var blocks =_blockrepo.GetBlocks().Select(m => new SelectListItem()
                                             {
                                                 Value = m.Id.ToString(),
                                                 Text = m.Name
                                             }).ToList();

            return blocks;
        }
        public  List<SelectListItem> GetBuildings()
        {
            var buildings = _buildingrepo.GetBuildings().Select(m => new SelectListItem()
            {
                Value = m.Id.ToString(),
                Text = m.Name
            }).ToList();

            return buildings;
        }
        public List<SelectListItem> GetFloors()
        {
            var floors =_floorrepo.GetFloors().Select(m => new SelectListItem()
            {
                Value = m.Id.ToString(),
                Text = m.Name
            }).ToList();

            return floors;
        }
      
        //private List<SelectListItem> GetPageSizes(int selectedPageSize = 5)
        //{
        //    var pagesSizes = new List<SelectListItem>();

        //    if (selectedPageSize == 5)
        //        pagesSizes.Add(new SelectListItem("5", "5", true));
        //    else
        //        pagesSizes.Add(new SelectListItem("5", "5"));

        //    for (int lp = 10; lp <= 100; lp += 10)
        //    {
        //        if (lp == selectedPageSize)
        //        { pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
        //        else
        //            pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
        //    }

        //    return pagesSizes;
        //}

        // GET: Room/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var room = await _roomRepo.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Room/Create
        public IActionResult Create()
        {
            Room room = new Room();
            ViewBag.BuildingId = GetBuildings();
            ViewBag.BlockId = GetBlocks();
            ViewBag.FloorId = GetFloors();
            room.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            room.CreatedDate = DateTime.Now;
            return View(room);
        }

        // POST: Room/Create
        [HttpPost][IgnoreAntiforgeryToken]
        
        public async Task<IActionResult> Create(Room room)
        {
            string errMessage = string.Empty;
            if (string.IsNullOrEmpty(room.Name))
            {
                errMessage = errMessage + "Room Name cannot be Blank";
            }
            if (ModelState.IsValid)
            {
                await _roomRepo.Create(room);
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Room/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.BuildingId = GetBuildings();
            ViewBag.BlockId = GetBlocks();
            ViewBag.FloorId = GetFloors();
            var room = await _roomRepo.GetRoom(id);
            TempData.Keep();
            if (room == null)
            {
                return NotFound();
            }
            room.ModifiedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            room.ModifiedDate = DateTime.Now;
            return View(room);
        }

        [HttpPost][IgnoreAntiforgeryToken]
        
        public async Task<IActionResult> Edit(int id, Room room)
        {
            bool bolret = false;
            string errMessage = "";
            if (string.IsNullOrEmpty(room.Name))
            {
                errMessage = errMessage + "Room Name cannot be Blank";
                ModelState.AddModelError("", errMessage);
            }
            if (ModelState.IsValid)
            {
                try
                {

                    if (_roomRepo.IsRoomNameExists(room.Name, room.Id) == true)
                        errMessage = errMessage + "Room Name " + room.Name + " Already Exists";

                    if (errMessage == "")
                    {
                        room = await _roomRepo.Edit(room);
                        TempData["SuccessMessage"] = room.Name + " - Room Saved Successfully";
                        bolret = true;
                    }
                }
                catch (Exception ex)
                {
                    errMessage = errMessage + " " + ex.Message;
                }

                int currentPage = 1;
                if (TempData["CurrentPage"] != null)
                    currentPage = (int)TempData["CurrentPage"];


                if (bolret == false)
                {
                    TempData["ErrorMessage"] = errMessage;
                    ModelState.AddModelError("", errMessage);
                    return View(room);
                }
                else
                    return RedirectToAction(nameof(Index), new { pg = currentPage });
            }
            return View(room);
        }

        // GET: Room/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Room room = await _roomRepo.GetRoom(id);
            TempData.Keep();
            return View(room);
        }

        [HttpPost][IgnoreAntiforgeryToken]
        public async Task<IActionResult> Delete(Room room)
        {
            try
            {
                room = await _roomRepo.Delete(room);
            }
            catch (Exception ex)
            {
                string errMessage = ex.Message;
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(room);
            }

            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

            TempData["SuccessMessage"] = "Room " + room.Name + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }
    }
}

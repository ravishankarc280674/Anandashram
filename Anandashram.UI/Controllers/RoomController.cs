using System.Threading.Tasks;

namespace Anandashram.Controllers;

[Authorize]
public class RoomController : Controller
{
    private readonly IRoomService _roomService;
    private readonly IBlockService _blockService;
    private readonly IBuildingService _buildingService;
    private readonly IFloorService _floorService;

    public RoomController(IRoomService roomService, IBlockService blockService, IBuildingService buildingService, IFloorService floorService)
    {
        _roomService = roomService;
        _blockService = blockService;
        _buildingService = buildingService;
        _floorService= floorService;
    }

    // GET: Room
    public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5000, string view = "Grid")
    {
        if (pg < 1) pg = 1;

        SortModel sortModel = new SortModel();
        sortModel.AddColumn("name");
        sortModel.AddColumn("description");
        sortModel.ApplySort(sortExpression);

        ViewData["SortModel"] = sortModel;
        ViewBag.PageSize = PageSize;
        ViewBag.SearchText = SearchText;
        ViewBag.ReportType = "Room";
        ViewBag.View = view;

        TempData["CurrentPage"] = pg;

        var rooms = await _roomService.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

        var pager = new PageModel(rooms.TotalRecords, pg, PageSize)
        {
            Action = "Index",
            Controller = "Room",
            SearchText = SearchText,
            SortExpression = sortExpression,
            ViewType = view,
            ControllerName = "Room"
        };
        ViewBag.Pager = pager;

        return View(rooms);
    }

    public async Task<List<SelectListItem>> GetBlocks()
    {
        return (await _blockService.GetBlocks())
            .Select(m => new SelectListItem { Value = m.Id.ToString(), Text = m.Name })
            .ToList();
    }

    public async Task<List<SelectListItem>> GetBuildings()
    {
        return (await _buildingService.GetBuildings())
            .Select(m => new SelectListItem { Value = m.Id.ToString(), Text = m.Name })
            .ToList();
    }

    public async Task<List<SelectListItem>> GetFloors()
    {
        return (await _floorService.GetFloors())
            .Select(m => new SelectListItem { Value = m.Id.ToString(), Text = m.Name })
            .ToList();
    }

    // GET: Room/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var room = await _roomService.GetRoom(id);
        if (room == null)
        {
            return NotFound();
        }
        return View(room);
    }

    // GET: Room/Create
    public async Task<IActionResult> Create()
    {
        Room room = new Room
        {
            CreatedBy = User.FindFirstValue(ClaimTypes.NameIdentifier),
            CreatedDate = DateTime.Now
        };

        ViewBag.BuildingId =await GetBuildings();
        ViewBag.BlockId =await GetBlocks();
        ViewBag.FloorId =await GetFloors();

        return View(room);
    }

    // POST: Room/Create
    [HttpPost]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> Create(Room room)
    {
        if (string.IsNullOrEmpty(room.Name))
        {
            ModelState.AddModelError("", "Room Name cannot be blank");
        }

        if (ModelState.IsValid)
        {
            await _roomService.Create(room);
            TempData["SuccessMessage"] = "Room created successfully";
            return RedirectToAction(nameof(Index));
        }

        ViewBag.BuildingId =await GetBuildings();
        ViewBag.BlockId =await GetBlocks();
        ViewBag.FloorId =await GetFloors();

        return View(room);
    }

    // GET: Room/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var room = await _roomService.GetRoom(id);

        if (room == null)
            return NotFound();

        room.ModifiedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);
        room.ModifiedDate = DateTime.Now;

        ViewBag.BuildingId =await GetBuildings();
        ViewBag.BlockId = await GetBlocks();
        ViewBag.FloorId = await GetFloors();
        TempData.Keep();

        return View(room);
    }

    // POST: Room/Edit/5
    [HttpPost]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> Edit(int id, Room room)
    {
        string errMessage = "";

        if (string.IsNullOrEmpty(room.Name))
        {
            errMessage += "Room Name cannot be Blank";
            ModelState.AddModelError("", errMessage);
        }

        if (ModelState.IsValid)
        {
            try
            {
                if (_roomService.IsRoomNameExists(room.Name, room.Id))
                {
                    errMessage += $"Room Name {room.Name} Already Exists";
                }

                if (string.IsNullOrEmpty(errMessage))
                {
                    room = await _roomService.Edit(room);
                    TempData["SuccessMessage"] = $"{room.Name} - Room Saved Successfully";
                }
                else
                {
                    TempData["ErrorMessage"] = errMessage;
                    ModelState.AddModelError("", errMessage);
                    return View(room);
                }
            }
            catch (Exception ex)
            {
                errMessage += ex.Message;
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(room);
            }

            int currentPage = TempData["CurrentPage"] != null ? (int)TempData["CurrentPage"] : 1;
            return RedirectToAction(nameof(Index), new { pg = currentPage });
        }

        return View(room);
    }

    // GET: Room/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var room = await _roomService.GetRoom(id);
        TempData.Keep();
        return View(room);
    }

    // POST: Room/Delete/5
    [HttpPost]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> Delete(Room room)
    {
        try
        {
            room = await _roomService.Delete(room);
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            ModelState.AddModelError("", ex.Message);
            return View(room);
        }

        int currentPage = TempData["CurrentPage"] != null ? (int)TempData["CurrentPage"] : 1;
        TempData["SuccessMessage"] = $"Room {room.Name} Deleted Successfully";

        return RedirectToAction(nameof(Index), new { pg = currentPage });
    }
}

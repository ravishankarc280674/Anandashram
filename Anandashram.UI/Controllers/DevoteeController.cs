using Anandashram.UI.Tools.Core.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
namespace Anandashram.Controllers;
[Authorize]
public class DevoteeController : Controller
{
    //  private readonly ApplicationDbContext _context;
    private readonly IDevoteeService _devoteeService;
    private readonly IDevoteeCategoryService _devoteeCategoryService;
    private readonly IRoomService _roomService;
    private readonly IFileManagement _fileManagement;
    private readonly IReservationService _reservationService;
    private readonly ICompanyService _companyService;
    private readonly IWebHostEnvironment _env;
    private readonly ValidationSettings _validationSettings;
    public DevoteeController(IOptions<ValidationSettings> validationOptions,IWebHostEnvironment env, ICompanyService companyService, IDevoteeService devoteeService, IDevoteeCategoryService devoteeCategoryService, IRoomService roomService, IFileManagement fileManagement, IReservationService reservationService)
    {
        _validationSettings = validationOptions.Value;
        // _context = context;
        _env = env;
        _devoteeService = devoteeService;
        _roomService = roomService;
        _devoteeCategoryService = devoteeCategoryService;
        _fileManagement = fileManagement;
        _reservationService = reservationService;
        _companyService = companyService;
    }

    // GET: Devotee
    public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 100, bool Closed = false, string view = "Grid")
    {
        if (pg < 1) pg = 1;
        try
        {
            SortModel sortModel = new SortModel();//ApplySort(sortExpression);
            sortModel.AddColumn("id");
            sortModel.AddColumn("code");
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.AddColumn("mobile");
            sortModel.AddColumn("email");
            sortModel.AddColumn("devoteecategoryname");
            sortModel.AddColumn("startdate");
            sortModel.AddColumn("document");
            sortModel.AddColumn("enddate");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = PageSize;
            ViewBag.SearchText = SearchText;
            ViewBag.Closed = Closed;
            TempData["CurrentPage"] = pg;
            ViewBag.pg = pg;
            var DevoteeList = await _devoteeService.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize, Closed);

            var pager = new PageModel(DevoteeList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Devotee", SearchText = SearchText, Closed = Closed };
            pager.SortExpression = sortExpression;
            this.ViewBag.view = view;
            pager.ViewType = view;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
            var DevoteeDTOList = DevoteeList.Select(d => new
            {
                d.Id,
                d.Code,
                d.Name,
                d.Description,
                d.Mobile,
                d.Email,
                d.DevoteeCategoryName,
                d.StartDate,
                d.EndDate,
                d.AddressLine1,
                d.AddressLine2,
                d.State,
                d.PinCode,
                d.Country,
                d.Document,
                d.NoOfPeople
            }).ToList();
            HttpContext.Session.SetString("DevoteesFilterData", System.Text.Json.JsonSerializer.Serialize(DevoteeDTOList));
            return View(DevoteeList);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return View();
    }
     
    public async Task<List<SelectListItem>> GetDevoteeCategories()
    {
        var devoteeCategories =(await _devoteeCategoryService.GetDevoteeCategories()).Select(m => new SelectListItem()
        {
            Value = m.Id.ToString(),
            Text = m.Name
        }).ToList();

        return devoteeCategories;

    }
    private List<SelectListItem> GetPageSizes(int selectedPageSize = 100)
    {
        var pagesSizes = new List<SelectListItem>();

        if (selectedPageSize == 100)
            pagesSizes.Add(new SelectListItem("100", "100", true));
        else
            pagesSizes.Add(new SelectListItem("100", "100"));

        for (int lp = 200; lp <= 1000; lp += 100)
        {
            if (lp == selectedPageSize)
            { pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
            else
                pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
        }

        return pagesSizes;
    }

    // GET: Devotee/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var devotee = await _devoteeService.GetDevoteeWithReservations(id);
        if (devotee == null)
        {
            return NotFound();
        }
        this.ViewBag.UploadedFiles = _fileManagement.GetUploadedFiles(devotee.Id, devotee.Code);

        return View(devotee);
    }

    // GET: Devotee/Edit/5
    public async Task<IActionResult> AddOrEdit(int Id = 0)
    {
        Devotee devotee = new Devotee();
        ViewBag.ValidateRoomCapacity = _validationSettings.ValidateRoomCapacity;
        ViewBag.DevoteeCategoryId =await GetDevoteeCategories();

        var sexList = EnumHelper.GetEnumList<SexTypeEnum>();
        ViewBag.SexList = sexList
            .Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();

        var specialCategoryList = EnumHelper.GetEnumList<SpecialCategoryTypeEnum>();
        ViewBag.SpecialCategoryList = specialCategoryList
            .Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();

        var nextDestinationList = EnumHelper.GetEnumList<NextDestinationTypeEnum>();
        ViewBag.NextDestinationList = nextDestinationList
            .Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();

        if (Id == 0)
        {
            devotee.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            devotee.CreatedDate = DateTime.Now;

            return View(devotee);
        }
        else
        {
            AddFile file = new AddFile();
            devotee = await _devoteeService.GetDevotee(Id);
            devotee.Reservations = await _reservationService.ReservationList(Id);
            ViewBag.RoomsList =await GetFilteredRooms();
            TempData.Keep();
            
            if (devotee == null)
            {
                return NotFound();
            }
            file.DevoteeCode = devotee.Code;
            ViewBag.AddFile = file;
            this.ViewBag.UploadedFiles = _fileManagement.GetUploadedFiles(devotee.Id, devotee.Code);
            devotee.ModifiedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            devotee.ModifiedDate = DateTime.Now;
        }
        return View(devotee);
    }

    [HttpPost]


    public async Task<IActionResult> AddOrEdit(int Id, Devotee devotee, string actionButton)
    {
        if (ModelState.IsValid)
        {
            int IdToRedirect = 0;
            string OldDevoteeCode = string.Empty;
            string NewDevoteeCode = string.Empty;
            if (Id == 0)
            {
                devotee = await _devoteeService.Create(devotee);
                IdToRedirect = devotee.Id;
            }
            else
            {
                IdToRedirect = devotee.Id;
                OldDevoteeCode = devotee.Code;
                try
                {
                    if (actionButton == "Closed")
                    {
                        devotee.Closed = true;
                    }
                    if (actionButton == "Reopen")
                    {
                        Devotee newDevotee = new Devotee()
                        {
                            DevoteeCategoryId = devotee.DevoteeCategoryId,
                            // Description = devotee.Description,
                            CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                            CreatedDate = DateTime.Now,
                            Country = devotee.Country,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now,
                            AddressLine1 = devotee.AddressLine1,
                            AddressLine2 = devotee.AddressLine2,
                            PinCode = devotee.PinCode,
                            Email = devotee.Email,
                            Name = devotee.Name,
                            State = devotee.State,
                            Document = devotee.Document,
                            Mobile = devotee.Mobile,
                            NoOfPeople = devotee.NoOfPeople
                        };
                        newDevotee = await _devoteeService.Create(newDevotee);
                        NewDevoteeCode = newDevotee.Code;
                        IdToRedirect = newDevotee.Id;

                        devotee.ReopenedCode = newDevotee.Code;
                        await _fileManagement.CopyProfilePic(OldDevoteeCode, NewDevoteeCode);
                        await _fileManagement.CopyDocuments(OldDevoteeCode, NewDevoteeCode);
                    }
                    devotee = await _devoteeService.Edit(devotee);
                    if (actionButton == "Closed")
                    {
                        await CloseReservations(IdToRedirect,true);
                        return RedirectToAction("Details", new { Id = IdToRedirect });
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await _devoteeService.GetDevotee(devotee.Id) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return RedirectToAction("AddOrEdit", new { Id = IdToRedirect });
        }
        else
        {
            View(devotee);
        }
        return RedirectToAction("AddOrEdit", new { Id = 0 });
    }

    // GET: Devotee/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        Devotee devotee = await _devoteeService.GetDevotee(id);
        TempData.Keep();
        return View(devotee);
    }

    [HttpPost]

    public async Task<IActionResult> Delete(Devotee devotee)
    {
        try
        {
            devotee = await _devoteeService.Delete(devotee);
        }
        catch (Exception ex)
        {
            string errMessage = ex.Message;
            TempData["ErrorMessage"] = errMessage;
            ModelState.AddModelError("", errMessage);
            return View(devotee);
        }

        int currentPage = 1;
        if (TempData["CurrentPage"] != null)
            currentPage = (int)TempData["CurrentPage"];

        TempData["SuccessMessage"] = "Devotee " + devotee.Name + " Deleted Successfully";
        return RedirectToAction(nameof(Index), new { pg = currentPage });
    }

    [HttpPost]
    public async Task<IActionResult> SaveImage(int Id, string Code, string Data)
    {
        AddFile addFile = new AddFile();
        addFile.DevoteeId = Id;
        addFile.DevoteeCode = Code;
        string imageData = Data;
        var base64Data = imageData.Split(',')[1];
        var imageBytes = Convert.FromBase64String(base64Data);
        addFile.ImageBytes = imageBytes;
        await _fileManagement.Upload(addFile);
        return Json(new { success = true });
    }
    public async Task<IActionResult> UploadDocument(AddFile addFile)
    {
        string fileExtention = Path.GetExtension(addFile.ImageFile.FileName);
        addFile.FileName = addFile.FileName + fileExtention;
        await _fileManagement.UploadDocument(addFile);
        return RedirectToAction("AddOrEdit", new { Id = addFile.DevoteeId });
    }
    public async Task<IActionResult> GetImage(string fileName)
    {
        var fileBytes = await _fileManagement.GetProfilePic(fileName);
        return File(fileBytes, "image/jpeg");
    }
    public async Task<FileResult> GetDocument(string filePath, string fileName)
    {
        var fileBytes = await _fileManagement.GetDocument(filePath);
        return File(fileBytes, "application/octet-stream", fileName); // Adjust MIME type as needed

    }
    public async Task<IActionResult> DeleteDocument(int Id, string filePath)
    {
        await _fileManagement.DeleteDocument(filePath);
        NotifyUser("Document Deleted Successfully");
        return RedirectToAction("AddOrEdit", new { Id = Id });
    }
    public void NotifyUser(string message)
    {
        Content($"<script>notify('{message}');</script>", "text/html");
    }
    private async Task<List<SelectListItem>> GetFilteredRooms()
    {
        var lstRooms = new List<SelectListItem>();
        PaginatedList<Room> rooms = new PaginatedList<Room>(await _roomService.GetFilteredRooms(), 1, 1000);
        lstRooms = rooms.Select(ut => new SelectListItem()
        {
            Value = ut.Id.ToString(),
            Text = ut.Name
        }).ToList();

        var defItem = new SelectListItem()
        {
            Value = "0",
            Text = "--Room--"
        };

        lstRooms.Insert(0, defItem);

        return lstRooms;
    }

    [HttpPost]
    public async Task<JsonResult> GetSelectedRoom(int Id)
    {
        var room =await _roomService.GetSelectedRoom(Id);
        return Json(new { Success = "true", Data = room });
    }

    [HttpPost]
    public async Task<IActionResult> AddReservation([FromBody] List<Reservation> data)
    {
        if (data == null || !data.Any())
            return BadRequest("No reservation data provided.");

        int devoteeId = data.First().DevoteeId;

        foreach (Reservation r in data) { r.CreatedDate = DateTime.Now; r.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier); };
        await _reservationService.AddReservation(data);
        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "AddOrEdit", devoteeId) });
    }

    [HttpPost]
    public async Task<IActionResult> CloseReservation(int Id, int DevoteeId)
    {
        await _reservationService.CloseReservation(Id, DevoteeId, DateTime.Now, this.User.FindFirstValue(ClaimTypes.NameIdentifier));
        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "AddOrEdit", DevoteeId) });
    }

    [HttpPost]
    public async Task<IActionResult> CloseReservations(int DevoteeId,bool IsDevoteeClosed=false)
    {
        await _reservationService.CloseReservations(DevoteeId, IsDevoteeClosed ?DateTime.MinValue: DateTime.Now, this.User.FindFirstValue(ClaimTypes.NameIdentifier));
        return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "AddOrEdit", DevoteeId) });
    }

    public async Task<Devotee> GetDevoteeWithReservations(int devoteeId)
    {
        Devotee devotee = new Devotee();
         return   await _devoteeService.GetDevoteeWithReservations(devoteeId);
    }
}


using Anandashram.Interfaces;
using Anandashram.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    public class DevoteeController : Controller
    {
        //  private readonly ApplicationDbContext _context;
        private readonly IDevotee _devoteeRepo;
        private readonly IDevoteeCategory _devoteeCategoryRepo;
        private readonly IFileManagement _fileManagement;
        public DevoteeController(IDevotee devoteeRepo, IDevoteeCategory devoteeCategoryRepo, IFileManagement fileManagement)
        {
            // _context = context;
            _devoteeRepo = devoteeRepo;
            _devoteeCategoryRepo = devoteeCategoryRepo;
            _fileManagement = fileManagement;
        }

        // GET: Devotee
        public async Task<IActionResult> Index(string sortExpression = "", string SearchText = "", int pg = 1, int PageSize = 5)
        {
            if (pg < 1) pg = 1;

            SortModel sortModel = new SortModel();//ApplySort(sortExpression);
            sortModel.AddColumn("code");
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.AddColumn("mobile");
            sortModel.AddColumn("email");
            sortModel.AddColumn("devoteecategoryname");
            sortModel.AddColumn("startdate");
            sortModel.AddColumn("enddate");
            sortModel.ApplySort(sortExpression);
            ViewData["SortModel"] = sortModel;
            ViewBag.PageSize = PageSize;
            ViewBag.SearchText = SearchText;
            TempData["CurrentPage"] = pg;
            var DevoteeList = await _devoteeRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, PageSize);

            var pager = new PageModel(DevoteeList.TotalRecords, pg, PageSize) { Action = "Index", Controller = "Devotee", SearchText = SearchText };
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;
            this.ViewBag.PageSizes = GetPageSizes(PageSize);
            return View(DevoteeList);
        }

        public List<SelectListItem> GetDevoteeCategories()
        {
            var devoteeCategories = _devoteeCategoryRepo.GetDevoteeCategories().Select(m => new SelectListItem()
            {
                Value = m.Id.ToString(),
                Text = m.Name
            }).ToList();

            return devoteeCategories;

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

        // GET: Devotee/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var devotee = await _devoteeRepo.GetDevotee(id);
            if (devotee == null)
            {
                return NotFound();
            }

            return View(devotee);
        }

        // GET: Devotee/Edit/5
        public async Task<IActionResult> AddOrEdit(int Id = 0)
        {
                Devotee devotee = new Devotee();
                ViewBag.DevoteeCategoryId = GetDevoteeCategories();
            if (Id == 0)
            {
                devotee.CreatedBy = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                devotee.CreatedDate = DateTime.Now;
                return View(devotee);
            }
            else
            {
                AddFile file = new AddFile();
                devotee = await _devoteeRepo.GetDevotee(Id);
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int Id,Devotee devotee)
        {
            if (ModelState.IsValid)
            {
                if (Id == 0)
                {
                    devotee = await _devoteeRepo.Create(devotee);
                    
                }
                else
                {
                    try
                    {

                        devotee = await _devoteeRepo.Edit(devotee);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (_devoteeRepo.GetDevotee(devotee.Id) == null)
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
            return RedirectToAction("AddOrEdit", new { Id = devotee.Id });
        }

        // GET: Devotee/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Devotee devotee = await _devoteeRepo.GetDevotee(id);
            TempData.Keep();
            return View(devotee);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Devotee devotee)
        {
            try
            {
                devotee = await _devoteeRepo.Delete(devotee);
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

        //image captured from webcam

        [HttpPost]
        public async Task<IActionResult> SaveImage(AddFile addFile)
        {
            string imageData = addFile.ImageData;
            var base64Data = imageData.Split(',')[1];
            var imageBytes = Convert.FromBase64String(base64Data);
            await _fileManagement.Upload(addFile);
            return Json(new { success = true });
        }

        public async Task<IActionResult> UploadDocument(AddFile addFile)
        {
            //if (!ModelState.IsValid)
            //{
                string fileExtention = Path.GetExtension(addFile.ImageFile.FileName);
                addFile.FileName = addFile.FileName + fileExtention;
                await _fileManagement.UploadDocument(addFile);
            //}
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_UploadDocument", addFile.DevoteeId) });

        }

        public async Task<IActionResult> GetImage(string fileName)
        {
            var fileBytes =await _fileManagement.GetProfilePic(fileName);
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
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "Edit", Id) });
        }
    }
}

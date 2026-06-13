using Anandashram.UI.Tools.Core.Enums;
using DocumentFormat.OpenXml.Drawing;
using System.Text.Json;

namespace Anandashram.Controllers
{
    public class CFormController : Controller
    {
        private readonly ICFormService _cformService;

        public CFormController(ICFormService cformService)
        {
            _cformService = cformService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int devoteeId)
        {
            var data = await _cformService.GetAsync(devoteeId);

            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] CForm model)
        {
            if (model == null)
                return BadRequest();

            await _cformService.SaveAsync(model);

            return Json(true);
        }
        public async Task<IActionResult> Print(int devoteeId)
        {
            var dto = await _cformService.GetCFormForPrint(devoteeId);

            var report = new CFormReport(dto);

            var pdf = report.GeneratePdf();

            return File(pdf, "application/pdf");
        }
    }
}

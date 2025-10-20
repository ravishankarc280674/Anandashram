using Anandashram.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompany _companyRepo;
        public CompanyController(ICompany companyRepo)
        {
            _companyRepo = companyRepo;
        }

        // GET: CompanyController/Edit/5
        public ActionResult Company()
        {
            Company company = _companyRepo.CompanyDetails();
            return View(company);
        }

        // POST: CompanyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveCompany(Company company)
        {
            company = _companyRepo.SaveCompany(company);
            return RedirectToAction("Index", "Home");

        }
    }
}

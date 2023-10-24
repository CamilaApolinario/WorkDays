using Microsoft.AspNetCore.Mvc;
using WorkDays.Application.DTOs;
using WorkDays.Application.DTOs.CompanyDto;
using WorkDays.Core.Services.Interfaces;

namespace WorkDays.API.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyService _service;

        public CompanyController(ILogger<CompanyController> logger, ICompanyService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("Company/Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CompanyDto companyDto)
        {
            var company = _service.PostCompany(companyDto);
            return Ok(company);
            //if (ModelState.IsValid)
            //{
            //    _service.PostCompany(company);
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(company);
        }

        [HttpGet("Company/Read")]
        public async Task<IActionResult> Index()
        {
            var companies = _service.GetCompany();
            return Ok(companies);
        }

        [HttpPut("Company/Update")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CompanyUpdateDto company)
        {
            var companyUp = _service.PutCompany(company);
            return Ok(companyUp);
        }

        [HttpDelete("Company/Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var companyUp = _service.DeleteCompany(id);
            return Ok(companyUp);
        }
    }
}
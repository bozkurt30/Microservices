using Company.API.Infrastructure;
using Company.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet("{Id}")]
        public CompanyDTO GetById(int Id)
        {
            return _companyService.GetCompanyById(Id);
        }
    }
}

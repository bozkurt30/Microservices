using Department.API.Infrastructure;
using Department.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Department.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService= departmentService;
        }
        [HttpGet("{id}")]
        public DepartmentDTO GetById(int id)
        {
           return _departmentService.GetDepartmentById(id);
        }
    }
}

using Department.API.Infrastructure;
using Department.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.API.Services
{
    public class DepartmentService : IDepartmentService
    {
        public DepartmentDTO GetDepartmentById(int id)
        {
            return new DepartmentDTO()
            {
                Id = id,
                ParentId = 1,
                Department_Name ="Müdürlük,"
            };
        }
    }
}

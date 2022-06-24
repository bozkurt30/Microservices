using Department.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.API.Infrastructure
{
    public interface IDepartmentService
    {
        public DepartmentDTO GetDepartmentById(int id);
    }
}

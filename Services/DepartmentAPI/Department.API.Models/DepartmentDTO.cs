using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.API.Models
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Department_Name { get; set; }
    }
}

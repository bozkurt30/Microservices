using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.API.Models
{
    public class CompanyDTO
    {
        public int ID { get; set; }
        public int DepartmentId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public int CompanyNo { get; set; }
        public int ComapnyTaxNo { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
    }
}

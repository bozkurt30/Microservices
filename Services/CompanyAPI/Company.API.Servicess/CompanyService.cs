using Company.API.Infrastructure;
using Company.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.API.Servicess
{
    public class CompanyService : ICompanyService
    {
        public CompanyDTO GetCompanyById(int id)
        {
            return new CompanyDTO()
            {
                ID = id,
                DepartmentId = 1,
                CompanyName = "Test A.Ş",
                CompanyNo = 120,
                CompanyType = "Anonim",
                City = "İstanbul",
                ComapnyTaxNo = 0,
                Address = "mah. sokak",
                County = "kadıkoy"
            };
        }
    }
}

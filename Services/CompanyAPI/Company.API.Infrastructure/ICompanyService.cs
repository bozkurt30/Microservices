using Company.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.API.Infrastructure
{
    public interface ICompanyService
    {
        public CompanyDTO GetCompanyById(int id);
    }
}

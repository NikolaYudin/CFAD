using CFAD.Models;
using CFAD.Models.Companys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Data
{
    public class CompanyService: ICompanyService
    {
        public DateTime CreationDate { get; set; }
        public List<Company> CompanyList { get; set; }

        public CompanyService(ApplicationDbContext context)
        {
            CreationDate = DateTime.Now;

            CompanyList = context.CFAD_Company.ToList<Company>();
        }

        public List<Company> GetCompanies()
        {
            return CompanyList;
        }
        public Company GetCompanyById(Guid CompanyId)
        {
            return CompanyList.Where(comp => comp.Id == CompanyId).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }
    }
}

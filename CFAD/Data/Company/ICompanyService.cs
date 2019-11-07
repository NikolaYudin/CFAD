using CFAD.Models.Companys;
using System;
using System.Collections.Generic;

namespace CFAD.Data
{
    public interface ICompanyService
    {
        public List<Company> GetCompanies(); 
        public string GetVersion();
        public DateTime GetCreatedDate();
        public Company GetCompanyById(string CompanyId);
    }
}
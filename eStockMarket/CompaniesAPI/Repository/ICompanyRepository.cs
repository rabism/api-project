using CompaniesAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompaniesAPI.Repository
{
    public interface ICompanyRepository
    {
        Company RegisterCompany(Company company);
        Company DeleteCompany(string companyCode);
        Company GetCompanyByCode(string companyCode);
        IReadOnlyList<Company> GetAllCompanies();
        bool IsCompanyExists(string companyCode);

        bool IsExchangeExists(List<string> exchanges);
        //void UpdateCompanyStock(Stock stock);
    }
}

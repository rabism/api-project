using CompaniesAPI.Models;
using CompaniesAPI.Entity;
using CompaniesAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompaniesAPI.Services
{
    public interface ICompanyUpdateSenderService
    {
            void SendAddCompany(Company company);
             void SendDeleteCompany(string companyCode);
    }
}
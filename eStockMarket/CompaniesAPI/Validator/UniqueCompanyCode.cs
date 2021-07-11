using System;  
using System.ComponentModel.DataAnnotations;
using CompaniesAPI.Models; 
using CompaniesAPI.Services; 
namespace CompaniesAPI.Validator  
{  
    public class UniqueCompanyCode : ValidationAttribute  
    {  
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)  
        {  
            var service = (ICompanyService) validationContext
                         .GetService(typeof(ICompanyService));
            var company = (CompanyDetail)validationContext.ObjectInstance;  
  
          return  service.IsCompanyExists(company.CompanyCode)
                ? new ValidationResult("company code exist!")
                :ValidationResult.Success;
           
        }
    }  
} 
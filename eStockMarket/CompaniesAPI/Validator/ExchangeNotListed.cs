using System;  
using System.ComponentModel.DataAnnotations;
using CompaniesAPI.Models; 
using CompaniesAPI.Services; 
using System.Linq;
namespace CompaniesAPI.Validator  
{ 
    public class ExchangeNotListed: ValidationAttribute  
    {  
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)  
        {  
            var service = (ICompanyService) validationContext
                         .GetService(typeof(ICompanyService));
            var company = (CompanyDetail)validationContext.ObjectInstance;  
  
          return  !service.IsExchangeExists(company.Exchange.Select(x=>x.ExchangeName).ToList())
                ? new ValidationResult("exchange name not listed!")
                :ValidationResult.Success;
           
        }
    }  

}
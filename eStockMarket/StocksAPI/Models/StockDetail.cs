using System.ComponentModel.DataAnnotations;
namespace StocksAPI.Models
{
    public class StockDetail
    {
       
        [Required]
        public decimal StockPrice { get; set; }
        [Required]
        public string ExchangeName {get;set;}
        
    }
}

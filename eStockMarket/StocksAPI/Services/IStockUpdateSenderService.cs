
namespace StocksAPI.Services
{
    public interface IStockUpdateSenderService
    {
        void SendAddStock(string companyCode,string exchangeName,decimal currentStockPrice);
    }
}

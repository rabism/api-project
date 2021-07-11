using MongoDB.Driver;

namespace StocksAPI.Entity
{
    public interface IStockDbContext
    {
        IMongoCollection<Stock> Stocks { get; }

        IMongoCollection<Company> Company {get;}
    }
}
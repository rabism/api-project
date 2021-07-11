using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StocksAPI.Entity
{
    public class Exchange 
    {
        [BsonId]
        public string ExchangeName{get;set;}
        public string ExchangeDescription {get;set;}
        
    }
}

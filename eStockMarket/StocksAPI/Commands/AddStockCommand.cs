using MediatR;
using StocksAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace StocksAPI.Commands
{
    public class AddStockCommand : IRequest<Stock>
    {
        public Stock Stock { get; set; }

        
    }
    public class AddStockCommandHandler : IRequestHandler<AddStockCommand,Stock>
        {
            private readonly IStockDbContext _context;
            public AddStockCommandHandler(IStockDbContext context)
            {
                _context = context;
            }
            public async Task<Stock> Handle(AddStockCommand command, CancellationToken cancellationToken)
            {
               await  _context.Stocks.InsertOneAsync(command.Stock);
               return command.Stock;
                
            }
        }
}

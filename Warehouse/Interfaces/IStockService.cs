using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;

namespace Warehouse.Interfaces
{
    public interface IStockService
    {
        Task<StockListResult> GetStockListAsync(string foreignCurrency);
    }
}

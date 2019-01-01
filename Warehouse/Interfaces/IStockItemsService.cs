using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;

namespace Warehouse.Interfaces
{
    public interface IStockItemsService
    {
        Task<StockItemView> CreateStockItemAsync(StockItemView stockItem);
        Task<StockItemView> UpdateStockItemAsync(StockItemView stockItem);
        Task DeleteStockItemAsync(int stockItemId);
        Task MoveStockItemsAsync(StockMovementView stockMovementView);
    }
}

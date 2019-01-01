using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;
using Warehouse.Interfaces;
using Warehouse.Models;

namespace Warehouse.Services
{
    public class CommonDataService : ICommonDataService
    {
        private readonly WarehouseContext context;

        public CommonDataService(WarehouseContext context)
        {
            this.context = context;
        }

        public async Task<StockItemView[]> GetStockListAsync(int? stockItemId = null)
        {
            var items = from s in context.StockItems
                        orderby s.Name
                        select new StockItemView
                        {
                            StockItemId = s.StockItemId,
                            Id = s.Id,
                            Name = s.Name,
                            Description = s.Description,
                            Price = s.Price,
                            Mass = s.Mass,
                            Quantity = s.StockMovements.Select(m => m.Quantity).Sum()
                        };

            if (stockItemId != null)
            {
                items = from s in items
                        where s.StockItemId == stockItemId
                        select s;
            }

            return await items.ToArrayAsync();
        }
    }
}

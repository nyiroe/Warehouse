using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;
using Warehouse.Exceptions;
using Warehouse.Interfaces;
using Warehouse.Models;

namespace Warehouse.Services
{
    public class StockItemsService : IStockItemsService
    {
        private readonly WarehouseContext context;
        private readonly IMapper mapper;
        private readonly ICommonDataService commonDataService;

        public StockItemsService(WarehouseContext context, IMapper mapper, ICommonDataService commonDataService)
        {
            this.context = context;
            this.mapper = mapper;
            this.commonDataService = commonDataService;
        }

        public async Task<StockItemView> CreateStockItemAsync(StockItemView stockItem)
        {
            return await CreateOrUpdateStockItemAsync(stockItem, true);
        }

        public async Task<StockItemView> UpdateStockItemAsync(StockItemView stockItem)
        {
            return await CreateOrUpdateStockItemAsync(stockItem, false);
        }

        private async Task<StockItemView> CreateOrUpdateStockItemAsync(StockItemView stockItem, bool isCreate)
        {
            stockItem.Name = stockItem.Name.SafeTrim();
            stockItem.Description = stockItem.Description.SafeTrim();
            stockItem.Id = stockItem.Id.SafeTrim();

            if (!string.IsNullOrEmpty(stockItem.Id))
            {
                var itemWithExistingId = await (from s in context.StockItems
                                                where s.Id == stockItem.Id
                                                select s).SingleOrDefaultAsync();

                if (itemWithExistingId != null && (isCreate || itemWithExistingId.StockItemId != stockItem.StockItemId))
                {
                    throw new BadRequestException($"Id '{stockItem.Id}' already exists");
                }
            }

            StockItems item;
            if (isCreate)
            {
                stockItem.StockItemId = null;
                item = new StockItems();
                await context.StockItems.AddAsync(item);
            }
            else
            {
                item = await context.StockItems.FindAsync(stockItem.StockItemId);
                if (item == null)
                {
                    throw new BadRequestException("Invalid StockItemId");
                }
            }

            mapper.Map(stockItem, item);

            await context.SaveChangesAsync();

            return mapper.Map<StockItemView>(item);
        }

        public async Task DeleteStockItemAsync(int stockItemId)
        {
            var item = await context.StockItems.FindAsync(stockItemId);
            if (item == null)
            {
                throw new BadRequestException("Invalid StockItemId");
            }

            context.StockItems.Remove(item);
            await context.SaveChangesAsync();
        }

        public async Task MoveStockItemsAsync(StockMovementView stockMovement)
        {
            var itemList = await commonDataService.GetStockListAsync(stockMovement.StockItemId);
            var item = itemList.SingleOrDefault();

            if (item == null)
            {
                throw new BadRequestException("Invalid StockItemId");
            }

            checked
            {
                try
                {
                    if (item.Quantity + stockMovement.Quantity < 0)
                    {
                        throw new BadRequestException("Invalid Quantity");
                    }
                }
                catch (OverflowException)
                {
                    throw new BadRequestException("Quantity limit has been reached");
                }
            }

            StockMovements newStockMovement = mapper.Map<StockMovements>(stockMovement);
            newStockMovement.TimeStamp = DateTime.UtcNow;

            await context.StockMovements.AddAsync(newStockMovement);

            await context.SaveChangesAsync();
        }
    }
}

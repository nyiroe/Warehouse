using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;
using Warehouse.Interfaces;

namespace Warehouse.Controllers
{
    public class StockController : ApiControllerBase
    {
        private readonly IStockService stockService;
        private readonly IStockItemsService stockItemsService;

        public StockController(IStockService stockService, IStockItemsService stockItemsService)
        {
            this.stockService = stockService;
            this.stockItemsService = stockItemsService;
        }

        [HttpGet("{foreignCurrency:alpha?}")]
        [ActionName("List")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<StockListResult> GetListAsync(string foreignCurrency)
        {
            return await stockService.GetStockListAsync(foreignCurrency);
        }

        [HttpPost]
        [ActionName("Item")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<StockItemView> CreateAsync([FromBody] StockItemView stockItem)
        {
            ValidateModelState();

            return await stockItemsService.CreateStockItemAsync(stockItem);
        }

        [HttpPut]
        [ActionName("Item")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<StockItemView> UpdateAsync([FromBody] StockItemView stockItem)
        {
            ValidateModelState();

            return await stockItemsService.UpdateStockItemAsync(stockItem);
        }

        [HttpDelete("{id:int}")]
        [ActionName("Item")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await stockItemsService.DeleteStockItemAsync(id);

            return Ok();
        }

        [HttpPost]
        [ActionName("MoveItem")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> MoveStockItemsAsync([FromBody] StockMovementView stockMovement)
        {
            ValidateModelState();

            await stockItemsService.MoveStockItemsAsync(stockMovement);

            return Ok();
        }
    }
}

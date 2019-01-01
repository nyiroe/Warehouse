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
    public class StockService : IStockService
    {
        private readonly ICommonDataService commonDataService;
        private readonly ICachedExchangeRateService cachedExchangeRateService;

        public StockService(ICommonDataService commonDataService, ICachedExchangeRateService cachedExchangeRateService)
        {
            this.commonDataService = commonDataService;
            this.cachedExchangeRateService = cachedExchangeRateService;
        }

        public async Task<StockListResult> GetStockListAsync(string foreignCurrency)
        {
            var result = new StockListResult();
            var stockList = await commonDataService.GetStockListAsync();

            if (foreignCurrency == null)
            {
                result.ExchangeRate = new ExchangeRate();
            }
            else
            {
                result.ExchangeRate = await cachedExchangeRateService.GetExchangeRateAsync(foreignCurrency);

                if (result.ExchangeRate.IsValid)
                {
                    foreach (var item in stockList)
                    {
                        item.UpdateForeignPrice(result.ExchangeRate);
                    }
                }
            }

            result.StockList = stockList;

            return result;
        }
    }
}

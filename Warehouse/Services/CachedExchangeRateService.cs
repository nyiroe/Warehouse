using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;
using Warehouse.Exceptions;
using Warehouse.Interfaces;

namespace Warehouse.Services
{
    public class CachedExchangeRateService : ICachedExchangeRateService
    {
        private readonly Settings settings;
        private readonly IMemoryCache memoryCache;
        private readonly IExchangeRateService exchangeRateService;

        public CachedExchangeRateService(IOptions<Settings> options, IMemoryCache memoryCache, IExchangeRateService exchangeRateService)
        {
            settings = options.Value;
            this.memoryCache = memoryCache;
            this.exchangeRateService = exchangeRateService;
        }

        public async Task<ExchangeRate> GetExchangeRateAsync(string currency)
        {
            string cacheKey = currency.ToUpper();

            if (!memoryCache.TryGetValue(cacheKey, out ExchangeRate exchangeRate))
            {
                try
                {
                    exchangeRate = await exchangeRateService.GetExchangeRateAsync(currency);
                    UpdateCachedExchangeRate(cacheKey, exchangeRate, settings.ExchangeRateCacheSeconds);
                }
                catch (BadRequestException)
                {
                    throw;
                }
                catch
                {
                    exchangeRate = new ExchangeRate();
                    UpdateCachedExchangeRate(cacheKey, exchangeRate, settings.ExchangeRateFailRetrySeconds);
                }
            }

            return exchangeRate;
        }

        private void UpdateCachedExchangeRate(string cacheKey, ExchangeRate exchangeRate, int cacheExpirationSeconds)
        {
            memoryCache.Set(cacheKey, exchangeRate, new MemoryCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(cacheExpirationSeconds) });
        }
    }
}

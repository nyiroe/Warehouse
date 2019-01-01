using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;

namespace Warehouse
{
    public static class Extensions
    {
        public static string SafeTrim(this string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        public static void UpdateForeignPrice(this StockItemView stockItem, ExchangeRate exchangeRate)
        {
            if (exchangeRate != null && exchangeRate.IsValid)
            {
                stockItem.ForeignPrice = new PriceView
                {
                    Currency = exchangeRate.Currency,
                    Price = Math.Round(stockItem.Price / exchangeRate.Value, 2)
                };
            }
        }
    }
}

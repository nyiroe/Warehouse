using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Data
{
    public class StockListResult
    {
        public ExchangeRate ExchangeRate { get; set; }
        public StockItemView[] StockList { get; set; }
    }
}

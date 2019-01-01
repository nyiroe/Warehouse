using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Data
{
    public class Settings
    {
        public int ExchangeRateCacheSeconds { get; set; }
        public int ExchangeRateFailRetrySeconds { get; set; }
    }
}

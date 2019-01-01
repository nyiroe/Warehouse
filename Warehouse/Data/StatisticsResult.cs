using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Data
{
    public class StatisticsResult
    {
        public decimal? GlobalMass { get; set; }
        public decimal? GlobalPrice { get; set; }
        public StockItemView TopQuantityItem { get; set; }
        public StockItemView TopMassItem { get; set; }
    }
}

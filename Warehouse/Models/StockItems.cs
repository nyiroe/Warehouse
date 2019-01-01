using System;
using System.Collections.Generic;

namespace Warehouse.Models
{
    public partial class StockItems
    {
        public StockItems()
        {
            StockMovements = new HashSet<StockMovements>();
        }

        public int StockItemId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Mass { get; set; }

        public virtual ICollection<StockMovements> StockMovements { get; set; }
    }
}

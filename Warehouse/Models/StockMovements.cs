using System;
using System.Collections.Generic;

namespace Warehouse.Models
{
    public partial class StockMovements
    {
        public int StockMovementId { get; set; }
        public int StockItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual StockItems StockItem { get; set; }
    }
}

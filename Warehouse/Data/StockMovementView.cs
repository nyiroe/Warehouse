using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Validations;

namespace Warehouse.Data
{
    public class StockMovementView
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int StockItemId { get; set; }

        [Required]
        [IntNotZero]
        [Range(-1000000, 1000000)]
        public int Quantity { get; set; }
    }
}

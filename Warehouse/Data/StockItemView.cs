using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Validations;

namespace Warehouse.Data
{
    public class StockItemView
    {
        [Range(1, int.MaxValue)]
        public int? StockItemId { get; set; }

        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [DecimalGreaterThanZero]
        [Range(0, 1000000)]
        public decimal Price { get; set; }

        public PriceView ForeignPrice { get; set; }

        [Required]
        [DecimalGreaterThanZero]
        [Range(0, 1000)]
        public decimal Mass { get; set; }

        public int Quantity { get; set; }
    }
}

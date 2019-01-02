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
        private const string STRING_PATTERN = @"^[a-zA-Z0-9- ]+$";

        [Range(1, int.MaxValue)]
        public int? StockItemId { get; set; }

        [StringLength(50)]
        [RegularExpression(STRING_PATTERN)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(STRING_PATTERN)]
        public string Name { get; set; }

        [StringLength(250)]
        [RegularExpression(STRING_PATTERN)]
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

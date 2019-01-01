using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Data
{
    public class ExchangeRate
    {
        public bool IsValid => Date != default(DateTime) && Value != default(decimal);

        public string Currency { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException()
            : base("Invalid request")
        {
        }

        public BadRequestException(string message)
            : base(message)
        {
        }
    }
}

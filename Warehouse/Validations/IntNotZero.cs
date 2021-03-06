﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Validations
{
    public class IntNotZero : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is int)
            {
                return (int)value != 0;
            }
            else
            {
                return false;
            }
        }
    }
}

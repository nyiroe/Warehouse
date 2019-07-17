using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Exceptions;

namespace Warehouse.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ValidateModel]
    public abstract class ApiControllerBase : Controller
    {
    }
}

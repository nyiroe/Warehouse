using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;
using Warehouse.Interfaces;

namespace Warehouse.Controllers
{
    public class StatisticsController : ApiControllerBase
    {
        private readonly IStatisticsService statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }

        [HttpGet]
        [ActionName("List")]
        public async Task<StatisticsResult> GetStatisticsAsync()
        {
            return await statisticsService.GetStatisticsAsync();
        }
    }
}

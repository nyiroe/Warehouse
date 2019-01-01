using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;
using Warehouse.Interfaces;

namespace Warehouse.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ICommonDataService commonDataService;

        public StatisticsService(ICommonDataService commonDataService)
        {
            this.commonDataService = commonDataService;
        }

        public async Task<StatisticsResult> GetStatisticsAsync()
        {
            var result = new StatisticsResult();
            var stockList = await commonDataService.GetStockListAsync();

            if (stockList.Count() > 0)
            {
                checked
                {
                    try
                    {
                        decimal globalMass = (from s in stockList
                                              select s.Quantity * s.Mass).Sum();
                        result.GlobalMass = Math.Round(globalMass, 2);
                    }
                    catch (OverflowException)
                    {
                        result.GlobalMass = null;
                    }

                    try
                    {
                        decimal globalPrice = (from s in stockList
                                               select s.Quantity * s.Price).Sum();
                        result.GlobalPrice = Math.Round(globalPrice, 2);
                    }
                    catch (OverflowException)
                    {
                        result.GlobalPrice = null;
                    }
                }

                result.TopQuantityItem = (from s in stockList
                                          orderby s.Quantity descending
                                          select s).FirstOrDefault();

                if (result.TopQuantityItem.Quantity == 0)
                {
                    result.TopQuantityItem = null;
                }

                result.TopMassItem = (from s in stockList
                                      orderby s.Quantity * s.Mass descending
                                      select s).FirstOrDefault();

                if (result.TopMassItem.Quantity == 0)
                {
                    result.TopMassItem = null;
                }
            }

            return result;
        }
    }
}

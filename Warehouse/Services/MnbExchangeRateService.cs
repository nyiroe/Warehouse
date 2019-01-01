using MnbService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Warehouse.Data;
using Warehouse.Exceptions;
using Warehouse.Interfaces;

namespace Warehouse.Services
{
    public class MnbExchangeRateService : IExchangeRateService
    {
        public async Task<ExchangeRate> GetExchangeRateAsync(string currency)
        {
            using (MNBArfolyamServiceSoapClient client = new MNBArfolyamServiceSoapClient())
            {
                var response = await client.GetCurrentExchangeRatesAsync(new GetCurrentExchangeRatesRequestBody());
                string result = response.GetCurrentExchangeRatesResponse1.GetCurrentExchangeRatesResult;

                return ProcessResult(result, currency);
            }
        }

        private ExchangeRate ProcessResult(string currentExchangeRatesResult, string currency)
        {
            try
            {
                XDocument xdoc = XDocument.Parse(currentExchangeRatesResult);

                var dayElement = xdoc.Element("MNBCurrentExchangeRates").Element("Day");
                var elements = dayElement.Descendants("Rate");

                XElement element = (from el in elements
                                    where string.Equals(el.Attribute("curr").Value, currency, StringComparison.OrdinalIgnoreCase)
                                    select el).SingleOrDefault();

                if (element == null)
                {
                    throw new BadRequestException($"Invalid Currency: {currency}");
                }

                int unit = int.Parse(element.Attribute("unit").Value);
                string curr = element.Attribute("curr").Value;
                decimal value = decimal.Parse(element.Value);

                return new ExchangeRate
                {
                    Currency = curr,
                    Date = DateTime.ParseExact(dayElement.Attribute("date").Value, "yyyy-MM-dd", null),
                    Value = value / unit
                };
            }
            catch (BadRequestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not process service response", ex);
            }
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp1.Models
{
    class ValueParserModel
    {
        public string charCode { get; set; }
        public string value { get; set; }

        public static Dictionary<string, string> GetCurrencyData(string currency)
        {
            var values = StaticValueParserModel._values;

            var currencyData = new Dictionary<string, string>();

            var some = values[currency]["Value"].ToString();

            currencyData.Add(currency, values[currency]["Value"].ToString());

            return currencyData;
        }
    }
}

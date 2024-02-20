using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class StaticValueParserModel
    {
        public static JToken? _values;
        static StaticValueParserModel() 
        {
            var request = new GetRequest("https://www.cbr-xml-daily.ru/daily_json.js");

            request.Run();

            var response = request.Response;

            var json = JObject.Parse(response);

            _values = json["Valute"];
        }
    }
}

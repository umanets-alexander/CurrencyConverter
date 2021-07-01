using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class JSONConnect
    {
        public static JSONConvert.ConverterValute DataCurrency;

        public static void connectJSON()
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string stringJSON = client.DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");
            DataCurrency = JsonConvert.DeserializeObject<JSONConvert.ConverterValute>(stringJSON);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Variables
    {
        public static void value(string charcode, ref int nominal, ref string name, ref double values, ref double previous)
        {
            nominal = 0;
            name = "";
            values = 0.0;
            previous = 0.0;
            if (charcode == "USD")
            {
                nominal = JSONConnect.DataCurrency.Valute.USD.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.USD.Name);
                values = JSONConnect.DataCurrency.Valute.USD.Value;
                previous = JSONConnect.DataCurrency.Valute.USD.Previous;
            }
            if (charcode == "EUR")
            {
                nominal = JSONConnect.DataCurrency.Valute.EUR.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.EUR.Name);
                values = JSONConnect.DataCurrency.Valute.EUR.Value;
                previous = JSONConnect.DataCurrency.Valute.EUR.Previous;
            }
        }
    }
}

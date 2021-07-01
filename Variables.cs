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
            if (charcode == "RUB")
            {
                nominal = 1;
                name = "Российский рубль";
                values = 1;
                previous = 1;
            }
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
            if (charcode == "AUD")
            {
                nominal = JSONConnect.DataCurrency.Valute.AUD.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.AUD.Name);
                values = JSONConnect.DataCurrency.Valute.AUD.Value;
                previous = JSONConnect.DataCurrency.Valute.AUD.Previous;
            }
            if (charcode == "AZN")
            {
                nominal = JSONConnect.DataCurrency.Valute.AZN.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.AZN.Name);
                values = JSONConnect.DataCurrency.Valute.AZN.Value;
                previous = JSONConnect.DataCurrency.Valute.AZN.Previous;
            }
            if (charcode == "GBP")
            {
                nominal = JSONConnect.DataCurrency.Valute.GBP.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.GBP.Name);
                values = JSONConnect.DataCurrency.Valute.GBP.Value;
                previous = JSONConnect.DataCurrency.Valute.GBP.Previous;
            }
            if (charcode == "AMD")
            {
                nominal = JSONConnect.DataCurrency.Valute.AMD.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.AMD.Name);
                values = JSONConnect.DataCurrency.Valute.AMD.Value;
                previous = JSONConnect.DataCurrency.Valute.AMD.Previous;
            }
            if (charcode == "BYN")
            {
                nominal = JSONConnect.DataCurrency.Valute.BYN.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.BYN.Name);
                values = JSONConnect.DataCurrency.Valute.BYN.Value;
                previous = JSONConnect.DataCurrency.Valute.BYN.Previous;
            }
            if (charcode == "BGN")
            {
                nominal = JSONConnect.DataCurrency.Valute.BGN.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.BGN.Name);
                values = JSONConnect.DataCurrency.Valute.BGN.Value;
                previous = JSONConnect.DataCurrency.Valute.BGN.Previous;
            }
            if (charcode == "BRL")
            {
                nominal = JSONConnect.DataCurrency.Valute.BRL.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.BRL.Name);
                values = JSONConnect.DataCurrency.Valute.BRL.Value;
                previous = JSONConnect.DataCurrency.Valute.BRL.Previous;
            }
            if (charcode == "HUF")
            {
                nominal = JSONConnect.DataCurrency.Valute.HUF.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.HUF.Name);
                values = JSONConnect.DataCurrency.Valute.HUF.Value;
                previous = JSONConnect.DataCurrency.Valute.HUF.Previous;
            }
            if (charcode == "HKD")
            {
                nominal = JSONConnect.DataCurrency.Valute.HKD.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.HKD.Name);
                values = JSONConnect.DataCurrency.Valute.HKD.Value;
                previous = JSONConnect.DataCurrency.Valute.HKD.Previous;
            }
            if (charcode == "DKK")
            {
                nominal = JSONConnect.DataCurrency.Valute.DKK.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.DKK.Name);
                values = JSONConnect.DataCurrency.Valute.DKK.Value;
                previous = JSONConnect.DataCurrency.Valute.DKK.Previous;
            }
            if (charcode == "INR")
            {
                nominal = JSONConnect.DataCurrency.Valute.INR.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.INR.Name);
                values = JSONConnect.DataCurrency.Valute.INR.Value;
                previous = JSONConnect.DataCurrency.Valute.INR.Previous;
            }
            if (charcode == "KZT")
            {
                nominal = JSONConnect.DataCurrency.Valute.KZT.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.KZT.Name);
                values = JSONConnect.DataCurrency.Valute.KZT.Value;
                previous = JSONConnect.DataCurrency.Valute.KZT.Previous;
            }
            if (charcode == "CAD")
            {
                nominal = JSONConnect.DataCurrency.Valute.CAD.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.CAD.Name);
                values = JSONConnect.DataCurrency.Valute.CAD.Value;
                previous = JSONConnect.DataCurrency.Valute.CAD.Previous;
            }
            if (charcode == "KGS")
            {
                nominal = JSONConnect.DataCurrency.Valute.KGS.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.KGS.Name);
                values = JSONConnect.DataCurrency.Valute.KGS.Value;
                previous = JSONConnect.DataCurrency.Valute.KGS.Previous;
            }
            if (charcode == "CNY")
            {
                nominal = JSONConnect.DataCurrency.Valute.CNY.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.CNY.Name);
                values = JSONConnect.DataCurrency.Valute.CNY.Value;
                previous = JSONConnect.DataCurrency.Valute.CNY.Previous;
            }
            if (charcode == "MDL")
            {
                nominal = JSONConnect.DataCurrency.Valute.MDL.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.MDL.Name);
                values = JSONConnect.DataCurrency.Valute.MDL.Value;
                previous = JSONConnect.DataCurrency.Valute.MDL.Previous;
            }
            if (charcode == "NOK")
            {
                nominal = JSONConnect.DataCurrency.Valute.NOK.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.NOK.Name);
                values = JSONConnect.DataCurrency.Valute.NOK.Value;
                previous = JSONConnect.DataCurrency.Valute.NOK.Previous;
            }
            if (charcode == "PLN")
            {
                nominal = JSONConnect.DataCurrency.Valute.PLN.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.PLN.Name);
                values = JSONConnect.DataCurrency.Valute.PLN.Value;
                previous = JSONConnect.DataCurrency.Valute.PLN.Previous;
            }
            if (charcode == "RON")
            {
                nominal = JSONConnect.DataCurrency.Valute.RON.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.RON.Name);
                values = JSONConnect.DataCurrency.Valute.RON.Value;
                previous = JSONConnect.DataCurrency.Valute.RON.Previous;
            }
            if (charcode == "XDR")
            {
                nominal = JSONConnect.DataCurrency.Valute.XDR.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.XDR.Name);
                values = JSONConnect.DataCurrency.Valute.XDR.Value;
                previous = JSONConnect.DataCurrency.Valute.XDR.Previous;
            }
            if (charcode == "SGD")
            {
                nominal = JSONConnect.DataCurrency.Valute.SGD.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.SGD.Name);
                values = JSONConnect.DataCurrency.Valute.SGD.Value;
                previous = JSONConnect.DataCurrency.Valute.SGD.Previous;
            }
            if (charcode == "TJS")
            {
                nominal = JSONConnect.DataCurrency.Valute.TJS.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.TJS.Name);
                values = JSONConnect.DataCurrency.Valute.TJS.Value;
                previous = JSONConnect.DataCurrency.Valute.TJS.Previous;
            }
            if (charcode == "TRY")
            {
                nominal = JSONConnect.DataCurrency.Valute.TRY.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.TRY.Name);
                values = JSONConnect.DataCurrency.Valute.TRY.Value;
                previous = JSONConnect.DataCurrency.Valute.TRY.Previous;
            }
            if (charcode == "TMT")
            {
                nominal = JSONConnect.DataCurrency.Valute.TMT.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.TMT.Name);
                values = JSONConnect.DataCurrency.Valute.TMT.Value;
                previous = JSONConnect.DataCurrency.Valute.TMT.Previous;
            }
            if (charcode == "UZS")
            {
                nominal = JSONConnect.DataCurrency.Valute.UZS.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.UZS.Name);
                values = JSONConnect.DataCurrency.Valute.UZS.Value;
                previous = JSONConnect.DataCurrency.Valute.UZS.Previous;
            }
            if (charcode == "UAH")
            {
                nominal = JSONConnect.DataCurrency.Valute.UAH.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.UAH.Name);
                values = JSONConnect.DataCurrency.Valute.UAH.Value;
                previous = JSONConnect.DataCurrency.Valute.UAH.Previous;
            }
            if (charcode == "CZK")
            {
                nominal = JSONConnect.DataCurrency.Valute.CZK.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.CZK.Name);
                values = JSONConnect.DataCurrency.Valute.CZK.Value;
                previous = JSONConnect.DataCurrency.Valute.CZK.Previous;
            }
            if (charcode == "SEK")
            {
                nominal = JSONConnect.DataCurrency.Valute.SEK.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.SEK.Name);
                values = JSONConnect.DataCurrency.Valute.SEK.Value;
                previous = JSONConnect.DataCurrency.Valute.SEK.Previous;
            }
            if (charcode == "CHF")
            {
                nominal = JSONConnect.DataCurrency.Valute.CHF.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.CHF.Name);
                values = JSONConnect.DataCurrency.Valute.CHF.Value;
                previous = JSONConnect.DataCurrency.Valute.CHF.Previous;
            }
            if (charcode == "ZAR")
            {
                nominal = JSONConnect.DataCurrency.Valute.ZAR.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.ZAR.Name);
                values = JSONConnect.DataCurrency.Valute.ZAR.Value;
                previous = JSONConnect.DataCurrency.Valute.ZAR.Previous;
            }
            if (charcode == "KRW")
            {
                nominal = JSONConnect.DataCurrency.Valute.KRW.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.KRW.Name);
                values = JSONConnect.DataCurrency.Valute.KRW.Value;
                previous = JSONConnect.DataCurrency.Valute.KRW.Previous;
            }
            if (charcode == "JPY")
            {
                nominal = JSONConnect.DataCurrency.Valute.JPY.Nominal;
                name = Convert.ToString(JSONConnect.DataCurrency.Valute.JPY.Name);
                values = JSONConnect.DataCurrency.Valute.JPY.Value;
                previous = JSONConnect.DataCurrency.Valute.JPY.Previous;
            }
        }
    }
}

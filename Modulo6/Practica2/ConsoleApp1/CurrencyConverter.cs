using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CurrencyConverter
    {
        public static double Euro2Libra(string currencyEuro)
        {
            double euro =  Double.Parse(currencyEuro);
            return euro * 0.87;
        }

        public static double Euro2Dolar(string currencyEuro)
        {
            double euro = Double.Parse(currencyEuro);
            return euro * 1.12;
        }

        public static double Libra2Euro(string currencyLibra)
        {
            double libra = Double.Parse(currencyLibra);
            return libra /0.87;
        }
        public static double Libra2Dolar(string currencyLibra)
        {
            double libra = Double.Parse(currencyLibra);
            return libra * 1.29;
        }

        public static double Dolar2Euro(string currencyDolar)
        {
            double dolar = Double.Parse(currencyDolar);
            return dolar / 1.12;
        }

        public static double Dolar2Libra(string currencyDolar)
        {
            double dolar = Double.Parse(currencyDolar);
            return dolar / 1.29;
        }

    }
}

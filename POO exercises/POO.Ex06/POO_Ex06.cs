using System;
using System.Globalization;
namespace POO_Ex06 {
    internal class Program {
        static void Main(string[] args) {

            double Dolar, DolarExchange;

            Console.WriteLine("What's the dollar exchange rate?");
            DolarExchange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("How much dollar will you buy?");
            Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ReaisPrice = CurrencyConverter.ReaisPrice(Dolar, DolarExchange);
            Console.WriteLine("Amount to be paid in reais:"+ReaisPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

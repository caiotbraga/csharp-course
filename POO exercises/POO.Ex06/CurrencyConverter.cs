using System;
namespace POO_Ex06 {
    internal class CurrencyConverter {

        public static double IOF = 6.0; 
        public static double ReaisPrice(double Dolar, double DolarExchange) {
            return (Dolar * DolarExchange) + (Dolar * DolarExchange * IOF / 100);
        }
    }
}

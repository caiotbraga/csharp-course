using System;
using System.Globalization;

namespace uri1051 {
    class Program {
        static void Main(string[] args) {

            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax;
            if (salary <= 2000.0) {
                tax = 0.0;
            }
            else if (salary <= 3000.0) {
                tax = (salary - 2000.0) * 0.08;
            }
            else if (salary <= 4500.0) {
                tax = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                tax = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (tax == 0.0) {
                Console.WriteLine("Isent");
            }
            else {
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

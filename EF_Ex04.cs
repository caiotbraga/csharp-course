using System;
using System.Globalization;

namespace EF_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            int n, i;
            double division, n1, n2;
            Console.WriteLine("Insert the vallue N:");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++) {
                Console.WriteLine("Insert a number:");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert the second number:");
                n2 = double.Parse(Console.ReadLine());
                if(n2 == 0) {
                    Console.WriteLine("Impossible division");
                }

                else {
                    division = n1 / n2;
                    Console.WriteLine($"The results of division was:{division:F1}", CultureInfo.InvariantCulture);
                }
            }

        }
    }
}

using System;

namespace EC_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert the code:");
            Console.WriteLine("1 - Hot-dog: R$4,00");
            Console.WriteLine("2 - X-Salad: R$4,50");
            Console.WriteLine("3 - X-Bacon: R$5,00");
            Console.WriteLine("4 - Simple toast bread: R$2,00");
            Console.WriteLine("5 - Soda: R$1,50");
            int code = int.Parse(Console.ReadLine());
            if (code == 1) {
                Console.WriteLine("Insert the amount:");
                int qnt = int.Parse(Console.ReadLine());
                double total = qnt * 4.00;
                Console.WriteLine($"The purchase total was:{total}");
            }
            else if (code == 2) {
                Console.WriteLine("Insert the amount:");
                int qnt = int.Parse(Console.ReadLine());
                double total = qnt * 4.50;
                Console.WriteLine($"The purchase total was:{total}");
            }
            else if (code == 3) {
                Console.WriteLine("Insert the amount:");
                int qnt = int.Parse(Console.ReadLine());
                double total = qnt * 5.00;
                Console.WriteLine($"The purchase total was:{total}");
            }
            else if (code == 4) {
                Console.WriteLine("Insert the amount:");
                int qnt = int.Parse(Console.ReadLine());
                double total = qnt * 2.00;
                Console.WriteLine($"The purchase total was:{total}");
            }
            else {
                Console.WriteLine("Insert the amount:");
                int qnt = int.Parse(Console.ReadLine());
                double total = qnt * 1.50;
                Console.WriteLine($"The purchase total was:{total}");
            }
        }
    }
}


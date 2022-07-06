using System;

namespace EW_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            double x, y;
            Console.WriteLine("Inser the vallue to x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Inser the vallue to y:");
            y = double.Parse(Console.ReadLine());
            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("First");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("Fourth");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Second");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Third");
                }
                Console.WriteLine("Inser the vallue to x:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Inser the vallue to y:");
                y = double.Parse(Console.ReadLine());
            }
        }
    }
}

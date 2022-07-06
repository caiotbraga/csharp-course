using System;

namespace EC_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            double x, y;
            Console.WriteLine("Inser the vallue to x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Inser the vallue to y:");
            y = double.Parse(Console.ReadLine());
            if (x == 0 && y == 0) {
                Console.WriteLine("Origin");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y == 0) {
                Console.WriteLine("X axis");
            }
            else if (y > 0 && x == 0) {
                Console.WriteLine("Y axis");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if(x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
        }
    }
}

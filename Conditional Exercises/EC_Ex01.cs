using System;

namespace EC_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            if(number < 0) {
                Console.WriteLine("The number is negative");
            }
            else {
                Console.WriteLine("The number is positive");
            }
        }
    }
}

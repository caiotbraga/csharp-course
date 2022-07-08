using System;

namespace EC_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 == 0) {
                Console.WriteLine("This is a even number");
            }
            else {
                Console.WriteLine("This is a odd number");
            }
        }
    }
}

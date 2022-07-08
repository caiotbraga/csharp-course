using System;

namespace EC_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert a vallue to A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a vallue to B:");
            int B = int.Parse(Console.ReadLine());
            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Is multiple");
            }
            else{
                Console.WriteLine("Is not multiple");
            }
        }
    }
}

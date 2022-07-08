using System;

namespace EF_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            int n, i;
            Console.WriteLine("Insert a number:");
            n = int.Parse(Console.ReadLine());
            for(i = 1; i <= n; i++) {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}");
            }
        }
    }
}

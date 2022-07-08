using System;

namespace EF_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            int n, i;
            Console.WriteLine("Insert a number:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

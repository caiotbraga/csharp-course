using System;

namespace EF_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            int n, i, factorial;
            Console.WriteLine("Insert the vallue for N:");
            n = int.Parse(Console.ReadLine());
            factorial = n;
            for(i = n - 1; i != 0; i--) {
                factorial = factorial * (i);
            }
            Console.WriteLine($"The factorial of the number {n} is: {factorial}");
        }
    }
}

using System;

namespace EF_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            int x;
            Console.WriteLine("Insert the vallue x");
            x = int.Parse(Console.ReadLine());
            while (x < 1 || x > 1000) {
                Console.WriteLine("Insert the vallue x");
                x = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

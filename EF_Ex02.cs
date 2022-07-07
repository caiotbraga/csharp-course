using System;

namespace EF_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            int n, x, i;
            int contIn = 0, contOut = 0;
            Console.WriteLine("Insert how many times x will be readed");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++) {
                Console.WriteLine("Inesert x vallue:");
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    contIn++;
                }
                else {
                    contOut++;
                }
            }
            Console.WriteLine($"In:{contIn}");
            Console.WriteLine($"Out:{contOut}");
        }
    }
}

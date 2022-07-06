using System;

namespace ES_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D:");
            int D = int.Parse(Console.ReadLine());
            int resultado = ((A * B) - (C * D));
            Console.WriteLine($"O resultado da diferenca do produto A e B pelo produto C e D é {resultado}");
        }
    }
}

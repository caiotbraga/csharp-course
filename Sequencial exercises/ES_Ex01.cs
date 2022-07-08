using System;

namespace ES_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            int n1;
            int n2;
            Console.WriteLine("Informe um número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro número:");
            n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"O valor da soma de {n1} e {n2} é de {soma}");
        }
    }
}

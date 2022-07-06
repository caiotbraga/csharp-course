using System;

namespace ES_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o raio do circulo:");
            double r = double.Parse(Console.ReadLine());
            double area;
            area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"O valor do raio foi {r} e calculando a area a partir disso é de {area:F4}");

        }
    }
}

using System;

namespace ES_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("What's the code of the object 1?");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("How many objects 1 do you want?");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("How much is the object 1?");
            double price = double.Parse(Console.ReadLine());
            double value1 = price * (double)quantity;
            
            Console.WriteLine("What's the code of the object 2?");
            int code2 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many objects 2 do you want?");
            int quantity2 = int.Parse(Console.ReadLine());
            Console.WriteLine("How much is the object 2?");
            double price2 = double.Parse(Console.ReadLine());
            double value2 = price2 * (double)quantity2;
            double valueTotal = value1 + value2;
            Console.WriteLine($"The value of your purchase is {valueTotal}");
        }
    }
}

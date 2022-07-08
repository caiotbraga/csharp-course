using System;

namespace EC_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert the vallue");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 25) {
                Console.WriteLine("The number is in the range [0-25]");
            }
            else if (number > 25 && number < 50) {
                Console.WriteLine("The number is in the range [25-50]");
            }
            else if (number > 50 && number < 75) {
                Console.WriteLine("The number is in the range [50-75]");
            }
            else if (number > 75 && number < 100) {
                Console.WriteLine("The number is in the range [75-100]");
            }
        }
    }
}

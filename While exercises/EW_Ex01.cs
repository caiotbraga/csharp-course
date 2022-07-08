using System;

namespace EW_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Password:");
            int password = int.Parse(Console.ReadLine());
            while (password != 2002) {
                Console.WriteLine("Incorrect password!");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Allowed acess!");
        }
    }
}

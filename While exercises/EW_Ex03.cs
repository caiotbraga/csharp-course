using System;

namespace EW_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            int code, countA = 0, countG = 0, countD = 0;
            Console.WriteLine("1:Alcohol");
            Console.WriteLine("2:Gasoline");
            Console.WriteLine("3:Diesel");
            Console.WriteLine("4:End");
            Console.WriteLine("What kind of fuel do you want to fill?");
            code = int.Parse(Console.ReadLine());
            while (code != 1 && code != 2 && code != 3 && code != 4) {
                Console.WriteLine("Invalid code. Insert a code between [1-4]");
                code = int.Parse(Console.ReadLine());
            }
            while (code != 4) {
                Console.WriteLine("1:Alcohol");
                Console.WriteLine("2:Gasoline");
                Console.WriteLine("3:Diesel");
                Console.WriteLine("4:End");
                Console.WriteLine("What kind of fuel do you want to fill?");
                code = int.Parse(Console.ReadLine());
                while (code != 1 && code != 2 && code != 3 && code != 4) {
                    Console.WriteLine("Invalid code. Insert a code between [1-4]");
                    code = int.Parse(Console.ReadLine());
                }
                if (code == 1) {
                    countA++;
                }
                else if (code == 2) {
                    countG++;
                }
                else if(code == 3){
                    countD++;
                }
            }
            Console.WriteLine("Thank you!");
            Console.WriteLine($"Alcohol:{countA}");
            Console.WriteLine($"Gasoline:{countG}");
            Console.WriteLine($"Diesel:{countD}");
        }
    }
}

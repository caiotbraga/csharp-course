using System;

namespace EC_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("What time the game started?");
            int startTime = int.Parse(Console.ReadLine());
            Console.WriteLine("What time the game ended?");
            int endTime = int.Parse(Console.ReadLine());
            int time;
            if (startTime < endTime) {
                time = endTime - startTime;
                
            }
            else {
                time = 24 - startTime + endTime;
            }

            Console.WriteLine($"The time duration of the game it was:{time}");
        }
    }
}

using System;

namespace ES_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("What's the employee number?");
            int number= int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked?");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("How much is your hourly wage?");
            double salaryPerHour = double.Parse(Console.ReadLine());
            double salary;
            salary = hours * salaryPerHour;
            Console.WriteLine($"The employee number is{number} and your salary is:{salary:f2}");
        }
    }
}

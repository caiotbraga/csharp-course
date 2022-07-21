using System;
using Enum_Ex02.Entities;
using Enum_Ex02.Entities.Enums;
using System.Globalization;
namespace Enum_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string departmentN, name, monthAndYear;
            double baseSalary, valuePerHour;
            WorkerLevel wLevel;
            int n, duration;

            Console.WriteLine("Enter department's name:");
            departmentN = Console.ReadLine();
            
            Department department = new Department(departmentN);
            
            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");   name = Console.ReadLine();
            Console.Write("Level:");  wLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("BaseSalary:");   baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, wLevel, baseSalary, department);

            Console.Write("How many contracts to this worker?");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY):"); DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:"); valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration:"); duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+worker.Department.Name);
            Console.WriteLine($"Income for {monthAndYear} : {worker.Income(year, month)}");
        }
    }
}

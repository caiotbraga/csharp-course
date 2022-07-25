using System;
using System.Collections.Generic;
using Her_Ex01.Entities;
namespace Her_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, hours;
            string name;
            double valuePerHour, additionalCharge;

            List<Employee> ListE = new List<Employee>();

            Console.Write("How many Employee`s data do you wanna insert? "); n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee {i + 1} data: ");
                Console.Write("Outsourced? (y/n)"); char outsourced = char.Parse(Console.ReadLine());
                if (outsourced == 'y')
                {
                    Console.Write("Name: "); name = Console.ReadLine();
                    Console.Write("Hours: "); hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: "); valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: "); additionalCharge = double.Parse(Console.ReadLine());
                    OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    ListE.Add(outsourcedEmployee);
                }
                else
                {
                    Console.Write("Name: "); name = Console.ReadLine();
                    Console.Write("Hours: "); hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: "); valuePerHour = double.Parse(Console.ReadLine());
                    Employee employee = new Employee(name, hours, valuePerHour);
                    ListE.Add(employee);
                }
            }
            Console.WriteLine();
            foreach (Employee employee in ListE)
            {
                Console.WriteLine(employee);
            }
            foreach (OutsourcedEmployee outsourcedEmployee in ListE)
            {
                Console.WriteLine(outsourcedEmployee);
            }
        }
    }
}

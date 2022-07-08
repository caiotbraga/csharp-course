using System;
using System.Globalization;

namespace POO_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            
            Employee employee1, employee2;
            employee1 = new Employee();
            employee2 = new Employee();

            double averageSalary;

            Console.WriteLine("Insert the first employee name:");
            employee1.Name = Console.ReadLine();
            Console.WriteLine("Insert the first employee salary:");
            employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insert the second employee name:");
            employee2.Name = Console.ReadLine();
            Console.WriteLine("Insert the second employee salary:");
            employee2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("First employee data:");
            Console.WriteLine($"Name: {employee1.Name}");
            Console.WriteLine($"Salary: {employee1.Salary:f2}");
            
            Console.WriteLine("Second employee data:");
            Console.WriteLine($"Name: {employee2.Name}");
            Console.WriteLine($"Salary {employee2.Salary:f2}");
            averageSalary = (employee1.Salary + employee2.Salary) / 2;
            Console.WriteLine($"Average salary: {averageSalary:f2}");
        }
    }
}

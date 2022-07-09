using System;

namespace POO_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            
            Employee employee = new Employee();
            double percentage;
            
            Console.WriteLine("Insert the employee's name:");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Insert the employee's gross salary:");
            employee.GrossSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the tax:");
            employee.Tax = double.Parse(Console.ReadLine());

            Console.WriteLine(employee);

            Console.WriteLine("Insert the percentage to increase the gross salary:");
            percentage = double.Parse(Console.ReadLine());
            employee.IncreaseSalary(percentage);

            Console.WriteLine();

            Console.WriteLine($"Updated data:{employee}");
        }
    }
}

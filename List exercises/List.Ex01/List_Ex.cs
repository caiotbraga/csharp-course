using System;
using System.Collections.Generic;
using System.Globalization;
namespace List_Ex {
    internal class Program {
        static void Main(string[] args) {

            int n, id, i, searchId;
            string name;
            double salary, percentage;
            
            Console.WriteLine("How many peoples will be registred?");
            n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (i = 0; i < n; i++) {
                Console.WriteLine("Employee "+(i+1)+":");
                Console.WriteLine("ID:");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                name = Console.ReadLine();
                Console.WriteLine("Salary:");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary)); // instanciando o objeto na lista
                Console.WriteLine();
            }
            Console.WriteLine("Enter the employee id that will have salary increase :");
            searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId); // criando a variavel objeto 
            if(emp != null) {
                Console.WriteLine("Enter the percentage:");
                percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Updated list of employees:");
            foreach(Employee employee in list) {
                Console.WriteLine(employee);
            }
        }
    }
}

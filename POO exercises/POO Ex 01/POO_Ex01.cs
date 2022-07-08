using System;

namespace POO_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            
            People people1, people2;
            people1 = new People();
            people2 = new People();

            Console.WriteLine("Insert the name of the people 1:");
            people1.Name = Console.ReadLine();
            Console.WriteLine("Insert the age of the people 1:");
            people1.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insert the name of the people 2:");
            people2.Name = Console.ReadLine();
            Console.WriteLine("Insert the age of the people 2:");
            people2.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("First person data:");
            Console.WriteLine($"Name:{people1.Name}");
            Console.WriteLine($"Age:{people1.Age}");
            Console.WriteLine("Second person data:");
            Console.WriteLine($"Name:{people2.Name}");
            Console.WriteLine($"Age:{people2.Age}");
            if(people1.Age > people2.Age) {
                Console.WriteLine($"Oldest person:{people1.Name}");
            }
            else {
                Console.WriteLine($"Oldest person:{people2.Name}");
            }
        }
    }
}

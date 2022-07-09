using System;
using System.Globalization;
namespace POO_Ex05 {
    internal class Program {
        static void Main(string[] args) {

            Student student = new Student();
            
            Console.WriteLine("Insert the name of the student:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Insert the first grade:");
            student.Grade1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second grade:");
            student.Grade2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the third grade:");
            student.Grade3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Grade: "+student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Approval()) {
                Console.WriteLine("Approved");
            }
            else {
                Console.WriteLine("Disapproved");
                Console.WriteLine("Remaining grade:"+student.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture)+ "points.");
            }
        }
    }
}

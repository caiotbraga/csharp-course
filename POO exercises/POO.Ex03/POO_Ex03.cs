using System;
using System.Globalization;
namespace POO_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            
            Rectangle rectangle;
            rectangle = new Rectangle();

            Console.WriteLine("Insert the rectangle's width:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insert the rectangle's height:");
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

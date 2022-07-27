using System;
using System.Globalization;
using AbstractM_Ex01.Entities;
using AbstractM_Ex01.Entities.Enums;
using System.Collections.Generic;
namespace AbstractM_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Isert the number of shapes: "); int n = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle? (r/c)"); char type = char.Parse(Console.ReadLine());
                if(type == 'r')
                {
                    Console.Write("Color (Black, Blue, Red) :"); Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: "); double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: "); double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Rectangle rectangle = new Rectangle(width, height, color);
                    list.Add(rectangle);
                }
                else
                {
                    Console.Write("Color (Black, Blue, Red) :"); Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: "); double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Circle circle = new Circle(radius, color);
                    list.Add(circle);
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

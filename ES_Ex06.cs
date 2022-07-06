using System;

namespace ES_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            double A, B, C;
            double triangleArea, circleArea, trapezeArea, squareArea, rectangleArea;
            Console.WriteLine("Insert the value of A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the value of B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the value of C:");
            C = double.Parse(Console.ReadLine());
            triangleArea = A * C / 2;
            circleArea = Math.PI * Math.Pow(C, 2);
            trapezeArea = (A + B) * C / 2;
            squareArea = Math.Pow(B, 2);
            rectangleArea = A * B;
            Console.WriteLine($"The area of triangle is:{triangleArea:F3}");
            Console.WriteLine($"The area of circle is:{circleArea:F3}");
            Console.WriteLine($"The area of trapeze is:{trapezeArea:F3}");
            Console.WriteLine($"The area of square is:{squareArea:F3}");
            Console.WriteLine($"The area of rectangle is:{rectangleArea:F3}");

        }
    }
}




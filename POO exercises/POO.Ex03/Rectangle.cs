using System;
namespace POO_Ex03 {
    internal class Rectangle {
        public double Height;
        public double Width;

        public double Area() {
            return Height * Width;
        }

        public double Perimeter() {
            return (2 * Height) + (2 * Width);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        }
    }
}

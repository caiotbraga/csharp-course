using AbstractM_Ex01.Entities.Enums;
namespace AbstractM_Ex01.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}

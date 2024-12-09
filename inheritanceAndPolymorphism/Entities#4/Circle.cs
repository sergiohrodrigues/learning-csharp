using inheritanceAndPolymorphism.Entities_4.Enums;

namespace inheritanceAndPolymorphism.Entities_4
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

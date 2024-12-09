using inheritanceAndPolymorphism.Entities_4.Enums;

namespace inheritanceAndPolymorphism.Entities_4
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

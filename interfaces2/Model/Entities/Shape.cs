using interfaces2.Model.Enums;

namespace interfaces2.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}

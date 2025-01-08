﻿using interfaces2.Model.Enums;

namespace interfaces2.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}

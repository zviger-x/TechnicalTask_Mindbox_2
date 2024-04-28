using System;

namespace EasyShapes.Shapes
{
    public struct Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}

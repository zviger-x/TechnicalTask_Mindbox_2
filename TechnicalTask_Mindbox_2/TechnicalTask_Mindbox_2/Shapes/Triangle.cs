using System;

namespace EasyShapes.Shapes
{
    public struct Triangle : IShape
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double GetArea()
        {
            var p = A + B + C;
            return Math.Sqrt(p) * (p - A) * (p - B) * (p - C);
        }

        public bool IsRightTriangle()
        {
            var sides = new double[] { A, B, C };
            Array.Sort(sides);
            var g = sides[2];
            var c1 = sides[1];
            var c2 = sides[0];

            return g * g == c1 * c1 + c2 * c2;
        }
    }
}

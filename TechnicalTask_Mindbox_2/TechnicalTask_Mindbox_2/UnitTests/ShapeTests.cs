using EasyShapes.Shapes;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace EasyShapes.UnitTests
{
    [TestFixture]
    public class ShapeTests
    {
        [TestCase(2, 12.56637)]
        [TestCase(5, 78.53982)]
        [TestCase(9, 254.469)]
        [TestCase(245, 188574.09903)]
        public void GetCircleArea(double radius, double expected)
        {
            var circle = new Circle(radius);
            var area = circle.GetArea();

            Assert.That(area, Is.EqualTo(expected).Within(.0001));
        }

        [TestCase(2, 3, 4, 2.904738)]
        [TestCase(5, 8, 10, 19.810035)]
        [TestCase(9, 14, 16, 62.780869)]
        [TestCase(20, 20, 30, 198.431348)]
        public void GetTriangleArea(double a, double b, double c, double expected)
        {
            var triangle = new Triangle(a, b, c);
            var area = triangle.GetArea();

            Assert.That(area, Is.EqualTo(expected).Within(.0001));
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(6, 10, 8, true)]
        [TestCase(10, 10, 10, false)]
        public void IsRightTriangle(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);
            var isRightTriangle = triangle.IsRightTriangle();

            ClassicAssert.AreEqual(expected, isRightTriangle);
        }
    }
}

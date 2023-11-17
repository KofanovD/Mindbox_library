using Mindbox_library;

namespace Mindbox_library_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            Assert.That(circle.GetArea(), Is.EqualTo(expectedArea).Within(0.001));
        }
        [Test]
        public void TestTriangleArea()
        {
            double a = 10, b = 8, c = 3;
            var triangle = new Triangle(a, b, c);
            double s = (a + b + c) / 2; // semiperimeter
            double expectedArea = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Assert.That(triangle.GetArea(), Is.EqualTo(expectedArea).Within(0.001));
        }
        [Test]  
        public void TestIsRightAngled()
        {
            double a = 3, b = 10, c = 8;
            var triangle = new Triangle(a, b, c);
            bool res = triangle.IsRightAngled();
        }
    }
}
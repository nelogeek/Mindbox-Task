using ShapeLib.Shapes;
using System.Text;

namespace ShapeLib.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.54, circle.GetArea(), 0.01);
        }

        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 0.01);
        }

        [Test]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(4, 4, 4);
            Assert.IsTrue(triangle.IsRight());
        }
    }
}
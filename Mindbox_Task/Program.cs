using ShapeLib.Shapes;
using System.Text;
namespace Mindbox_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Circle circle = new Circle(5);
            Console.WriteLine("Circle area = " + circle.GetArea());

            Triangle triangle = new Triangle(4, 4, 4);
            Console.WriteLine("Triangle area = " + triangle.GetArea());
            Console.WriteLine("Triangle is right: " + triangle.IsRight());

            Console.ReadKey();
        }
    }
}

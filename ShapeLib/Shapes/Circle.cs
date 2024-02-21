using ShapeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.Shapes
{
    public class Circle : IShape
    {
        double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

using ShapeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.Shapes
{
    public class Triangle : IShape
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        private double side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double GetArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public bool IsRight()
        {
            return side1 == side2 && side2 == side3 ? true : false;
        }
    }
}

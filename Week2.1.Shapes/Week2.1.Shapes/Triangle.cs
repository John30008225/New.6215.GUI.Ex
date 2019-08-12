using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2._1.Shapes
{
    class Triangle : ITriangle, IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double ThirdSide { get; set; }

        public double Area()
        {
            Console.WriteLine("\nTriangle Area is: ");
            double p = (Width + Height + ThirdSide) / 2;
            return Math.Sqrt(p * (p - Width) * (p * (p - Height) * (p - ThirdSide)));

        }

        public Triangle(double w, double h, double t)
        {
            Width = w;
            Height = h;
            ThirdSide = t;
        }

    }
}

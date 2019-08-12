using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2._1.Shapes
{
    public class Elipse : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height * Math.PI;
        }

        public Elipse(double w, double h)
        {
            Width = w;
            Height = h;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2._1.Shapes
{
    class AreaCalculator
    {
        public static List<double> Area(IShape[] shapes)
        {
            List<double> area = new List<double>();
            foreach (var shape in shapes)
            {
                area.Add(shape.Area());
            }

            return area;
        }
    }
}

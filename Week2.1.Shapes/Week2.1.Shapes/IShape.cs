using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2._1.Shapes
{
    public interface IShape
    {
        double Width { get; set; }
        double Height { get; set; }
        double Area();
    }
}

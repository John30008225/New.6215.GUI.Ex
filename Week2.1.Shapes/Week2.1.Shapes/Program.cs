using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2._1.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Rectangle(24.00, 8.00),
                new Rectangle(36.00, 9.00),
                new Elipse(12.00, 12.00),
                new Triangle(10.00 , 10.00 , 10.00 )
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
            Console.ReadLine();
        }
    }
}

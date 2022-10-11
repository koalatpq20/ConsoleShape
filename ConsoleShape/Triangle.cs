using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShape
{
    public class Triangle : Shape
    {
        public double Length2 { get; set; }
        public double Length3 { get; set; }
        public double Height { get; set; }

        public override string ShapeType => "Hình tam giác - Triangle";

        public override double GetPerimeter()
        {
            return Length1 + Length2 + Length3;
        }

        public override double GetArea()
        {
            return (Length1 * Height) / 2;
        }
    }
}

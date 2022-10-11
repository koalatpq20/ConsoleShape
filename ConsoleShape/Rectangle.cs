using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShape
{
    /// <summary>
    /// Definition of Rectangle
    /// </summary>
    public class Rectangle : Shape
    {
        public double Length2 { get; set; }

        public override string ShapeType => "Hình chữ nhật - Rectangle";

        public override double GetPerimeter()
        {
            return Length1 * 2 + Length2 * 2;
        }

        public override double GetArea()
        {
            return Length2 * Length2;
        }
    }
}

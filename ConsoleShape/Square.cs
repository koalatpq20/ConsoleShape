using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShape
{
    /// <summary>
    /// Hình vuông - kế thừa lớp cha Shape
    /// </summary>
    public class Square : Shape
    {
        public override string ShapeType => "Hình vuông - Square";

        /// <summary>
        /// Tính chu vi
        /// </summary>
        /// <returns>Chu vi</returns>
        public override double GetPerimeter()
        {
            return Length1 * 4;
        }

        /// <summary>
        ///  Tính diện tích
        /// </summary>
        /// <returns>Diện tích</returns>
        public override double GetArea()
        {
            return Math.Pow(Length1, 2);
        }
    }
}

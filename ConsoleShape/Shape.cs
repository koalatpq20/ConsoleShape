using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShape
{
    /// <summary>
    /// Lớp cha - supperclass
    /// </summary>
    public abstract class Shape
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }

        public abstract string ShapeType { get; }
        
        public string Information
        {
            get => $"Loại hình {ShapeType} - Chu Vi {GetPerimeter()} - Diện tích {GetArea()}";
        }

        /// <summary>
        /// Tính chu vi
        /// </summary>
        /// <returns>kiểu số thực - double</returns>
        public abstract double GetPerimeter();

        /// <summary>
        /// Tính diện tích
        /// </summary>
        /// <returns>kiểu số thực</returns>
        public abstract double GetArea();
    }
}

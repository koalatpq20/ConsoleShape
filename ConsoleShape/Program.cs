using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Nhập hình bạn muốn tạo: \n 1. Chữ nhật \n 2.Vuông \n 3.Tam giác");

            int type = Convert.ToInt16(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Rectangle rect = new Rectangle();

                    Console.WriteLine("Khởi tạo hình chữ nhật thành công. Nhập chiều dài, chiều rộng ...");
                    rect.Length1 = Convert.ToInt16(Console.ReadLine());
                    rect.Length2 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine(rect.Information);
                    break;
                case 2:
                    Square square = new Square();

                    Console.WriteLine("Khởi tạo hình vuông thành công. Nhập chiều dài cạnh ...");
                    square.Length1 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine(square.Information);

                    break;
                case 3:
                    Triangle triangle = new Triangle();

                    Console.WriteLine("Khởi tạo tam giác thành công. Nhập chiều dài 3 cạnh ...");
                    triangle.Length1 = Convert.ToInt16(Console.ReadLine());
                    triangle.Length2 = Convert.ToInt16(Console.ReadLine());
                    triangle.Length3 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine(triangle.Information);

                    break;
                default:
                    
                    break;
            }

            Console.ReadLine();
        }
    }
}

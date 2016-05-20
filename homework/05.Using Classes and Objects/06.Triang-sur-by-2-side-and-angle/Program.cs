using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triang_sur_by_2_side_and_angle
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLength = double.Parse(Console.ReadLine());
            double secLenth = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double area = (firstLength * secLenth * Math.Sin(angle * Math.PI / 180)) / 2;
            Console.WriteLine("{0:F2}", area);
        }
    }
}

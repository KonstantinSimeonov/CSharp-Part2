using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_3_sides
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            double halfPerimeter = (first + second + third) / 2;
            double surfaceArea = Math.Sqrt(halfPerimeter * (halfPerimeter - first) *
                            (halfPerimeter - second) * (halfPerimeter - third));
            Console.WriteLine("{0:F2}", surfaceArea);
        }
    }
}

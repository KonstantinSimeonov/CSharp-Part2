using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_S_and_A
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            double surface = (length * altitude) / 2;
            Console.WriteLine("{0:F2}", surface);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNumerics
{
    class Program
    {
        static int BinaryNum( string binary)
        {
            int sum = 0;
            foreach (var bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryNum("10000000000"));
        }
    }
}

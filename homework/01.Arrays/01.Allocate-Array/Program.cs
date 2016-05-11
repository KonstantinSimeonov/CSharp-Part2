using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] N = new int[input];
            for (int i = 0; i < N.Length * 5; i += 5)
            {

                Console.WriteLine(i);
            }
        }
    }
}

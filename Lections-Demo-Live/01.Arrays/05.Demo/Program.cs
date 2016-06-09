using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] squares = new int[n];
            for (int i = 0; i < n; i++)
            {
                squares[i] = i * i;
            }
            Console.WriteLine(string.Join(", ", squares));



        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array_2d = new int[3, 3];
            int rows = array_2d.GetLength(0);
            int cols = array_2d.GetLength(1);

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(" " + array_2d[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    array_2d[i, j] = int.Parse(input[j]);
                }
            }

        }
    }
}

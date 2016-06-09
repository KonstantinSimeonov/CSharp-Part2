using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[][] pascalTriangle = new int[n + 1][];

            pascalTriangle[0] = new int[] { 1 };
            //pascalTriangle[1] = new int[] { 1, 1 };
            //pascalTriangle[2] = new int[] { 1, 2, 1 };
            for (int i = 1; i <= n; i++)
            {
                pascalTriangle[i] = new int[i + 1];
                pascalTriangle[i][0] = 1;
                for (int j = 1; j < i; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1]
                                         + pascalTriangle[i - 1][j];

                }
                pascalTriangle[i][i] = 1;
            }
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
                //for (int j = 0; j <= i; j++)
                //{
                //    if (j > 0)
                //    {
                //        Console.Write(" ");
                //    }
                //    Console.Write(pascalTriangle[i][j]);
                //}
                //Console.WriteLine();
            }
        }
    }
}

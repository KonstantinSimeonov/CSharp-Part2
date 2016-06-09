using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix = {
                  {7, 1, 3, 3, 2, 1},
                  {1, 3, 9, 8, 5, 6},
                  {4, 6, 7, 9, 1, 0}
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxmalElement = 0; // int.MinValue;
            int minnimalElement = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maxmalElement < matrix [i, j])
                    {
                        maxmalElement = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (minnimalElement > matrix[i, j])
                    {
                        minnimalElement = matrix[i, j];
                    }
                }
            }
            Console.WriteLine(maxmalElement);
            Console.WriteLine(minnimalElement);
        }
    }
}

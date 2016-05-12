using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];
            int[,] array = new int[n, m];
            int maxSum = int.MinValue;
            int startingCol = 0;
            int StartingRow = 0;

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(line[j]);
                }
            }
            for (int row = 0; row < array.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < array.GetLength(1) -2; col++)
                {
                    int sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        sum += array[row, col + i] +array[row + 1, col + i] + array[row + 2, col +i ];
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        StartingRow = row;
                        startingCol = col;
                    }
                }
            }

            Console.WriteLine(maxSum);            
        }
    }
}

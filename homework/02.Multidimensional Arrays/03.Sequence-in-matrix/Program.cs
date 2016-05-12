using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(line[j]);
                }
            }
        }
    }
}

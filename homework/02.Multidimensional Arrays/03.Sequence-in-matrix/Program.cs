using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static int LongestSequence(string[,] array)
        {
            int currentCount = 1;
            int bestCount = 0;
            string itemMostCounted = string.Empty;

            // check by rows
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1) - 1; col++)
                {
                    if (array[row, col] == array[row, col + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = array[row, col];
                    }
                }

                currentCount = 1;
            }

            // check by columns
            for (int col = 0; col < array.GetLength(1); col++)
            {
                for (int row = 0; row < array.GetLength(0) - 1; row++)
                {
                    if (array[row, col] == array[row + 1, col])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = array[row, col];
                    }
                }

                currentCount = 1;
            }

            //check by diagonal left to right
            for (int col = 0; col < array.GetLength(1) - 1; col++)
            {
                for (int row = 0, column = col; row < array.GetLength(0) - 1 && column < array.GetLength(1) - 1; row++, column++)
                {
                    if ((array[row, column] == array[row + 1, column + 1]))
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = array[row, column];
                    }
                }

                currentCount = 1;
            }


            //check by diagonal right to left
            for (int col = array.GetLength(1) - 1; col > 0; col--)
            {
                for (int row = 0, column = col; row < array.GetLength(0) - 1 && column > 0; row++, column--)
                {
                    if (array[row, column] == array[row + 1, column - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = array[row, column];
                    }
                }
            }

            // return string.Join(", ", Enumerable.Repeat(itemMostCounted, bestCount).ToArray());
            return bestCount;
        }

        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            string[,] array = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = currentLine[j];
                }
            }

            Console.WriteLine(LongestSequence(array));
        }
    }
}

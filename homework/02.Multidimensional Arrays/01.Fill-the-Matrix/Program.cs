using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_Matrix
{
    class Program
    {

        static void PrintInput(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (col != array.GetLength(1) - 1)
                    {
                        Console.Write("{0} ", array[row, col]);
                    }
                    else
                    {
                        Console.Write("{0}", array[row, col]);
                    }
                }
                Console.WriteLine();

            }
        }
        static void ArrayA(int n)
        {
            int[,] array = new int[n, n];
            int value = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[j, i] = value;
                    value++;
                }
            }
            PrintInput(array);
        }
        static void ArrayB(int n)
        {
            int[,] array = new int[n, n];
            int value = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        array[row, col] = value;
                        value++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        array[row, col] = value;
                        value++;
                    }
                }
            }
            PrintInput(array);
        }
        static void ArrayC(int n)
        {
            int[,] array = new int[n, n];
            int startRow = n - 1;
            int startCol = 0;
            int k = 0;

            for (int currValue = 1; currValue <= n * n; currValue++)
            {
                int row = startRow + k;
                int col = startCol + k;
                array[row, col] = currValue;
                k++;

                if (startRow > 0 && row == n - 1)
                {
                    startRow--;
                    k = 0;
                }
                else if (col == n - 1)
                {
                    startCol++;
                    k = 0;
                }
            }
            PrintInput(array);
        }
        static void ArrayD(int n)
        {
            int[,] array = new int[n, n];
            bool[,] cellsTested = new bool[n, n];
            int row = 0;
            int col = 0;
            string direction = "down";

            for (int value = 1; value <= n * n; value++)
            {
                array[row, col] = value;
                cellsTested[row, col] = true;

                switch (direction)
                {
                    case "down":
                        if (row == n - 1 || cellsTested[row + 1, col] == true)
                        {
                            col++;
                            direction = "right";
                        }
                        else { row++; }; break;
                    case "right":
                        if (col == n - 1 || cellsTested[row, col + 1] == true)
                        {
                            row--;
                            direction = "up";
                        }
                        else { col++; }; break;
                    case "up":
                        if (row == 0 || cellsTested[row - 1, col] == true)
                        {
                            col--;
                            direction = "left";
                        }
                        else { row--; }; break;
                    case "left":
                        if (cellsTested[row, col - 1] == true )
                        {
                            row++;
                            direction = "down";
                        }
                        else { col--; }; break;
                }
            }

            PrintInput(array);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char array = char.Parse(Console.ReadLine());
            switch (array)
            {
                case 'a': ArrayA(n); break;
                case 'b': ArrayB(n); break;
                case 'c': ArrayC(n); break;
                case 'd': ArrayD(n); break;
            }
        }
    }
}

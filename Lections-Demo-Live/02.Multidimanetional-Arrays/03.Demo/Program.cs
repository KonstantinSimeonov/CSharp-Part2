using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int[][] array = new int[input][];
            string symbol = Console.ReadLine();

            int[,] matrixA = new int[input, input];
            int[,] matrixB = new int[input, input];
            int[,] matrixC = new int[input, input];
            int[,] matrixD = new int[input, input];

            switch (symbol)
            {
                case "a":
                    for (int i = 1; i < array.Length * array.Length; i ++)
                    {
                        for (int j = 0; j < array.Length * array.Length; j++)
                        {
                            matrixA[i,j] = i + j;
                            if (j > 0)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(matrixA[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "b":
                    break;
                case "c":
                    break;

                case "d":
                    break;

                default:
                    break;
            }
        }
    }
}

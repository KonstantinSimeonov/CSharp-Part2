using System;
using System.Collections.Generic;
using System.Linq;                                  //dictionary  ==    .Select()
using System.Text;
using System.Threading.Tasks;

namespace _05.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[5][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(" " + array[i][j]);
                }
                //foreach (int cell in array[i])
                //{
                //    Console.Write(" " + cell);
                //}
                Console.WriteLine();
            }


        }
    }
}

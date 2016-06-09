using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                array[i] = new int[5 + i];
                Console.WriteLine(array[i].Length);
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

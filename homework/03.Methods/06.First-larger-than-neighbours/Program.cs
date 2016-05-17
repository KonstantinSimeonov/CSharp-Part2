using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static int FirstLargerThanNeighbour(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    count = i;
                    break;
                }
                else
                {
                    count = -1;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(FirstLargerThanNeighbour(num));
        }
    }
}

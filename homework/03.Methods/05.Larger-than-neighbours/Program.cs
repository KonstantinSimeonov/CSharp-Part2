using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static int Neighbours(int [] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array [ i - 1] < array[i] && array[i +1] < array[i])
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Neighbours(num));
        }
    }
}

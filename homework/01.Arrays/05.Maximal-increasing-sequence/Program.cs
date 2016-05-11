using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            array[0] = int.Parse(Console.ReadLine());
            int max = 1;
            int current = 1;

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > array[i - 1])
                {
                    current += 1;
                    max = Math.Max(current, max);
                }
                else
                {
                    current = 1;
                }
            }
                Console.WriteLine(max);
        }
    }
}

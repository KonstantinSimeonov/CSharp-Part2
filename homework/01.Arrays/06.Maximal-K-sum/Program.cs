using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            int maxSum = 0;

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < K; i++)
            {
                maxSum += array[i];
            }
            Console.WriteLine(maxSum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());     
            }

            List<int> consecutive = new List<int>();
            foreach (var number in array)
            {
                consecutive.Add(number);
                currentSum += number;
                if (currentSum <= 0)
                {
                    currentSum = 0;
                    consecutive.Clear();
                }
                else if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine(maxSum);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] longest = new int[n];
            for (int i = 0; i < n; i++)
            {
                longest[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] <= array[i])
                    {
                        longest[i] = Math.Max(longest[i], longest[j] + 1);
                    }
                }
            }
            Console.WriteLine(n - longest.Max());
        }
    }
}

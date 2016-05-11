using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = int.Parse(Console.ReadLine());
            int max = 0;
            int current = 1;

            for (int i = 1; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] ==array[i - 1])
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

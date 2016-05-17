using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static int GettingXFromArray(int[] array, int x)
        {
            int count = 0;
            foreach (var number in array)
            {
                if (number == x)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(GettingXFromArray(array, x));
        }
    }
}

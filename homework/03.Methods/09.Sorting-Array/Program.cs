using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}

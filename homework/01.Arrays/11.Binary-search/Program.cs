using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_search
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
            // x = number in array search
            int x = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int min = 0;
            int mid = array.Length / 2;
            int max = array.Length - 1;
            bool searchedNumber = false;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (array[mid] == x)
                {
                    searchedNumber = true;
                    Console.WriteLine(mid);
                    break;
                }
                else if (array[mid] < x)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            if (!searchedNumber)
            {
                Console.WriteLine(-1);
            }
            //int xIndex = Array.BinarySearch(array, x);
            //Console.WriteLine(xIndex);

        }
    }
}

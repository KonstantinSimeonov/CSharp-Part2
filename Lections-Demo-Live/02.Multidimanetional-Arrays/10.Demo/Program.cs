using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10000];
            //Console.WriteLine(arr.Rank);

            //var arr = new int[] { 1, 2, 5, 6, 8, 1, 2 };
            //int index = Array.IndexOf(arr, 8);          //Array.LastIndexOf
            // Console.WriteLine(index);

            //var arr = new int[] { 1, 2, 5, 6, 8, 1, 2 };
            //int[] arr2 = new int[16];
            //Array.Copy(arr, arr2, 5);
            //Console.WriteLine(string.Join(" ", arr2));

            var arr = new int[] { 1, 2, 5, 6, 8, 1, 2 };
            var arr2 = arr.Reverse();
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}

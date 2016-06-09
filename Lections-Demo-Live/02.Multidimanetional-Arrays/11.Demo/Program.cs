using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 1, 2, 3, 5, 8};
            Array.Copy(arr, 0, arr.Length);
        }
    }
}

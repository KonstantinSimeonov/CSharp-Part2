using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 2, 1 };
            int [] b = { 1, 2, 3, 4, 2 };
            //bool isSymetric = true;
            //for (int i = 0; i < nums.Length / 2; i++)
            //{
            //    if (nums[i] != nums[nums.Length - i - 1])
            //    {
            //        isSymetric = false;
            //        break;
            //    }

            //}
            //Console.WriteLine(isSymetric);

            for (int i = 0; i < b.Length ; i++)
            {
                Console.WriteLine(b[i]);
            }
            foreach (object number in nums)
            {
                Console.WriteLine(number);
            }
        }
    }
}

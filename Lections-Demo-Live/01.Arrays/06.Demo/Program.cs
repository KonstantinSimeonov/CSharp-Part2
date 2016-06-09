using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _06.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 5, 7, 7, 1, 2, 3, 4 };
            //for (int i = 0; i < numbers.Length; i+= 2)
            //{
            //    Console.WriteLine(numbers[i]);               
            //}

            int[] numbers = Enumerable.Range(0, 100000).ToArray();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            int a = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                a = numbers[i];
            }
            timer.Restart();
            int b = 0;
            foreach (var item in numbers)
            {
                b = item;
            }
            Console.WriteLine(b);





        }
    }
}

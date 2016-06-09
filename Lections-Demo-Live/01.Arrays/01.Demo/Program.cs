using System;

namespace _01.Demo
{
    //class Gosho { }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers;
            //char[] symbol;
            //Gosho[] gosho;

            //int[] numbers = new int[]{ 1, 2, 5, 8, -77 }; 
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);

            //}

            int[] numbers = new int[] { 1, 2, 5, 8, -77 };
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(numbers.Length);



        }
    }
}

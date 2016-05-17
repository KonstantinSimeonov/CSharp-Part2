using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static int MinimumNumber( int[] input)
        {
            int minimalNumber = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (minimalNumber > input[i])
                {
                    minimalNumber = input[i];
                }
            }
            return minimalNumber;
        }
        static int MaximumNumber(int[] input)
        {
            int maximalNumber = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (maximalNumber < input[i])
                {
                    maximalNumber = input[i];
                }
            }
            return maximalNumber;
        }
        static double AverageNumber(int[] input)
        {
            long sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            double averageOfNumbers = (double)sum / input.Length;
            return averageOfNumbers;
        }
        static long SumNumbers(int[] input)
        {
            long sum = 0;
            foreach(var number in input)
            {
                sum += number;
            }
            return sum;
        } 
        static long ProductOfNumbers(int[] input)
        {
            long product = 1;
            foreach (var num in input)
            {
                product *= num;
            }
            return product;
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(MinimumNumber(input));
            Console.WriteLine(MaximumNumber(input));
            Console.WriteLine("{0:F2}", AverageNumber(input));
            Console.WriteLine(SumNumbers(input));
            Console.WriteLine(ProductOfNumbers(input));

        }
    }
}

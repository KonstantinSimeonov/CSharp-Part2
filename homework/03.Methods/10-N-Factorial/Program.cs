using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_N_Factorial
{
    class Program
    {
        static BigInteger Factorial(int[] sequeceArray)
        {
            BigInteger result = 1;
            for (int i = 0; i < sequeceArray.Length; i++)
            {
                result *= sequeceArray[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequeceArray = new int[n];
            for (int i = 0; i < sequeceArray.Length; i++)
            {
                sequeceArray[i] = i + 1;
            }

            Console.WriteLine(Factorial(sequeceArray));
        }
    }
}

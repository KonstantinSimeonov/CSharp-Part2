using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomails
{
    class Program
    {
        public static int[] Polynominals(int[] firstPolynominal, int[] secondPolynominal)
        {
            if (firstPolynominal.Length < secondPolynominal.Length)
            {
                return Polynominals(secondPolynominal, firstPolynominal);
            }
            int[] polynominalSum = new int[firstPolynominal.Length];
            for (int i = 0; i < secondPolynominal.Length; i++)
            {
                polynominalSum[i] = secondPolynominal[i] + firstPolynominal[i];
            }
            for (int i = secondPolynominal.Length; i < firstPolynominal.Length; i++)
            {
                polynominalSum[i] = firstPolynominal[i];
            }
            return polynominalSum;
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = Polynominals(first, second);
            var result = new List<int>();
            for (int i = 0; i < sum.Length; i++)
            {
                result.Add(sum[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

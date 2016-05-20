using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static string DecimalToBinary(long decNumber)
        {
            long remainder = 0;
            string binary = string.Empty;
            while (decNumber > 0)
            {
                remainder = decNumber % 2;
                decNumber /= 2;
                binary = remainder + binary;
            }
            return binary;
        }
        static long BinaryToDecimal(string binary)
        {
            long result = 0;
            int power = binary.Length - 1;
            for (int i = 0; i < binary.Length; i++)
            {
                int currentNumber = binary[i] - '0';
                result += currentNumber * (long)Math.Pow(2, power);
                power--;
            }

            return result;
        }
        static void Main(string[] args)
        {
            //    long decNumber = long.Parse(Console.ReadLine());
            //    Console.WriteLine(DecimalToBinary(decNumber));
            string binaryNumber = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binaryNumber));
        }
    }
}

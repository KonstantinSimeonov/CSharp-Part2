using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.One_system_to_any_other
{
    class Program
    {
        static BigInteger Powered(BigInteger number, BigInteger powered)
        {
            BigInteger result = 1;
            for (int i = 0; i < powered; i++)
            {
                result *= number;
            }
            return result;
        }
        static BigInteger BaseToDecimal(string number, BigInteger baseNumber)
        {
            BigInteger decNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                BigInteger digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }
                decNumber += digit * Powered(baseNumber, number.Length - i - 1);
            }
            return decNumber;
        }
        static string DecimalToSecondBase( BigInteger decNumber, BigInteger baseNumber)
        {
            string result = string.Empty;
            while (decNumber > 0)
            {
                BigInteger digit = decNumber % baseNumber;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }
                decNumber /= baseNumber;
            }
            return result;
        }
        static void Main(string[] args)
        {
            BigInteger inputFromBase = BigInteger.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            BigInteger inputToBase = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToSecondBase(BaseToDecimal(number, inputFromBase), inputToBase));
        }
    }
}

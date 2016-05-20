using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _03.Decima_to_hexadecimal
{
    class Program
    {
        static long HexadecimalToDecimal(string hexadecNumber)
        {
            long result = 0;
            int power = hexadecNumber.Length - 1;
            for (int i = 0; i < hexadecNumber.Length; i++)
            {
                int current = 0;
                if (hexadecNumber[i] >= '0' && hexadecNumber[i] <= '9')
                {
                    current = hexadecNumber[i] - '0';
                }
                else if (hexadecNumber[i] >= 'A' && hexadecNumber[i] <= 'F')
                {
                    current = hexadecNumber[i] - 'A' + 10;
                }
                result += current * (long)Math.Pow(16, power);
                power--;
            }
            return result;
        }
        static string DecimalToHexadecimal(BigInteger decNumber)
        {
            string hexadecimal = string.Empty;
            while (decNumber > 0)
            {
                BigInteger remainingNumber = decNumber % 16;
                if (remainingNumber >= 0 && remainingNumber <= 9)
                {
                    hexadecimal = (char)(remainingNumber + '0') + hexadecimal;
                }
                else if (remainingNumber >= 10 && remainingNumber <= 15)
                {
                    hexadecimal = (char)(remainingNumber - 10 + 'A') + hexadecimal;
                }
                decNumber /= 16;
            }
            return hexadecimal;

        }
        static void Main(string[] args)
        {
            BigInteger inputDecimal = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHexadecimal(inputDecimal));
            //string hexadecNumberInput = Console.ReadLine();
            //Console.WriteLine(HexadecimalToDecimal(hexadecNumberInput));
        }
    }
}

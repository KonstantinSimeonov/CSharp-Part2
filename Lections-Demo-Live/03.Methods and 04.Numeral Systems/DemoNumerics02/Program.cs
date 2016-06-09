using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNumerics02
{
    class Program
    {
        static string DecimalToBynary(int decValue)
        {
            string binary = "";
            while (decValue != 0)
            {
                int bit = decValue % 2;
                binary = bit + binary;
                decValue /= 2;
            }
            return binary;
        }
        static int HexDigitConv(char hexDigit)
        {
            if (char.IsDigit (hexDigit))
            {
                return hexDigit - '0';
            }
            return hexDigit - 'A' + 10;

        }
        static void Main(string[] args)
        {
            char[] hexDigits = "0123456789ABCDEF".ToCharArray();
            foreach (char hex in hexDigits)
            {
                Console.WriteLine("{0} -> {1}", hex, HexDigitConv(hex));
            }
            //Console.WriteLine(DecimalToBynary(123));

            Console.WriteLine(unchecked(uint)-123123123);
        }


    }
}

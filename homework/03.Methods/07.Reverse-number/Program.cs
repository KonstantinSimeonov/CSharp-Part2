using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static string ReverseNumber(string number)
        {
            string reverseNumber = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverseNumber += number[i];
            }
            return reverseNumber;
        }
        static void Main(string[] args)
        {
            string numberReverse = Console.ReadLine();

            Console.WriteLine(ReverseNumber(numberReverse));
        }
    }
}

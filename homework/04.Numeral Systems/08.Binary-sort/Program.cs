using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_sort
{
    class Program
    {
        static string ShortBinary(short number)
        {
            char[] binary = new char[16];
            for (int i = 0, position = 15; i < 16; i++, position--)
            {
                if ((number & (1 << i)) != 0)
                {
                    binary[position] = '1';
                }
                else
                {
                    binary[position] = '0';
                }
            }
            return new string(binary);
        }
        static void Main(string[] args)
        {
            short inputNumber = short.Parse(Console.ReadLine());
            Console.WriteLine(ShortBinary(inputNumber));
        }
    }
}

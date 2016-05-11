using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int loopLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < loopLength; i++)
            {
                if (first[i] > second[i] || i == loopLength - 1 && first.Length > second.Length)
                {
                    Console.WriteLine(">");
                    return;
                }
                else if (first[i] < second[i] || i == loopLength - 1 && first.Length < second.Length)
                {
                    Console.WriteLine("<");
                    return;
                }
                else if (i == loopLength - 1 && first.Length == second.Length)
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n + 1];     //  erotosthenes

            for (int i = 2; i <= Math.Sqrt(array.Length); i++)
            {
                if (array[i] == false)
                {
                    for (int j = i * i; j < array.Length; j += i)
                    {
                        array[j] = true;
                    }
                }
            }
            for (int i = array.Length - 1; i >= 2; i--)
            {
                if (!array[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}

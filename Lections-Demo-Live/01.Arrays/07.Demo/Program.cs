using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
                Console.WriteLine(numbers.Count);
            }
            Console.WriteLine(string.Join(", ", numbers));


        }
    }
}

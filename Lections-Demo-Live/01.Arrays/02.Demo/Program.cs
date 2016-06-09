using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = new string[4];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}
            //Console.WriteLine(string.Join("---", names));

            //char[] symbols = "gosho e gosho".ToCharArray();

            //char[] reversedSymbols = new char[symbols.Length];
            //for (int i = symbols.Length - 1; i >= 0; i--)
            //{
            //    reversedSymbols[reversedSymbols.Length - i - 1] = symbols[i];

            //}
            //Console.WriteLine(string.Join(string.Empty, symbols));


            char[] symbols = "gosho e gosho".ToCharArray();
            for (int i = 0; i < symbols.Length /2; i++)
            {
                char store = symbols[i];
                symbols[i] = symbols[symbols.Length - i - 1];
                symbols[symbols.Length - i - 1] = store;
            }

            Console.WriteLine(string.Join(string.Empty, symbols));
        }
    }
}

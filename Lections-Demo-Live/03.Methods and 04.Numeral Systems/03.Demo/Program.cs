using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Demo
{
    class Program
    {
        //static void printConcatanneted(string leftString, string rightString)
        //{
        //    Console.WriteLine(leftString + rightString);
        //}
        //static void Main(string[] args)
        //{
        //    printConcatanneted(" asda", "     asdaaaaa");
        //}


        static int Parse(string number)
        {
            int result = 0;
            foreach (var digit in number)
            {
                result = (digit - '0' + result * 10);
            }
            return result;
        }
        static int Parse(char [] digits)
        {
            return 0;
        }
        static void Main()
        {
            Console.WriteLine(Parse("251"));
            var parsedValue = Parse("251");
            Console.WriteLine(parsedValue);
        }


    }
}

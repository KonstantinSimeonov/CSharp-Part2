using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majem
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sentance = "shte hodim na kafe sled lekcia";
            //var piece = sentance.Substring(5, 6);
            //var piece2 = sentance.Substring(5, 3);
            //var piece3 = sentance.Substring(5);
            //Console.WriteLine(piece);
            //Console.WriteLine(piece2);
            //Console.WriteLine(piece3);
            //for (int i = 0; i < sentance.Length; i++)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();
            //int start = 10;
            //int end = 13;
            //var piece4 = sentance.Substring(start, end - start);
            //Console.WriteLine(piece4);

            //var numbers = "1 2 3 4 5 6 7 8".Split(' ');
            //Console.WriteLine(numbers);

            //Console.WriteLine("00001001101".TrimStart('0'));
            //Console.WriteLine("000001001001001111".TrimEnd('1'));
            //Console.WriteLine("aaa ccaa abba bbabb abaabaaa bbbaacc aaa".Trim('a'));

            var binary = "111010";
            Console.WriteLine(binary.PadLeft(32, '0'));
            Console.WriteLine(binary.PadRight(64, '0'));
        }
    }
}

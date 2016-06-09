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
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //int[][] answer = new int[3][];
            int[] count = { 0, 0, 0 };
            foreach (int number in input)
            {
                count[number % 3]++;
                //switch(number % 3)
                //{
                //    case 0:
                //        count[0]++;
                //        break;
                //    case 1:
                //        count[1]++;
                //        break;
                //    case 2:
                //        count[2]++;
                //        break;
                //    default: break;
                //}
            }
            int[][] answer ={
                new int [ count[0]],
                new int [ count[1]],
                new int[count[2]]};

            count = new int[] { 0, 0, 0 };
            foreach (int number in input)
            {
                int remainder = number % 3;
                answer[remainder][count[remainder]] = number;
                count[remainder]++;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Remainder {0}:", i);
                foreach (var number in answer[i])
                {
                    Console.Write(" {0}", number);

                }
                Console.WriteLine();            //0 1 4 113 55 3 1 2 66 557 124 2
            }
        }

    }

}

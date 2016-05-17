using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class Program
    {
        static string SwitchCaseStricture(int N)
        {
            switch (N % 10)
            {
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                default: return "zero"; break;
            }
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(SwitchCaseStricture(N));

        }
    }
}

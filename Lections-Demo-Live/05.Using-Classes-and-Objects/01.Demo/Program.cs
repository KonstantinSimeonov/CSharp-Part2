using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Demo
{
    class Program
    {
        static void ChangeValue (ref int a)
        {
            a = 435;
        }
        static void Main(string[] args)
        {
            int a = 5;
            ChangeValue(ref a);
            Console.WriteLine(a);
            //bool b = true;
            Console.WriteLine(sizeof(bool));
        }
    }
}

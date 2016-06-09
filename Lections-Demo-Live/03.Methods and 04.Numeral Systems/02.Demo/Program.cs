using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Demo
{
    class Program
    {
        static void PrintToConsole(object name)
        {
            Console.WriteLine("Az sum " + name);
            Console.WriteLine("i sym mnogo yako parche");
        }
        static void callOtherMethod()
        {
            PrintToConsole("C#");
        }
        static void Main(string[] args)
        {
        //    PrintToConsole(5);
        //    PrintToConsole("Goshoko");
            callOtherMethod();
        }
    }
}

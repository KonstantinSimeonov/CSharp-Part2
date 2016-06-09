using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.TrimExcess();
            string command = Console.ReadLine();
            List<string> commands = new List<string>();
            while (command != "END")
            {

                commands.Add(command);
                command = Console.ReadLine();
                command.Insert(2, "gosho");


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int repeatingNumber = array[0];
            int timesRepeated = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                timesRepeated = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        timesRepeated++;
                        //count = timesRepeated;
                        //repeatingNumber = array[i];
                    }
                }
                if (count < timesRepeated)
                {
                    count = timesRepeated;
                    repeatingNumber = array[i];
                }
            }
            Console.WriteLine("{0} ({1} times)", repeatingNumber, count);
        }
    }
}

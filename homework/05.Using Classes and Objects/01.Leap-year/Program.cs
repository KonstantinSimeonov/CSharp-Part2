using System;

namespace _01.Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearInput = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(yearInput) == true)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}

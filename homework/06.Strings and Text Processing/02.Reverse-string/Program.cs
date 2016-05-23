namespace _02.Reverse_string
{
    using System;
    using System.Linq;

    class Program
    {
        static string ReverseString(string input)
        {
            char[] inputToArray = input.ToArray();
            Array.Reverse(inputToArray);
            return new string(inputToArray);
        }
        static void Main()
        {
            string inputStringToReverse = Console.ReadLine();

            Console.WriteLine(ReverseString(inputStringToReverse));
        }
    }
}

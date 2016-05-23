namespace _06.String_length
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            inputString = inputString.Replace("\\", String.Empty);


            Console.WriteLine(inputString.PadRight(20, '*'));
        }
    }
}

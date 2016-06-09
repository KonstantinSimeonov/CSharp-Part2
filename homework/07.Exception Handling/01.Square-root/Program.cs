namespace _01.Square_root
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double numberInput = double.Parse(Console.ReadLine());
                double outputNumber = Math.Sqrt(numberInput);
                if (numberInput < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number");
                }
                Console.WriteLine("{0:F3}", outputNumber);
                //numberInput
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");

            }
            Console.WriteLine("Good bye");
        }
    }
}

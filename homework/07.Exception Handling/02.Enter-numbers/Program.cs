namespace _02.Enter_numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static int InputNumbers(int first, int last)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            if (inputNumbers <= first || inputNumbers >= last)
            {
                throw new ArgumentOutOfRangeException("Exception");
            }
            return inputNumbers;
        }

        static void Main(string[] args)
        {
            int[] inputNumbers = new int[10];
            int first = 0;
            int last = 100;

            try
            {
                inputNumbers[0] = InputNumbers(first, last);
                for (int i = 1; i < inputNumbers.Length; i++)
                {
                    first = inputNumbers[i - 1];
                    inputNumbers[i] = InputNumbers(first, last);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception");
                return;
            }

            Console.Write("1 < ");
            Console.Write(string.Join(" < ", inputNumbers));
            Console.Write(" < 100");
        }
    }
}

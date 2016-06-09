namespace _1.Calculation_Problem
{
    using System;
    using System.Linq;

    class CalculationProblem
    {
        static int CatSoundsToDec(string catSounds)
        {
            int result = 0;
            foreach (var sound in catSounds)
            {
                result = (sound - 'a') + result * 23;
            }
            return result;
        }
        static string SumCatNumbersFromDecimal(int dec)
        {
            var result = string.Empty;
            do
            {
                char digit = (char)('a' + (dec % 23));
                result = digit + result;
                dec /= 23;
            } while (dec > 0);

            return result;
        }
        static void Main()
        {
            var catNumbers = Console.ReadLine().Split(' ').Select(CatSoundsToDec).Sum();

            //Console.WriteLine(string.Join("\r\n", catNumbers));
            //Console.WriteLine(CatSoundsToDec(catNumbers[0]));
            //Console.WriteLine(catNumbers[0]);
            var answer = SumCatNumbersFromDecimal(catNumbers) + " = " + catNumbers;
            Console.WriteLine(answer);
        }
    }
}

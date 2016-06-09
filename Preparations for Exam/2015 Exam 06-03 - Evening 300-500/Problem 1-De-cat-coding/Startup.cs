namespace Problem_De_cat_coding
{
    using System;
    using System.Linq;

    class Startup
    {
        // 1.    Read Input
        // 1.1.  extract all cat numbers from the input
        // 2.    convert all cat numbers to decimal
        // 3.    convert all decimal numbers to base 26
        // 4.    join by space and print
        static ulong CatToDecimal(string catNumber)
        {
            ulong result = 0;
            foreach (char digit in catNumber)
            {
                result = (ulong)(digit - 'a') + result * 21;
            }
            return result;
        }
        static string DecTo26(ulong dec)
        {
            var result = string.Empty;

            do
            {
                char digitValue = (char)('a' + (dec % 26));
                result = digitValue + result;
                //reversed
                //result += digitValue;
                dec /= 26;
            } while (dec > 0);
            return result;
        }
        static void Main()
        {
            //var input = Console.ReadLine().Split(' ').Select(CatToDecimal).Select(DecTo26).ToArray();
            var inputN = Console.ReadLine().Split(' ').Select(x => DecTo26(CatToDecimal(x))).ToArray();

            //Console.Write(string.Join(" ", input));
            //Console.WriteLine();
            Console.Write(string.Join(" ", inputN));
        }
    }
}

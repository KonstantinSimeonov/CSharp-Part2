namespace Problem_1___TRES4_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var numeralSystem = 9;
            var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|"
                                , "SEY&", "EMY>>", "/TEL", "<<DON" };
            ulong numberInDecimal = ulong.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            if (numberInDecimal == 0)
            {
                Console.WriteLine("LON+");
            }
            else
            {

                while (numberInDecimal > 0)
                {
                    int digitIn9th = (int)(numberInDecimal % (ulong)numeralSystem);
                    result.Insert(0, digits[digitIn9th]);
                    numberInDecimal /= (ulong)numeralSystem;
                }
                Console.WriteLine(result.ToString());
            }

        }
    }
}

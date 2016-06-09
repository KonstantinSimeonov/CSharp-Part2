namespace Problem_1_Multiverse_Communication
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Multiverse
    {
        static void Main()
        {
            //var alphabet = new []   -- instead of List
            var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY"
                                    , "VNB", "POQ", "ERI", "CAD", "K-A"
                                    , "IIA", "YLO", "PLA" };
            var input = Console.ReadLine();

            BigInteger decimalRepresentation = 0;
            for (int i = 0; i < input.Length; i +=3)
            {
                var digitIn13 = input.Substring(i, 3);
                //Array.IndexOf   -- instead of List
                var decimalValue = alphabet.IndexOf(digitIn13);
                decimalRepresentation *= 13;
                decimalRepresentation += decimalValue;

            }
            Console.WriteLine(decimalRepresentation);

            //var hex = "FAB1";
            //for (int i = 0; i < hex.Length; i++)
            //{
            //    decimalRepresentation *= 16;
            //    if (hex[i] >= '0' && hex[i] <= '9')
            //    {
            //        decimalRepresentation += hex[i] - '0';
            //    }
            //    else
            //    {
            //        decimalRepresentation += hex[i] + 10 - 'A';
            //    }
            //}
            //Console.WriteLine(decimalRepresentation);
        }
    }
}

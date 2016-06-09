namespace Problem_2_Two_Girl_One_Path
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            int mollyIndex = 0;
            int dollyIndex = numbers.Length - 1;

            BigInteger mollyTottalFlowers = 0;
            BigInteger dollyTottalFlowers = 0;
            string winner = string.Empty;

            while (true)
            {
                if (numbers[mollyIndex] == 0 || numbers[dollyIndex] == 0)
                {
                    if (numbers[mollyIndex] == 0 && numbers[dollyIndex] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (numbers[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (numbers[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }
                    mollyTottalFlowers += numbers[mollyIndex];
                    dollyTottalFlowers += numbers[dollyIndex];
                    break;
                }

                BigInteger currentMollyFlowers = numbers[mollyIndex];
                BigInteger currentDollyFlowers = numbers[dollyIndex];

                //TODO check if both are equal
                if (mollyIndex == dollyIndex)
                {
                    numbers[mollyIndex] = currentMollyFlowers % 2;
                    mollyTottalFlowers += currentMollyFlowers / 2;
                    dollyTottalFlowers += currentDollyFlowers / 2;
                }
                else
                {
                    numbers[mollyIndex] = 0;
                    numbers[dollyIndex] = 0;

                    mollyTottalFlowers += currentMollyFlowers;
                    dollyTottalFlowers += currentDollyFlowers;
                }
                mollyIndex = (int)((mollyIndex + currentMollyFlowers) % numbers.Length);
                dollyIndex = (int)((dollyIndex - currentDollyFlowers) % numbers.Length);
                if (dollyIndex < 0)
                {
                    dollyIndex += numbers.Length;
                }

            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTottalFlowers, dollyTottalFlowers);
        }
    }
}

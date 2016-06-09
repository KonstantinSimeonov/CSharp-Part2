namespace W_Problem_03_Tubes
{
    using System;
    using System.Numerics;

    class Program
    {
        static bool IsSolution(BigInteger size, int m, int[] tubes)
        {
            BigInteger result = 0;
            for (int i = 0; i < tubes.Length; i++)
            {
                result += tubes[i] / size;
            }

            return result >= m;
        }

        static BigInteger Split(int m, int[] tubes)
        {
            BigInteger sum = 0;
            for (var i = 0; i < tubes.Length; i++)
            {
                sum += tubes[i];
            }

            BigInteger high = sum / m;
            BigInteger low = 1;
            BigInteger size = high;

            while (size > 0)
            {
                BigInteger offset;
                var solution = IsSolution(size, m, tubes);
                if (!solution)
                {
                    high = size;
                    offset = -(high - low) / 2;
                }
                else
                {
                    low = size;
                    offset = (high - low) / 2;
                }

                if (offset == 0)
                {
                    if (!solution) size--;
                    break;
                }
                size += offset;
            }

            return size == 0 ? -1 : size;
        }

        static void Equals(BigInteger expected, BigInteger result)
        {
            if (expected == result)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error: Expected {0}, got {1}", expected, result);
            }
        }

        static void Main(string[] args)
        {
            //Equals(100, Split(6, new int[] { 100, 200, 300 }));
            //Equals(200, Split(11, new int[] { 803, 777, 444, 555 }));
            //Equals(-1, Split(3, new int[] { 1, 1 }));
            //Equals(1, Split(2, new int[] { 1, 1, 1 }));

            //return;

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] tubes = new int[n];

            for (int i = 0; i < n; i++)
            {
                tubes[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Split(m, tubes));
        }
    }
}

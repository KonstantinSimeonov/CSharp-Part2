namespace Problem_5___DogeCoin
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            int[,] coint = new int[rows, cols];

            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string[] currentCoords = Console.ReadLine().Split(' ');
                int currentCointRow = int.Parse(currentCoords[0]);
                int currentCointCol = int.Parse(currentCoords[1]);

                coint[currentCointRow, currentCointCol]++;
            }
            int[,] dp = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int maxAbove = 0;
                    int maxLeft = 0;

                    if (row - 1 >=0)
                    {
                        maxAbove = dp[row - 1, col];
                    }
                    if (col - 1 >=0)
                    {
                        maxLeft = dp[row, col - 1];
                    }

                    dp[row, col] = Math.Max(maxAbove, maxLeft) + coint[row, col];
                }
            }
            Console.WriteLine(dp[rows - 1, cols - 1]);
        }
    }
}

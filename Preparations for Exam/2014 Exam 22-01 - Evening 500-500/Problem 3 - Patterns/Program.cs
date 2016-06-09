namespace Problem_3___Patterns
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static int[,] Input()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var numbersAsString = line.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(numbersAsString[j]);
                }
            }
            return matrix;
        }
        private static long DiagonalSum(int [,] matrix)
        {
            long sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, i];
            }
            return sum;
        }

            static void Main(string[] args)
        {
            var matrix = Input();
            var pattern = new bool[,]
            {
                { true, true, true, false, false },
                { false, false, true, false, false },
                { false, false, true, true, true }
            };
            long maxSum = long.MinValue;
            bool correctPattern = false;
            for (int patternsInX = 0; patternsInX <= matrix.GetLength(0) - pattern.GetLength(0); patternsInX++)
            {
                for (int patternsInY = 0; patternsInY <= matrix.GetLength(1) - pattern.GetLength(1); patternsInY++)
                {
                    var numbersInPattern = new List<int>();
                    for (int patternX = 0; patternX < pattern.GetLength(0); patternX++)
                    {
                        for (int patternY = 0; patternY < pattern.GetLength(1); patternY++)
                        {
                            var x = patternsInX + patternX;
                            var y = patternsInY + patternY;

                            if (pattern[patternX, patternY])
                            {
                                numbersInPattern.Add(matrix[x, y]);
                            }
                        }
                    }

                    bool foundCorrectPatter = true;
                    for (int i = 1; i < numbersInPattern.Count; i++)
                    {
                        if (numbersInPattern[i - 1] != numbersInPattern[i] - 1)
                        {
                            foundCorrectPatter = false;
                            break;
                        }
                    }
                    if (foundCorrectPatter)
                    {
                        correctPattern = true;
                        long sum = 0;
                        foreach (var item in numbersInPattern)
                        {
                            sum += item;
                        }
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            if (correctPattern)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
            Console.WriteLine("NO {0}", DiagonalSum(matrix));
            }            
        }
    }
}


namespace Problem_3___Digits
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static int[,] digits;
        static List<bool[,]> InitializeListsOfPatterns()
        {
            var list = new List<bool[,]>();
            list.Add(new bool[,]
            {
                // fake zero :) haha
            });
            list.Add(new bool[,]        //one
                {
                    { false, false, true },
                    { false, true, true },
                    { true, false, true },
                    { false, false, true },
                    { false, false, true }
                });
            list.Add(new bool[,]        //two
                {
                    { false, true, false },
                    { true, false, true },
                    { false, false, true },
                    { false, true, false },
                    { true, true, true }
                });

            list.Add(new bool[,]        //three
                {
                    { true, true, true },
                    { false, false, true },
                    { false, true, true },
                    { false, false, true },
                    { true, true, true }
                });

            list.Add(new bool[,]        //four
                {
                    { true, false, true },
                    { true, false, true },
                    { true, true, true },
                    { false, false, true },
                    { false, false, true }
                });

            list.Add(new bool[,]        //five
                {
                    { true, true, true },
                    { true, false, false },
                    { true, true, true },
                    { false, false, true },
                    { true, true, true }
                });

            list.Add(new bool[,]        //six
                {
                    { true, true, true },
                    { true, false, false },
                    { true, true, true },
                    { true, false, true },
                    { true, true, true }
                });

            list.Add(new bool[,]        //seven
                {
                    { true, true, true },
                    { false, false, true },
                    { false, true, false },
                    { false, true, false },
                    { false, true, false }
                });

            list.Add(new bool[,]        //eight
                {
                    { true, true, true },
                    { true, false, true },
                    { false, true, false },
                    { true, false, true },
                    { true, true, true }
                });

            list.Add(new bool[,]        //nine
                {
                    { true, true, true },
                    { true, false, true },
                    { false, true, true },
                    { false, false, true },
                    { true, true, true }
                });
            return list;
        }
        static bool CheckPattern(bool[,] pattern, int digit, int row, int col)
        {
            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    if (pattern[i, j])
                    {
                        if (digits[row + i, col + j] != digit)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void Main()
        {


            int n = int.Parse(Console.ReadLine());

            var patterns = InitializeListsOfPatterns();

            digits = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < currentLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currentLine[col]);
                }

            }
            int sum = 0;
            for (int row = 0; row <= n - 5; row++)
            {
                for (int col = 0; col <= n - 3; col++)
                {
                    if (digits[row + 2, col] == 1)
                    {
                        if (CheckPattern(patterns[1], 1, row, col))
                        {
                            sum += 1;
                            continue;
                        }
                    }
                    if (digits[row + 1, col] == 2)
                    {
                        if (CheckPattern(patterns[2], 2, row, col))
                        {
                            sum += 2;
                            continue;
                        }
                    }
                    int currentDigits = digits[row, col];
                    if (CheckPattern(patterns[currentDigits], currentDigits, row, col))
                    {
                        sum += currentDigits;
                    }
                    //if (digits[row, col] ==3)
                    //{
                    //    if (CheckPattern(patterns[3], 3, row, col))
                    //    {
                    //        sum += 3;
                    //    }
                    //    continue;
                    //}
                    //if (digits[row, col] == 4)
                    //{
                    //    if (CheckPattern(patterns[4], 4, row, col))
                    //    {
                    //        sum += 4;
                    //    }
                    //    continue;
                    //}
                    //if (digits[row, col] == 5)
                    //{
                    //    if (CheckPattern(patterns[5], 5, row, col))
                    //    {
                    //        sum += 5;
                    //    }
                    //    continue;
                    //}
                    //if (digits[row, col] == 6)
                    //{
                    //    if (CheckPattern(patterns[6], 6, row, col))
                    //    {
                    //        sum += 6;
                    //    }
                    //    continue;
                    //}
                    //if (digits[row, col] == 7)
                    //{
                    //    if (CheckPattern(patterns[7], 7, row, col))
                    //    {
                    //        sum += 7;
                    //    }
                    //    continue;
                    //}
                    //if (digits[row, col] == 8)
                    //{
                    //    if (CheckPattern(patterns[8], 8, row, col))
                    //    {
                    //        sum += 8;
                    //    }
                    //    continue;
                    //}
                    //if (digits[row,col] == 9)
                    //{
                    //    if (CheckPattern(patterns[9], 9, row, col))
                    //    {
                    //        sum += 9;
                    //    }
                    //    continue;
                    //}

                }
            }
            Console.WriteLine(sum);
        }
    }
}

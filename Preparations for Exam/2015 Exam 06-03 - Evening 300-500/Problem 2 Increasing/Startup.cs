namespace Problem_2_Increasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        // 1.   Read Input
        // 2.   For every sequence do the folowing
        // 2.1  calculate sequence of absolute differences
        // 2.2  check if they absolute differences sequence is increasing
        // 2.3  output the result for the current sequence


        static void Main()
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var sequence = Console.ReadLine().Split(' ')
                                      .Select(long.Parse).ToArray();

                bool isIncreasing = true;
                for (int j = 2; j < sequence.Length; j++)
                {
                    var lastAbsDiff = Math.Abs(sequence[j - 2] - sequence[j - 1]);
                    var currentAbsDiff = Math.Abs(sequence[j - 1] - sequence[j]);

                    if (lastAbsDiff > currentAbsDiff || currentAbsDiff - lastAbsDiff > 1)
                    {
                        isIncreasing = false;
                        break;
                    }
                    //Console.WriteLine(lastAbsDiff + " " + currentAbsDiff);
                }
                Console.WriteLine(isIncreasing);
            }
        }
    }
}

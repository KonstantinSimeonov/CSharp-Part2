namespace _03.Correct_brackets
{

    using System;

    class Program
    {
        private static bool BracketsCorrectionChecker(string input)
        {

            int countOfBracket = 0;

            foreach (var letter in input)
            {
                if (letter == '(' )
                {
                    ++countOfBracket;
                }
                else if (letter == ')' )
                {
                    --countOfBracket;
                }
                if (countOfBracket < 0)
                {
                    return false;
                }
            }
            return countOfBracket == 0;
        }
        static void Main()
        {
            string inputWithBrackets = Console.ReadLine();

            Console.WriteLine(BracketsCorrectionChecker(inputWithBrackets) ?
                            "Correct" : "Incorrect");
        }
    }
} 

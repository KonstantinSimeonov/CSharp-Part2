namespace _23.Series_of_letters
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string consecutiveLettersInString = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            char lastOfLetters = '\0';

            foreach (var letter in consecutiveLettersInString)
            {
                if (letter != lastOfLetters)
                {
                    result.Append(letter);
                    lastOfLetters = letter;
                }
            }
            Console.WriteLine(result);
        }
    }
}

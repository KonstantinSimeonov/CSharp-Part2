namespace _08.Extract_sentances
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        private static string[] MatchingsInText(string text, string word)
        {
            char[] separators = { '.', '!', '?', ';' };
            string[] sentanceSeparation = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> matchingsInText = new List<string>();
            foreach (var sentance in sentanceSeparation)
            {
                if (Regex.IsMatch(sentance.ToLower(), String.Format("{0}{1}{2}", "(^|[.;,:!? -])"
                    , word.ToLower(), "([.;,:!? -]|$)", RegexOptions.IgnoreCase)))
                {
                    matchingsInText.Add(sentance.Trim());
                }
            }
            return matchingsInText.ToArray();

        }
        static void Main(string[] args)
        {
            string wordInput = Console.ReadLine();
            string text = Console.ReadLine();

            string[] wordInputMatchings = MatchingsInText(text, wordInput);

            foreach (var sentance in wordInputMatchings)
            {
                Console.Write(sentance + ". ");
            }
        }
    }
}